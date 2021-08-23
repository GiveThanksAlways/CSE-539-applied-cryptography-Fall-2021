# Project Setup

## Technology Requirements (.NET Core 3.1)
* Quick start will use .NET Core 3.1 to develop locally. If you are using a different version of .NET, see the note at the end about how to submit your project.

## Quick start guides

* [Windows](./projectGuides/Windows)
* [Mac OS](./projectGuides/Mac)
* [Docker](./projectGuides/Docker)


## Non .NET Core 3.1 development
You can build the projects using a version newer that 3.1 (or using .NET 5 and up which replaces both .NET core and .NET framework). The only thing you need to do is change the target platform in the `*.csproj` when you submit the project. The `<TargetFramework>` tags should look like the following:
```
<TargetFramework>netcoreapp3.1</TargetFramework>
```

> NOTE: If you change the target framework it will not run locally (unless you do some extra setup). So after you submit the project you should switch it back to what it was before to continue testing your code locally. And again, this only applies if you are not developing locally with .NET Core 3.1
