

using CoinGecko.Entities.Response.Indexes;

namespace cripto.Interfaces
{
    public interface IIndexesClient
    {
        Task<IReadOnlyList<IndexData>> GetIndexes();
        Task<IReadOnlyList<IndexData>> GetIndexes(int? perPage, string page);
        //Task<IndexData> GetIndexById(string id);
        Task<IReadOnlyList<IndexList>> GetIndexList();
    }
}