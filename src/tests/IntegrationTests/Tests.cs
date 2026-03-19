namespace Luma.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LumaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LUMA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LUMA_API_KEY environment variable is not found.");

        var client = new LumaClient(apiKey);
        
        return client;
    }
}
