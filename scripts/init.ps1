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
    git clone --recurse-submodules https://$domain/$owner/polyglot.git
    Set-Location polyglot
    git pull
    Set-Location $ScriptDir
    pwsh ../../polyglot/scripts/init.ps1
}

. ../../polyglot/scripts/core.ps1

EnsureSymbolicLink -Path "../deps/polyglot" -Target "../../polyglot"
EnsureSymbolicLink -Path "../deps/spiral" -Target "../../spiral"

{ pwsh ../deps/polyglot/apps/parser/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/polyglot/deps/spiral/apps/spiral/build.ps1 -fast 1 } | Invoke-Block
{ pwsh ../deps/spiral/scripts/dir-tree-html.ps1 } | Invoke-Block

{ sudo apt-get update } | Invoke-Block -Linux -Distro ubuntu -OnError Continue
{ apt-get update } | Invoke-Block -Linux -Distro ubuntu -OnError Continue
{ sudo apt install -y pandoc fonts-nanum-coding } | Invoke-Block -Linux -Distro ubuntu -OnError Continue
{ apt install -y pandoc fonts-nanum-coding } | Invoke-Block -Linux -Distro ubuntu -OnError Continue

{ cargo binstall -y --git https://github.com/crowdagger/crowbook.git --locked crowbook } | Invoke-Block -OnError Continue
{ cargo binstall -y tectonic } | Invoke-Block -OnError Continue

if ($IsWindows) {
    $machineFontsDir = Join-Path $env:WINDIR "Fonts"
    $userFontsDir = Join-Path $env:LOCALAPPDATA "Microsoft/Windows/Fonts"
    $installedFont = @($machineFontsDir, $userFontsDir) | Where-Object { Test-Path (Join-Path $_ "NanumGothicCoding.ttf") }
    if (!$installedFont) {
        $nanumDir = New-Item -ItemType Directory -Path (Join-Path ([IO.Path]::GetTempPath()) "nanum-gothic-coding") -Force
        $nanumZip = Join-Path $nanumDir "NanumGothicCoding-2.5.zip"
        $nanumZipSha256 = "F4C9B1082CB36D793CCF75A331316C880EF9E4BC229408C22F9D2703B7619A3F"
        Invoke-WebRequest "https://github.com/naver/nanumfont/releases/download/VER2.5/NanumGothicCoding-2.5.zip" -OutFile $nanumZip
        $downloadedSha256 = (Get-FileHash $nanumZip -Algorithm SHA256).Hash
        if ($downloadedSha256 -ne $nanumZipSha256) { throw "init.ps1 / NanumGothicCoding-2.5.zip sha256 $downloadedSha256, expected $nanumZipSha256" }
        Expand-Archive $nanumZip -DestinationPath $nanumDir -Force
        New-Item -ItemType Directory -Path $userFontsDir -Force | Out-Null
        $userFontsKey = "HKCU:\Software\Microsoft\Windows NT\CurrentVersion\Fonts"
        if (!(Test-Path $userFontsKey)) { New-Item $userFontsKey -Force | Out-Null }
        foreach ($font in Get-ChildItem $nanumDir -Filter "NanumGothicCoding*.ttf") {
            $installedPath = Join-Path $userFontsDir $font.Name
            Copy-Item $font.FullName $installedPath -Force
            New-ItemProperty $userFontsKey -Name "$($font.BaseName) (TrueType)" -Value $installedPath -Force | Out-Null
        }
        Write-Output "init.ps1 / installed NanumGothicCoding for the current user into $userFontsDir"
    }
}

{ pwsh ./dep_hangulize.ps1 } | Invoke-Block
