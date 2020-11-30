using System.Collections.Generic;
using Microsoft.Azure.Cosmos;

namespace AzureSdkExtensions.Cosmos
{
    public static class FeedIteratorExtensions
    {
        public static async IAsyncEnumerable<T> ToAsyncEnumerable<T>(this FeedIterator<T> iterator)
        {
            while (iterator.HasMoreResults)
            {
                foreach (var item in await iterator.ReadNextAsync())
                {
                    yield return item;
                }
            }
        }
    }
}
