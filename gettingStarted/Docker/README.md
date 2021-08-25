# Docker
The goal is to have you copy your code from `Program.cs` into a Docker container that has the same enviroment that the autograder has.

## install docker

* [Install Docker](https://docs.docker.com/get-docker/)
* [Docker .NET images](https://hub.docker.com/_/microsoft-dotnet-sdk/)


<img src="https://user-images.githubusercontent.com/7727291/130502978-717457e3-1792-4a46-afa8-1569136930d1.png" alt="drawing" width="400"/>


* This docker image matches what the autograder will use to grade each project
* bionic is Ubuntu 18.04 and this image of Ubuntu 18.04 has the .NET Core 3.1 SDK (Software Development Kit)
```Bash
docker pull mcr.microsoft.com/dotnet/sdk:3.1-bionic
```

## Using Docker
If you copy all of the files in this folder (Docker folder) then the only step you should have to do (fingers crossed. I will update if there are issues) is copy your code from `Program.cs` to the `Program.cs` file in this folder and then run the following two commands.

```Bash
docker-compose build
docker-compose run myprojectcode
```

