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

if (!$fast -and !$SkipNotebook) {
    { . ../../deps/spiral/workspace/target/release/spiral$(_exe) dib --path "$ScriptDir/$projectName.dib" --retries 3 } | Invoke-Block -Location ../../../polyglot/lib/fsharp
}

{ . ../../../polyglot/apps/parser/dist/DibParser$(_exe) "$projectName.dib" fs } | Invoke-Block


Write-Output "alphabet/apps/hangul/build.ps1 / `$env:CI:'$env:CI'"
