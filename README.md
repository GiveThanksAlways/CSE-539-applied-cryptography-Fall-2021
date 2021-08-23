# Project Setup

## Technology Requirements (.NET Core 3.1)
* Quick start is to use .NET Core 3.1 to develop locally. If you are using a different version of .NET, see the note at the end about how to submit your project.

### Local install Windows

* [Docker guide](./projectGuides/Docker)
* [Windows guide](./projectGuides/Windows)
* [Mac OS guide](./projectGuides/Mac)


* [Windows .NET Core 3.1](https://dotnet.microsoft.com/download) 

<img src="https://user-images.githubusercontent.com/7727291/130494791-25637e52-c88d-44f3-8214-a3ae5ae1be59.png" alt="drawing" width="300"/>
<img src="https://user-images.githubusercontent.com/7727291/130494842-fbbd7604-3174-40c6-a4ef-5c766621e6a6.png" alt="drawing" width="300"/>
<img src="https://user-images.githubusercontent.com/7727291/130496715-781cb953-5aef-493b-bf97-5f8caafca887.png" alt="drawing" width="300"/>
<img src="https://user-images.githubusercontent.com/7727291/130497019-893a6f23-2210-407e-9e17-deeda1dbd3e1.png" alt="drawing" width="300"/>

```bash
mkdir mcs-539-projects
cd mcs-539-projects
dotnet new console --output P2
cd P2
dotnet run
```
<img src="https://user-images.githubusercontent.com/7727291/130497491-4d951d9c-b22e-436e-b170-ab6b71342492.png" alt="drawing" width="700"/>

### IDE 

#### Visual Studio Code

[vscode download](https://code.visualstudio.com/download)

* Launch from the commandline
    * <img src="https://user-images.githubusercontent.com/7727291/130498777-b32e9368-c5cb-4279-847d-a7a1bcc6c56a.png" alt="drawing" width="300"/>
* Launch from file explorer 
    * <img src="https://user-images.githubusercontent.com/7727291/130501130-e6dae28a-0700-4b6c-8b6d-2e28721ac62f.png" alt="drawing" width="300"/>
* Open folder within vscode
    * <img src="https://user-images.githubusercontent.com/7727291/130501480-29569f41-1e09-4620-a7a5-b37436525cff.png" alt="drawing" width="300"/>


<img src="https://user-images.githubusercontent.com/7727291/130499051-0fe6df63-44e1-4616-9768-8ac4165c33dd.png" alt="drawing" width="800"/>

###
#### Non .NET Core 3.1 development
You can build the projects using a version newer that 3.1 (or using .NET 5 and up which replaces both .NET core and .NET framework). The only thing you need to do is change the target platform in the `*.csproj` when you submit the project. The `<TargetFramework>` tags should look like the following:
```
<TargetFramework>netcoreapp3.1</TargetFramework>
```

> NOTE: If you change the target framework it will not run locally (unless you do some extra setup). So after you submit the project you should switch it back to what it was before to continue testing your code locally. And again, this only applies if you are not developing locally with .NET Core 3.1
