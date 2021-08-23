# Project Setup

## Technology Requirements (.NET Core 3.1)
* Quick start guides will use .NET Core 3.1 to develop locally. If you are using a different version of .NET, see the note at the end about how to submit your project.

## Quick start guides

* [Windows](./projectGuides/Windows)
* [Mac OS](./projectGuides/Mac)
* [Docker](./projectGuides/Docker)

## Submitting Your Project

* Make sure your code is located in the folder that is named correctly for that project (example: P2 for project 2) and don't have extra nested folders. 
    * ![image](https://user-images.githubusercontent.com/7727291/130523217-0b382a36-8f7b-4a3a-a9a9-c3efd5b331f9.png)
* Zip the project folder and submit it to be graded
    * ![image](https://user-images.githubusercontent.com/7727291/130523286-e4b7eb8e-8724-471e-a1d3-864f529ab287.png)
    * ![image](https://user-images.githubusercontent.com/7727291/130523537-e5a5f7da-283c-445e-8a97-cab327a1d54e.png)
* Now you can submit this `.zip` file to be graded
 
> When the autograder unzip's the zipped project folder, it should see the `Program.cs` file and the `.csproj` file. (The bin and obj folders will be there as well)



## Non .NET Core 3.1 development
You can build the projects using a version newer that 3.1 (or using .NET 5 and up which replaces both .NET core and .NET framework). The only thing you should have to do is change the target platform in the `*.csproj` when you submit the project. The `<TargetFramework>` tags should look like the following:
```
<TargetFramework>netcoreapp3.1</TargetFramework>
```

> NOTE: If you change the target framework it will not run locally (unless you do some extra setup). So after you submit the project you should switch it back to what it was before to continue testing your code locally. And again, this only applies if you are not developing locally with .NET Core 3.1
