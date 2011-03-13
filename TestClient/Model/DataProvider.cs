using System.Collections.Generic;

namespace TestClient.Model
{
    internal sealed class DataProvider : IDataProvider
    {
        public IEnumerable<TagInfo> Tags
        {
            get
            {
                return new List<TagInfo>
                {
                    new TagInfo { Name = "c#", Score = 108307 },
                    new TagInfo { Name = "java", Score = 67068 },
                    new TagInfo { Name = "php", Score = 58740 },
                    new TagInfo { Name = ".net", Score = 52211 },
                    new TagInfo { Name = "javascript", Score = 50627 },
                    new TagInfo { Name = "asp.net", Score = 48200 },
                    new TagInfo { Name = "jquery", Score = 41986 },
                    new TagInfo { Name = "c++", Score = 41361 },
                    new TagInfo { Name = "iphone", Score = 39558 },
                    new TagInfo { Name = "python", Score = 34136 }
                };
            }
        }
    }
}
