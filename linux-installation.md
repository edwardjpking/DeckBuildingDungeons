## Linux development environment setup

### Unity Hub
https://docs.unity3d.com/hub/manual/InstallHub.html#install-hub-linux

### Create a Unity account

### Unity Editor
Install from inside Unity Hub
2022.3.10f1

### C# Dev Kit extension
ms-dotnettools.csdevkit

### DotNet SDK
curl -sSL -O https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.debms-dotnettools.csdevkit
sudo dpkg --purge packages-microsoft-prod && sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update &&  sudo apt-get install -y dotnet-sdk-8.0
