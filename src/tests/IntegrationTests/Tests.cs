namespace Luma.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public LumaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LUMA_API_KEY") ??
            throw new AssertInconclusiveException("LUMA_API_KEY environment variable is not found.");

        var client = new LumaClient(apiKey);
        
        return client;
    }
}
