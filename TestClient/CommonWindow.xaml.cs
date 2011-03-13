using GalaSoft.MvvmLight.Messaging;

namespace TestClient
{
    public partial class CommonWindow
    {
        private readonly IMessenger _messenger;

        public CommonWindow(IMessenger messenger)
        {
            _messenger = messenger;
            _messenger.Register<CloseViewMessage>(this, Close);

            InitializeComponent();
        }

        internal void Close(CloseViewMessage message)
        {
            if (message.ViewName != Content.GetType().Name)
                return;
            
            _messenger.Unregister<CloseViewMessage>(this);

            DialogResult = message.DialogResult;
            Close();
        }
    }
}
