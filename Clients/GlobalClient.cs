
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.Global;
using CoinGecko.Interfaces;
using CoinGecko.Services;
using Newtonsoft.Json;

namespace cripto.Clients;

   public class GlobalClient:BaseApiClient,IGlobalClient
    {
        public GlobalClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }
        
        public async Task<Global> GetGlobal()
        {
            return await GetAsync<Global>(QueryStringService.AppendQueryString(GlobalApiEndPoints.Global)).ConfigureAwait(false);
        }

        public async Task<GlobalDeFi> GetGlobalDeFi()
        {
            return await GetAsync<GlobalDeFi>(QueryStringService.AppendQueryString(GlobalApiEndPoints.DecentralizedFinanceDeFi)).ConfigureAwait(false);
        }
    }