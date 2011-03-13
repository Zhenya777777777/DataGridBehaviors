namespace TestClient
{
    internal sealed class CloseViewMessage
    {
        public string ViewName { get; private set; }
        public bool DialogResult { get; private set; }

        public CloseViewMessage(string viewName, bool result)
        {
            ViewName = viewName;
            DialogResult = result;
        }
    }
}
