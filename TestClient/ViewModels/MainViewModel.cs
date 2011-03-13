using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;

using TestClient.Model;

namespace TestClient.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IDataProvider provider)
        {
            Tags = new ObservableCollection<TagInfo>(provider.Tags);
        }

        public ObservableCollection<TagInfo> Tags
        {
            get;
            private set;
        }
    }
}