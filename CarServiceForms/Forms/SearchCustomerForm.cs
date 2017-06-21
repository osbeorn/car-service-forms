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
        private CarServiceFormsDBContext DbContext { get; set; }
        public long? ReturnValue { get; set; }

        public SearchCustomerForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DbContext = new CarServiceFormsDBContext();
            customersDataGridView.AutoGenerateColumns = false;
        }

        private void CleanupComponents()
        {
            DbContext.Dispose();
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

            var customers = DbContext
                .Customer
                .Where(c =>
                    !string.IsNullOrEmpty(customerFirstName) && c.FirstName.Contains(customerFirstName) ||
                    !string.IsNullOrEmpty(customerLastName) && c.LastName.Contains(customerLastName)
                )
                .ToList();

            customersDataGridView.DataSource = customers;
        }

        private void SearchCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }
    }
}
