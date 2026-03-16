```csharp
using var client = new LumaClient();

PingResponse response = await client.Ping.PingAsync();
```