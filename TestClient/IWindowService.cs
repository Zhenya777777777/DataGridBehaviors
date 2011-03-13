using System.Windows;

namespace TestClient
{
    internal interface IWindowService
    {
        void Show(string title, FrameworkElement content);

        bool? ShowDialog(string title, FrameworkElement content);
    }
}