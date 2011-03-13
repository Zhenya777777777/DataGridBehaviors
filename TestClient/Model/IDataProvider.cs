using System.Collections.Generic;

namespace TestClient.Model
{
    public interface IDataProvider
    {
        IEnumerable<TagInfo> Tags { get; }
    }
}
