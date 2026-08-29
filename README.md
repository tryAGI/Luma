# Luma

[![Nuget package](https://img.shields.io/nuget/vpre/Luma)](https://www.nuget.org/packages/Luma/)
[![dotnet](https://github.com/tryAGI/Luma/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Luma/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Luma)](https://github.com/tryAGI/Luma/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Luma OpenAPI specification](https://raw.githubusercontent.com/lumalabs/lumaai-api/refs/heads/main/openapi.yaml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- DreamMachine API support

### Usage
```csharp
using Luma;

using var api = new LumaClient(apiKey);

// generate image
Generation generation = await client.Generations.GenerateImageAsync(
    prompt: "The beautiful woman just smiles",
    aspectRatio: AspectRatio.x4_3,
    cancellationToken: cancellationToken);

// or generate video
Generation generation = await client.Generations.CreateGenerationAsync(
    prompt: "No camera movement. The beautiful woman just stands there and smiles. The waves in the background move a little.",
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

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Luma/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Luma/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
