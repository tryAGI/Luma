```csharp
using var client = new LumaClient(apiKey);
using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(5));
var cancellationToken = cancellationTokenSource.Token;

Generation generation = await client.Generations.CreateGenerationAsync(
    model: VideoModel.Ray2,
    prompt: "The beautiful woman just smiles",
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
    },
    cancellationToken: cancellationToken);

if (generation.Id == null)
{
    throw new InvalidOperationException("Generation Id is null.");
}

while (generation.State != State.Failed && generation.State != State.Completed)
{
    await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);

    generation = await client.Generations.GetGenerationAsync(
        id: generation.Id!.Value.ToString(),
        cancellationToken: cancellationToken);
}

Console.WriteLine($"Id: {generation.Id}");
Console.WriteLine($"FailureReason: {generation.FailureReason}");
Console.WriteLine($"Video URL: {generation.Assets?.Video}");
Console.WriteLine($"State: {generation.State}");
```