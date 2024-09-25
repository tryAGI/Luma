namespace Luma.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Ping()
    {
        using var client = new LumaClient();

        PingResponse response = await client.Ping.PingAsync();
        response.Message.Should().Be("pong");
    }
}
