# Docker
The goal is to have you copy your code from `Program.cs` into a Docker container that has the same enviroment that the autograder has.

## install docker

* [Install Docker](https://docs.docker.com/get-docker/)
* [Docker .NET images](https://hub.docker.com/_/microsoft-dotnet-sdk/)


<img src="https://user-images.githubusercontent.com/7727291/130502978-717457e3-1792-4a46-afa8-1569136930d1.png" alt="drawing" width="400"/>

```Bash
docker pull mcr.microsoft.com/dotnet/sdk:3.1
```

```Bash
docker-compose build
docker-compose run myprojectcode
```

