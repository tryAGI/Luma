
#nullable enable

namespace Luma
{
    /// <summary>
    /// Generate videos using Dream Machine.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ILumaClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public PingClient Ping { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationsClient Generations { get; }

    }
}