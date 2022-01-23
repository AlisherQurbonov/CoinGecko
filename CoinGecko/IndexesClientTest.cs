
using CoinGecko.Clients;
using CoinGecko.Interfaces;
using Xunit;

namespace cripto.CoinGecko;

 public class IndexesClientTest
    {
        private readonly ICoinGeckoClient _client;
        public IndexesClientTest()
        {
            _client = CoinGeckoClient.Instance;
        }

        [Fact]
        public async Task Indexes_Count_Not_Equal_Zero()
        {
            var result = await _client.IndexesClient.GetIndexes();
            Assert.True(result.Count > 0, "Result GTE 0");
        }

        [Fact]
        public async Task Indexes_List_Count_Not_Equal_Zero()
        {
            var result = await _client.IndexesClient.GetIndexList();
            Assert.True( result.Count > 0,"Result GTE 0");
        }
    }