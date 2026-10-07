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

# The notebook runs through Kino (spiral/apps/kino, `mix spiral.dib`) from its .livemd (generated from the .dib, the same
# cells): its F# cells and #!import files on one `dotnet fsi` session. The outputs keep the .dib route's names
# (<nb>.dib.ipynb, <nb>.dib.html). The export is F# (hangul.fs, --fs-path), so the run writes no .spi (--no-spi).
$livebook = Join-Path $ScriptDir "../../deps/spiral/apps/kino/spi/livebook_dib.ps1"
$notebook = Join-Path $ScriptDir "$projectName.livemd"
$ipynb = Join-Path $ScriptDir "$projectName.dib.ipynb"
if (!$fast -and !$SkipNotebook) {
    { pwsh -NoProfile -File $livebook --path $notebook --output-path $ipynb --no-spi } | Invoke-Block -Retries $($env:CI ? 3 : 1)
}

{ pwsh -NoProfile -File $livebook --path $notebook --no-spi --fs-path "$ScriptDir/$projectName.fs" --export-only } | Invoke-Block

Write-Output "alphabet/apps/hangul/build.ps1 / `$env:CI:'$env:CI'"
