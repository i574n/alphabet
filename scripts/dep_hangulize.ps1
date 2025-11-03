param(
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"
. ../deps/polyglot/scripts/core.ps1


$url = git ls-remote --get-url
$owner = ($url -split '/' | Select-Object -Last 2 | Select-Object -First 1) -replace '\.git$', '' ?? $env:GITHUB_REPOSITORY_OWNER
$domain = ($url -split '/' | Select-Object -Last 3 | Select-Object -First 1) ?? $env:GITHUB_SERVER_URL -replace 'https?://', ''
Write-Output "dep_hangulize.ps1 / url: $url / owner: $owner / domain: $domain"

Set-Location (New-Item -ItemType Directory -Path "../deps" -Force)
git clone --recurse-submodules https://$domain/$owner/hangulize.git
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
