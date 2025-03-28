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

if (!$fast -and !$SkipNotebook) {
    { . deps/spiral/workspace/target/release/spiral$(_exe) dib --path "$ScriptDir/$projectName.dib" } | Invoke-Block -Retries 3 -Location ../../../polyglot
}

{ . ../../deps/polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" spi } | Invoke-Block

{ . ../../deps/polyglot/apps/spiral/dist/Supervisor$(_exe) --build-file "$projectName.spi" "$projectName.fsx" --timeout 180000 } | Invoke-Block

$runtime = $fast -or $env:CI ? @("--runtime", ($IsWindows ? "win-x64" : "linux-x64")) : @()
$builderArgs = @("$projectName.fsx", "--persist-only", $runtime, "--packages", "Fable.Core", "--modules", @(GetFsxModules), "lib/fsharp/Common.fs")
{ . ../../deps/polyglot/apps/builder/dist/Builder$(_exe) @builderArgs } | Invoke-Block

$targetDir = GetTargetDir $projectName

{ BuildFable $targetDir $projectName "rs" } | Invoke-Block -Location ../../deps/polyglot
(Get-Content "$targetDir/target/rs/$projectName.rs") `
    -replace "../../../lib", "../polyglot/lib" `
    -replace "`"../../../../../deps/spiral", "`"../../deps/polyglot/deps/spiral" `
    -replace "`"./lib", "`"../../deps/polyglot/lib" `
    -replace ".fsx`"]", ".rs`"]" `
    | FixRust `
    | Set-Content "$projectName.rs"

cargo fmt --

if (!$fast) {
    { cargo test --release -- --show-output } | Invoke-Block
}

{ cargo build --release } | Invoke-Block

Write-Output "alphabet/apps/documents/build.ps1 / `$targetDir = $targetDir / `$projectName: $projectName / `$env:CI:'$env:CI'"

if ($env:CI) {
    Remove-Item $targetDir -Recurse -Force -ErrorAction Ignore

    Remove-Item target/release/deps -Recurse -Force -ErrorAction Ignore
    Remove-Item target/release/build -Recurse -Force -ErrorAction Ignore
}
