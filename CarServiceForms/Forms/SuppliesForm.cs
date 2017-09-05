using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceForms.Forms
{
    public partial class SuppliesForm : Form
    {
        private static KeyPressEventHandler NumericCheckHandler = new KeyPressEventHandler(NumericCheck);

        private CarServiceFormsDBContext DBContext { get; set; }

        private IList<Supplies> Supplies { get; set; }
        private BindingList<Supplies> SuppliesBindingList { get; set; }
        private List<long> DeletedSupplies { get; set; }

        public SuppliesForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DBContext = new CarServiceFormsDBContext();

            suppliesDataGridView.AutoGenerateColumns = false;

            Supplies = DBContext.Supplies.ToList();
            SuppliesBindingList = new BindingList<Supplies>(Supplies);
            suppliesDataGridView.DataSource = SuppliesBindingList;

            DeletedSupplies = new List<long>();
        }

        private void SuppliesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var supplies = e.Row.DataBoundItem as Supplies;
            if (supplies.Id > 0)
            {
                DeletedSupplies.Add(supplies.Id);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            suppliesDataGridView.CancelEdit();

            foreach (var supplies in Supplies)
            {
                if (supplies.Id <= 0)
                {
                    supplies.Updated = DateTime.Now;
                    DBContext.Supplies.Add(supplies);
                }
                else
                {
                    var originalSupplies = DBContext.Supplies.Find(supplies.Id);
                    if (originalSupplies != null)
                    {
                        var dbContextAdapter = (IObjectContextAdapter) DBContext;
                        var objectStateEntry = dbContextAdapter.ObjectContext.ObjectStateManager.GetObjectStateEntry(supplies);
                        if (objectStateEntry.GetModifiedProperties().Any())
                        {
                            supplies.Updated = DateTime.Now;
                        }

                        DBContext.Entry(originalSupplies).CurrentValues.SetValues(supplies);
                    }
                }
            }

            foreach (var suppliesId in DeletedSupplies)
            {
                var supplies = DBContext.Supplies.Find(suppliesId);
                if (supplies != null)
                {
                    DBContext.Supplies.Remove(supplies);
                }
            }
            DeletedSupplies.Clear();

            DBContext.SaveChanges();
        }

        private void suppliesDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                var textBoxControl = (TextBox)e.Control;
                textBoxControl.CharacterCasing = CharacterCasing.Upper;
            }

            var columnName = suppliesDataGridView.CurrentCell.OwningColumn.Name;
            if (columnName == "QuantityColumn")
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
            else
            {
                e.Control.KeyPress -= NumericCheckHandler;
            }
        }

        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl control = sender as DataGridViewTextBoxEditingControl;
            if (control != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = control.Text.Contains(e.KeyChar);
            }
            else
            {
                e.Handled = !Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar);
            }
        }

        private void SuppliesDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["QuantityColumn"].Value = 0m;
        }

        private void SuppliesDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.FormattedValue.ToString() == "")
            {
                e.Cancel = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            suppliesDataGridView.CancelEdit();
        }
    }
}
