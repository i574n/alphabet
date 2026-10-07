param(
    $fast,
    $SkipNotebook,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../polyglot/scripts/core.ps1
. ../../../spiral/lib/spiral/lib.ps1


$projectName = "hangul"

# The notebook runs through Kino (spiral/apps/kino, `mix spiral.notebook`) from its .livemd: its F# cells and #!import
# files on one `dotnet fsi` session. A run writes <nb>.livemd.ipynb and <nb>.livemd.html. The export is F# (hangul.fs,
# --fs-path), so the run writes no .spi (--no-spi).
$livebook = Join-Path $ScriptDir "../../deps/spiral/apps/kino/spi/run_notebook.ps1"
$notebook = Join-Path $ScriptDir "$projectName.livemd"
$ipynb = Join-Path $ScriptDir "$projectName.livemd.ipynb"
if (!$fast -and !$SkipNotebook) {
    { pwsh -NoProfile -File $livebook --path $notebook --output-path $ipynb --no-spi } | Invoke-Block -Retries $($env:CI ? 3 : 1)
}

{ pwsh -NoProfile -File $livebook --path $notebook --no-spi --fs-path "$ScriptDir/$projectName.fs" --export-only } | Invoke-Block

Write-Output "alphabet/apps/hangul/build.ps1 / `$env:CI:'$env:CI'"
