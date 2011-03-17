using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace CustomDataGridBehaviors
{
    public sealed class PushDataContextToColumnsBehavior : Behavior<DataGrid>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.DataContextChanged += DataGrid_DataContextChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.DataContextChanged -= DataGrid_DataContextChanged;
        }

        private void DataGrid_DataContextChanged(
            object sender, DependencyPropertyChangedEventArgs e)
        {
            foreach (var column in AssociatedObject.Columns)
            {
                column.SetValue(
                    FrameworkElement.DataContextProperty,
                    e.NewValue);
            }
        }
    }
}
