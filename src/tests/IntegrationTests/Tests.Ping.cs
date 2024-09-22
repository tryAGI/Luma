namespace Luma.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Ping()
    {
        using var api = new LumaClient();

        PingResponse response = await api.Ping.PingAsync();
        response.Message.Should().Be("pong");
    }
}
