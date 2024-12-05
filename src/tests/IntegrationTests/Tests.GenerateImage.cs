namespace Luma.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GenerateImageAsync()
    {
        using var client = GetAuthenticatedClient();
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(5));
        var cancellationToken = cancellationTokenSource.Token;

        Generation generation = await client.Generations.GenerateImageAsync(
            prompt: "The beautiful woman just smiles",
            aspectRatio: AspectRatio.x4_3,
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
        Console.WriteLine($"Image URL: {generation.Assets?.Image}");
        Console.WriteLine($"State: {generation.State}");
        
        generation.FailureReason.Should().BeNull();
        generation.Id.Should().NotBeEmpty();
        generation.Assets.Should().NotBeNull();
        generation.Assets!.Image.Should().NotBeNull();
        generation.State.Should().Be(State.Completed);
    }
}
