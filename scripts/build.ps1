param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"

. ../../spiral/scripts/core.ps1


{ pwsh ../apps/documents/build.ps1 } | Invoke-Block

{ pwsh ../apps/hangul/build.ps1 } | Invoke-Block

{ pwsh ../lib/build.ps1 } | Invoke-Block

{ pwsh ../apps/font-sans/build.ps1 } | Invoke-Block

{ pwsh ../apps/font-mono/build.ps1 } | Invoke-Block
