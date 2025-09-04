param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1


Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://github.com/i574n/hangulize.git
Set-Location hangulize
git pull

if (!(Search-Command "go")) {
    if ($IsWindows) {
        winget install GoLang.Go --disable-interactivity --accept-source-agreements
    }
    else {
        sudo apt update
        sudo apt install -y golang
    }
}

{ go build -C cmd/hangulize } | Invoke-Block
