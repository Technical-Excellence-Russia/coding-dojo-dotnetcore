# Template .Net Core project for Coding Dojo

## Install .NET Core (on Ubuntu 20.10)

```sh
wget https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
```
See [https://docs.microsoft.com/ru-ru/dotnet/core/install/linux-ubuntu](https://docs.microsoft.com/ru-ru/dotnet/core/install/linux-ubuntu) for actual information.

### Run tests

```sh
dotnet build && dotnet test
```
