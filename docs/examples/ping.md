# Ping



This example assumes `using Luma;` is in scope and `apiKey` contains your Luma API key.

```csharp
using var client = new LumaClient();

PingResponse response = await client.Ping.PingAsync();
```