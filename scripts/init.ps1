param(
    $fast,
    $ScriptDir = $PSScriptRoot
)
Set-Location $ScriptDir
$ErrorActionPreference = "Stop"


if (!$fast) {
    Set-Location (New-Item -ItemType Directory -Path "../.." -Force)
    git clone --recurse-submodules https://github.com/i574n/polyglot.git # --branch gh-pages
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

{ sudo apt-get update } | Invoke-Block -Linux -Distro ubuntu
{ sudo apt install -y texlive-xetex texlive-full pandoc fonts-nanum-coding } | Invoke-Block -Linux -Distro ubuntu -OnError Continue

{ cargo install --git https://github.com/crowdagger/crowbook.git --locked } | Invoke-Block -OnError Continue

{ pwsh ./dep_hangulize.ps1 } | Invoke-Block
