FROM mcr.microsoft.com/vscode/devcontainers/rust:dev-1

USER root

RUN apt-get update && \
    export DEBIAN_FRONTEND=noninteractive && \
    wget -q https://packages.microsoft.com/config/ubuntu/$(. /etc/os-release && echo $VERSION_ID)/packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb && \
    rm packages-microsoft-prod.deb && \
    apt-get update && \
    apt-get install -y --no-install-recommends \
        powershell \
        && \
    rm -rf /var/lib/apt/lists/*

USER codespace
