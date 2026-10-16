param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"

. ../../polyglot/scripts/core.ps1


{ pwsh ../apps/documents/build.ps1 } | Invoke-Block

{ pwsh ../apps/hangul/build.ps1 } | Invoke-Block
