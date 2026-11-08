param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../../spiral/scripts/core.ps1

$notebooks = @(Get-ChildItem -Filter *.spi | Where-Object { Select-String -LiteralPath $_.FullName -Pattern '^///> ' -Quiet } | ForEach-Object { '--path'; $_.FullName })
$env:SPIRAL_CELLS_MEMO = '0'
Push-Location ($env:SPIRAL_CELLS_ROOT ? $env:SPIRAL_CELLS_ROOT : (Join-Path $ScriptDir '../../deps/spiral/apps/cells'))
try { $cells = @(& pwsh -NoProfile -File (Join-Path 'spi' 'run_notebook.ps1') --gate @notebooks 2>&1 | ForEach-Object { "$_" }); $cellsExit = $LASTEXITCODE }
finally { Pop-Location }
$cells | ForEach-Object { Write-Output "alphabet/apps/hangul/build.ps1 / cells / $_" }
if ($cellsExit -ne 0) { throw "alphabet/apps/hangul/build.ps1 / Spiral test cells exited $cellsExit" }
if (!($cells -match '^spiral-tests total')) { throw "alphabet/apps/hangul/build.ps1 / Spiral test cells printed no spiral-tests total line" }
Write-Output "HANGUL-OK"
