using System.Collections.ObjectModel;
using System.Linq;

using GalaSoft.MvvmLight;

using TestClient.Model;

namespace TestClient.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IDataProvider provider)
        {
            Tags = new ObservableCollection<TagInfo>(provider.Tags);
            AllTags = new ObservableCollection<string>(Tags.Select(t => t.Name));
        }

        public ObservableCollection<TagInfo> Tags
        {
            get;
            private set;
        }

        public ObservableCollection<string> AllTags
        {
            get;
            private set;
        }
    }
}