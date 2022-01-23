

using CoinGecko.Entities.Response;

namespace cripto.Interfaces
{
    public interface IPingClient
    {
           /// <summary>
        /// Check API server status
        /// </summary>
        /// <returns></returns>
        Task<Ping> GetPingAsync();
    }
}