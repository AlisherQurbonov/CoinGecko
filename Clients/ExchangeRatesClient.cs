
using CoinGecko.ApiEndPoints;
using CoinGecko.Entities.Response.ExchangeRates;
using CoinGecko.Interfaces;
using CoinGecko.Services;
using Newtonsoft.Json;

namespace cripto.Clients;

 public class ExchangeRatesClient:BaseApiClient,IExchangeRatesClient
    {
        public ExchangeRatesClient(HttpClient httpClient, JsonSerializerSettings serializerSettings) : base(httpClient, serializerSettings)
        {
        }

        public async Task<ExchangeRates> GetExchangeRates()
        {
            return await GetAsync<ExchangeRates>(
                QueryStringService.AppendQueryString(ExchangeRatesApiEndPoints.ExchangeRate)).ConfigureAwait(false);
        }
    }