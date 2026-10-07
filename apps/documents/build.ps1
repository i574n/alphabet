param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../deps/polyglot/scripts/core.ps1
. ../../deps/polyglot/deps/spiral/lib/spiral/lib.ps1


$projectName = "documents"

# The notebook runs through Kino (spiral/apps/kino, `mix spiral.notebook`) from its .livemd; a successful run also writes
# the .spi export. A run writes <nb>.livemd.ipynb and <nb>.livemd.html: README and gh-pages link to them.
$livebook = Join-Path $ScriptDir "../../deps/polyglot/deps/spiral/apps/kino/spi/run_notebook.ps1"
$notebook = Join-Path $ScriptDir "$projectName.livemd"
$spi = Join-Path $ScriptDir "$projectName.spi"
$ipynb = Join-Path $ScriptDir "$projectName.livemd.ipynb"
if (!$fast -and !$SkipNotebook) {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --output-path $ipynb } | Invoke-Block -Retries $($env:CI ? 3 : 1)
}
else {
    { pwsh -NoProfile -File $livebook --path $notebook --spi-path $spi --export-only } | Invoke-Block
}

# F#: documents.spi -> documents.fsx (tracked) with the Spiral compiler's own F# backend.
if (!(BuildSpiral "$projectName.spi" "$projectName.fsx" "alphabet/apps/documents" -Backend Fsharp)) {
    throw "FSHARP-FAILED alphabet/apps/documents / compile"
}

$targetDir = GetTargetDir $projectName

# Rust: the documents.spi entry (its `main` has a `Rust` arm that runs `main` with the process args) compiled by the
# Spiral compiler's own Rust backend, no Fable, straight to documents.rs, the crate's binary (Cargo.toml next to this
# script; Cargo.lock pins its dependencies). documents.fsx above is the F# output; its .NET build isn't runnable: the
# app's clap/IO calls exist only for Rust.
if (!(BuildSpiral "$ScriptDir/$projectName.spi" "$ScriptDir/$projectName.rs" "alphabet/apps/documents")) {
    throw "RUST-FAILED alphabet/apps/documents / compile"
}
{ cargo +nightly-2025-11-01 build --release } | Invoke-Block
# Run check: the binary on a small sample (this repo's README.md and a short Portuguese note) with fresh src/dist/cache
# dirs outside any git repository (the app compares git hashes of its inputs), run from this directory (so
# get_workspace_root resolves and hangulize is found). It must exit 0, write the transcription and the html of both
# inputs, and the note's transcription must be exactly the expected text (the output the former Fable binary and the
# Rust one both produced, 2026-10-06).
$rustRunRoot = Join-Path ([IO.Path]::GetTempPath()) "alphabet-documents-run-$PID"
Remove-Item $rustRunRoot -Recurse -Force -ErrorAction Ignore
$rustSample = [ordered]@{
    'README.md' = Get-Content ../../README.md -Raw
    'nota.md'   = "# Nota`n`nA língua portuguesa é falada no Brasil, em Portugal e em Angola.`n"
}
$expectedNota = "# 노타`n# Nota`n`n아 링구아 포르투게자 에 팔라다 누 브라지우, 잉 포르투가우 이 잉 앙골라.`nA língua portuguesa é falada no Brasil, em Portugal e em Angola.`n"
$rustExe = (Resolve-Path "target/release/$projectName$(_exe)").Path
foreach ($d in 'src', 'dist', 'cache') { New-Item -ItemType Directory -Force "$rustRunRoot/$d" | Out-Null }
foreach ($name in $rustSample.Keys) { foreach ($d in 'src', 'dist') { [IO.File]::WriteAllText("$rustRunRoot/$d/$name", $rustSample[$name]) } }
$arguments = @('--source-dir', "$rustRunRoot/src", '--dist-dir', "$rustRunRoot/dist", '--cache-dir', "$rustRunRoot/cache") | ForEach-Object { "`"$_`"" }
$process = Start-Process -FilePath $rustExe -ArgumentList $arguments -WorkingDirectory $ScriptDir `
    -RedirectStandardOutput "$rustRunRoot.out" -RedirectStandardError "$rustRunRoot.err" -PassThru -NoNewWindow
$null = $process.Handle
if (!$process.WaitForExit(900000)) {
    try { $process.Kill($true) } catch { }
    throw "RUST-FAILED alphabet/apps/documents / run timed out (900 s)"
}
Get-Content "$rustRunRoot.out", "$rustRunRoot.err" | Where-Object { $_ -match 'documents\.main' } `
    | ForEach-Object { Write-Output "alphabet/apps/documents/build.ps1 / run / $_" }
$names = @(Get-ChildItem "$rustRunRoot/dist" -File | Sort-Object Name | ForEach-Object Name)
Write-Output "alphabet/apps/documents/build.ps1 / run / exit code $($process.ExitCode) / $($names -join ', ')"
$missing = foreach ($name in $rustSample.Keys) {
    foreach ($expected in "$([IO.Path]::GetFileNameWithoutExtension($name)).hangul.md", "$name.html") {
        if ($names -notcontains $expected) { $expected }
    }
}
$nota = Get-Content "$rustRunRoot/dist/nota.hangul.md" -Raw -ErrorAction Ignore
if ($process.ExitCode -ne 0 -or $missing -or $nota -cne $expectedNota) {
    throw ("RUST-FAILED alphabet/apps/documents / run exit code $($process.ExitCode) (expected 0), missing: $($missing -join ', '), " + `
        "nota.hangul.md $($nota -ceq $expectedNota ? 'as expected' : "differs: '$nota'") (see $rustRunRoot)")
}
Remove-Item $rustRunRoot, "$rustRunRoot.out", "$rustRunRoot.err" -Recurse -Force -ErrorAction Ignore
Write-Output "RUST-OK alphabet/apps/documents"

Write-Output "alphabet/apps/documents/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore
}
