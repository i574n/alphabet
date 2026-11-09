param($fast, $ScriptDir = $PSScriptRoot)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../../deps/spiral/scripts/core.ps1
. ../../deps/spiral/lib/spiral/lib.ps1
if (!(BuildSpiral "font_emit.spi" "font_emit.rs" "alphabet/apps/font-emit")) { throw "font_emit / spiral->rust failed" }
{ cargo build --release } | Invoke-Block
$t = (cargo metadata --format-version 1 --no-deps | ConvertFrom-Json).target_directory
& "$t/release/font_emit$(_exe)"
Write-Output "FONT-EMIT-OK"
