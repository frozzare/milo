using System.Collections.Generic;

namespace Milo.Spring.Interfaces.Adapters
{
    public interface IRaven : ILinq
    {
        IEnumerable<T> Query<T>(string indexName, bool isMapReduce = false);
    }
}
