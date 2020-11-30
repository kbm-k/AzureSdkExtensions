using System.Linq;
using Microsoft.Azure.Cosmos;

namespace AzureSdkExtensions.Cosmos
{
    public interface ICosmosLinqQuery
    {
        FeedIterator<T> GetFeedIterator<T>(IQueryable<T> query);
    }
}