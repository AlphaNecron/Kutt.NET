<div align='center'>
    
[![Logo](https://user-images.githubusercontent.com/57827456/122667487-4923e980-d1dd-11eb-9c78-c9b25ab43149.png)](#)

# Kutt.NET

An API wrapper for [Kutt.it](https://kutt.it), written in C#.

[![GitHub](https://img.shields.io/github/downloads/AlphaNecron/Kutt.NET/total?color=%237BA1F7&logo=github&style=for-the-badge)](https://github.com/AlphaNecron/Kutt.NET/releases/latest)
[![NuGet](https://img.shields.io/nuget/dt/Kutt.NET?color=%237BA1F7&logo=nuget&style=for-the-badge)](https://www.nuget.org/packages/Kutt.NET)
[![Latest](https://img.shields.io/github/v/tag/AlphaNecron/Kutt.NET?color=%237BA1F7&label=RELEASE&logo=github&sort=semver&style=for-the-badge)](https://github.com/AlphaNecron/Kutt.NET/releases/latest)
[![Workflow status](https://img.shields.io/github/workflow/status/AlphaNecron/Kutt.NET/Publish%20NuGet%20package?color=7BA1F7&logo=github&style=for-the-badge)](https://github.com/AlphaNecron/Kutt.NET)
[![MIT](https://img.shields.io/github/license/AlphaNecron/Kutt.NET?color=%237BA1F7&style=for-the-badge)](#)
</div>
## Author

- [@AlphaNecron](https://www.github.com/AlphaNecron)

  
## Usage/Examples

```csharp
// Initializes a Kutt instance with default server
KuttApi kutt = new KuttApi("your_api_key");

// Initializes a Kutt instance with your own server
KuttApi kutt = new KuttApi("your_api_key", "https://example.com");

// Creates a shortened URL
Link link = await CreateLinkAsync("https://github.com");
Console.WriteLine($"Shortened URL: {link.ShortUrl}");

// With fluent interface
Link link = await new LinkCreationRequest("your_api_key", "github.com")
                      .WithExpiration("2m") // 2 minutes
                      .WithCustomSlug("gh") // https://kutt.it/gh
                      .WithPassword("github")
                      .SubmitAsync(); // Or you can use SubmitAsync("example.com") to submit with your own server.
```


## Building

To build this project run

```bash
  nuget restore
  MSBuild.exe -property:Configuration=Release Kutt.NET.csproj
```

  
## Features

- Lightweight
- Create or delete your domains
- Create, delete or update your URLs
- Get user info using API key
- Usable in both .NET Core and .NET Framework
  
## Used By

This project is used by the following applications:
- [GKutt](https://github.com/AlphaNecron/GKutt)
