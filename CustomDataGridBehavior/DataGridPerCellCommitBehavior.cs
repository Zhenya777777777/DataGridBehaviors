using System.Windows.Controls;
using System.Windows.Interactivity;

namespace CustomDataGridBehaviors
{
    public class DataGridPerCellCommitBehavior : Behavior<DataGrid>
    {
        private static bool _manualEditCommit;

        protected override void OnAttached()
        {
            base.OnAttached();

            AssociatedObject.CellEditEnding += Grid_CellEditEnding;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();

            AssociatedObject.CellEditEnding -= Grid_CellEditEnding;
        }

        private void Grid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (_manualEditCommit)
                return;

            if (e.EditAction != DataGridEditAction.Commit)
                return;

            _manualEditCommit = true;
            var grid = (DataGrid)sender;
            grid.CommitEdit(DataGridEditingUnit.Row, true);
            _manualEditCommit = false;
        }
    }
}
