param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


$url = git ls-remote --get-url
$owner = ($url -split '/' | Select-Object -Last 2 | Select-Object -First 1) -replace '\.git$', '' ?? $env:GITHUB_REPOSITORY_OWNER
$domain = ($url -split '/' | Select-Object -Last 3 | Select-Object -First 1) ?? $env:GITHUB_SERVER_URL -replace 'https?://', ''
Write-Output "init.ps1 / url: $url / owner: $owner / domain: $domain"

if (!$fast) {
    Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
    git clone --recurse-submodules https://$domain/$owner/polyglot.git # --branch gh-pages
    Set-Location polyglot
    git pull
    Set-Location $ScriptDir
    pwsh ../../polyglot/scripts/init.ps1
}

. ../../polyglot/scripts/core.ps1

EnsureSymbolicLink -Path "../deps/polyglot" -Target "../../polyglot"
EnsureSymbolicLink -Path "../deps/spiral" -Target "../../spiral"

{ pwsh ../deps/polyglot/apps/builder/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/polyglot/apps/parser/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/polyglot/apps/spiral/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/polyglot/deps/spiral/apps/spiral/build.ps1 -fast 1 -SkipFsx 1 } | Invoke-Block
{ pwsh ../deps/polyglot/apps/dir-tree-html/build.ps1 -fast 1 } | Invoke-Block

{ sudo apt-get update } | Invoke-Block -Linux -Distro ubuntu -OnError Continue
{ apt-get update } | Invoke-Block -Linux -Distro ubuntu -OnError Continue
{ sudo apt install -y texlive-xetex pandoc fonts-nanum-coding } | Invoke-Block -Linux -Distro ubuntu -OnError Continue
{ apt install -y texlive-xetex pandoc fonts-nanum-coding } | Invoke-Block -Linux -Distro ubuntu -OnError Continue

{ cargo binstall -y --git https://github.com/crowdagger/crowbook.git --locked crowbook } | Invoke-Block -OnError Continue

{ pwsh ./dep_hangulize.ps1 } | Invoke-Block
