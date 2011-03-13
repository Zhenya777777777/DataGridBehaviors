using System;
using System.Windows;

using GalaSoft.MvvmLight.Messaging;

namespace TestClient
{
    internal sealed class WindowService : IWindowService
    {
        private readonly IMessenger _messenger;

        public WindowService(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void Show(string title, FrameworkElement content)
        {
            var window = new Window
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Title = title,
                Content = content,
                SizeToContent = SizeToContent.WidthAndHeight
            };

            if (window == Application.Current.MainWindow)
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            else
                window.Owner = Application.Current.MainWindow;

            window.Show();
        }

        public bool? ShowDialog(string title, FrameworkElement content)
        {
            if (Application.Current.MainWindow == null)
                throw new Exception("WTF!?");

            var window = new CommonWindow(_messenger)
            {
                Owner = Application.Current.MainWindow,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                ShowInTaskbar = false,
                WindowStyle = WindowStyle.ToolWindow,
                Title = title,
                Content = content,
                SizeToContent = SizeToContent.WidthAndHeight
            };

            return window.ShowDialog();
        }
    }
}
