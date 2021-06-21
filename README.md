
[![Logo](https://user-images.githubusercontent.com/57827456/122667487-4923e980-d1dd-11eb-9c78-c9b25ab43149.png)](#)

    
# Kutt.NET

An API wrapper for [Kutt](kutt.it), written in C#.

[![GitHub](https://img.shields.io/github/downloads/AlphaNecron/Kutt.NET/total?color=%237289DA&logo=github&style=for-the-badge)](#)
[![NuGet](https://img.shields.io/nuget/dt/Kutt.NET?color=%237289DA&logo=nuget&style=for-the-badge)](#)

## Authors

- [@AlphaNecron](https://www.github.com/AlphaNecron)

  
## Usage/Examples

```csharp
// Initializes a Kutt instance with default server
KuttApi kutt = new KuttApi("your_api_key");

// Creates a shortened URL
Link link = await CreateLinkAsync("https://github.com");
Console.WriteLine($"Shortened URL: {link.ShortUrl}");
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
