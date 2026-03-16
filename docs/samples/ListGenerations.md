```csharp
using var client = new LumaClient(apiKey);

ListGenerationResponse generations = await client.Generations.ListGenerationsAsync();

foreach (var generation in generations.Generations)
{
    Console.WriteLine($"Id: {generation.Id}");
    Console.WriteLine($"FailureReason: {generation.FailureReason}");
    Console.WriteLine($"Video URL: {generation.Assets?.Video}");
    Console.WriteLine($"State: {generation.State}");
}
```