using CarServiceForms.Core.Collections;
using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceForms.Forms
{
    public partial class SearchCustomerForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }
        public long? ReturnValue { get; set; }

        public SearchCustomerForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DBContext = new CarServiceFormsDBContext();
            customersDataGridView.AutoGenerateColumns = false;
        }

        private void CleanupComponents()
        {
            DBContext.Dispose();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ReturnValue = null;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (customersDataGridView.SelectedRows.Count > 0)
            {
                var selectedCustomer = customersDataGridView.SelectedRows[0].DataBoundItem as Customer;
                if (selectedCustomer != null)
                {
                    ReturnValue = selectedCustomer.Id;
                }
            }
        }

        private void CustomerFirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                SearchCustomer();
                e.Handled = true;
            }
        }

        private void CustomerLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                SearchCustomer();
                e.Handled = true;
            }
        }

        private void SearchCustomer()
        {
            var customerFirstName = customerFirstNameTextBox.Text;
            var customerLastName = customerLastNameTextBox.Text;

            var customers = DBContext
                .Customer
                .Where(c =>
                    c.Active &&
                    (
                        !string.IsNullOrEmpty(customerFirstName) && c.FirstName.Contains(customerFirstName) ||
                        !string.IsNullOrEmpty(customerLastName) && c.LastName.Contains(customerLastName) ||
                        (string.IsNullOrEmpty(customerFirstName) && string.IsNullOrEmpty(customerLastName))
                    )
                )
                .ToList();

            customersDataGridView.DataSource = new SortableBindingList<Customer>(customers);
        }

        private void SearchCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void CustomersDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var customer = customersDataGridView.Rows[e.RowIndex].DataBoundItem as Customer;
            if (customer != null)
            {
                ReturnValue = customer.Id;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
