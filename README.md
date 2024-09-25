# Luma

[![Nuget package](https://img.shields.io/nuget/vpre/Luma)](https://www.nuget.org/packages/Luma/)
[![dotnet](https://github.com/tryAGI/Luma/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Luma/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Luma)](https://github.com/tryAGI/Luma/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Luma OpenAPI specification](https://raw.githubusercontent.com/Luma/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- DreamMachine API support

### Usage
```csharp
using Luma;

using var api = new LumaClient(apiKey);

Generation generation = await client.Generations.CreateGenerationAsync(
    prompt: "No camera movement. The girl just stands there and smiles. The waves in the background move a little.",
    aspectRatio: AspectRatio.x4_3,
    loop: false,
    keyframes: new Keyframes
    {
        Frame0 = new ImageReference
        {
            Url = "https://i.ibb.co/WFJyPcR/cool-girl.png",
        },
        // Frame1 = new GenerationReference
        // {
        //     Id = Guid.Empty,
        // },
    });

while (generation.State != State.Failed && generation.State != State.Completed)
{
    await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
    
    generation = await client.Generations.GetGenerationAsync(
        id: generation.Id?.Value.ToString(),
        cancellationToken: cancellationToken);
}

Console.WriteLine($"Id: {generation.Id}");
Console.WriteLine($"State: {generation.State}");
Console.WriteLine($"FailureReason: {generation.FailureReason}");
Console.WriteLine($"Video URL: {generation.Assets?.Video}");
```

https://github.com/user-attachments/assets/239cf6fb-928e-427e-8cb1-7a4a3d71ccb6

## Support

Priority place for bugs: https://github.com/tryAGI/Luma/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Luma/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
