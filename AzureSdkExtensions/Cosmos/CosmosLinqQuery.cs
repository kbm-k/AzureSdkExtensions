using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using System.Linq;

namespace AzureSdkExtensions.Cosmos
{
    /// <summary>
    /// We need a wrapper around ToFeedIterator() extension method, because
    /// ToFeedIterator is only supported on cosmos LINQ query operations
    /// </summary>
    public class CosmosLinqQuery : ICosmosLinqQuery
    {
        public FeedIterator<T> GetFeedIterator<T>(IQueryable<T> query) => query.ToFeedIterator();
    }
}
