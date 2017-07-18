using CarServiceForms.Classes;
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
    public partial class SearchCustomerWithVehicleForm : Form
    {
        private CarServiceFormsDBContext DbContext { get; set; }

        public long? ReturnValue1 { get; set; }
        public long? ReturnValue2 { get; set; }

        public SearchCustomerWithVehicleForm()
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
            SearchCustomersWithVehicles();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            using (var form = new NewCustomerWithVehicleForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SearchCustomersWithVehicles();
                }
            }
        }

        private void SearchCustomersWithVehicles()
        {
            var customerFirstName = customerFirstNameTextBox.Text;
            var customerLastName = customerLastNameTextBox.Text;
            var vehicleIdentificationNumber = vehicleIdentificationNumberTextBox.Text;
            var vehicleRegistrationNumber = vehicleRegistrationNumberTextBox.Text;

            var customerDTOs = DbContext
                .Vehicle
                .Where(v =>
                    !string.IsNullOrEmpty(customerFirstName) && v.Customer.FirstName.Contains(customerFirstName) ||
                    !string.IsNullOrEmpty(customerLastName) && v.Customer.LastName.Contains(customerLastName) ||
                    !string.IsNullOrEmpty(vehicleIdentificationNumber) && v.IdentificationNumber.Contains(vehicleIdentificationNumber) ||
                    !string.IsNullOrEmpty(vehicleRegistrationNumber) && v.RegistrationNumber.Contains(vehicleRegistrationNumber) ||
                    (string.IsNullOrEmpty(customerFirstName) && string.IsNullOrEmpty(customerLastName) && string.IsNullOrEmpty(vehicleIdentificationNumber) && string.IsNullOrEmpty(vehicleRegistrationNumber))
                )
                .Select(v => new CustomerWithVehicleDTO
                {
                    CustomerId = v.Customer.Id,
                    FirstName = v.Customer.FirstName,
                    LastName = v.Customer.LastName,
                    Street = v.Customer.Street,
                    Post = v.Customer.Post,

                    VehicleId = v.Id,
                    IdentificationNumber = v.IdentificationNumber,
                    RegistrationNumber = v.RegistrationNumber,
                    RegistrationDate = v.RegistrationDate,
                    Type = v.Type,
                    TypeCode = v.TypeCode,
                    GKBCode = v.GKBCode,
                    MKBCode = v.MKBCode,
                    Mileage = v.Mileage,
                    ModelYear = v.ModelYear,
                    Engine = v.Engine,
                    Transmission = v.Transmission
                })
                .ToList();

            customersDataGridView.DataSource = new SortableBindingList<CustomerWithVehicleDTO>(customerDTOs);
        }

        private void SearchCustomerWithVehicleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (customersDataGridView.SelectedRows.Count > 0)
            {
                var selectedCustomer = customersDataGridView.SelectedRows[0].DataBoundItem as CustomerWithVehicleDTO;
                if (selectedCustomer != null)
                {
                    ReturnValue1 = selectedCustomer.CustomerId;
                    ReturnValue2 = selectedCustomer.VehicleId;
                }
            }
        }

        private void CustomerFirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchCustomersWithVehicles();
                e.Handled = true;
            }
        }

        private void CustomerLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchCustomersWithVehicles();
                e.Handled = true;
            }
        }

        private void VehicleIdentificationNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchCustomersWithVehicles();
                e.Handled = true;
            }
        }

        private void vehicleRegistrationNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchCustomersWithVehicles();
                e.Handled = true;
            }
        }
    }
}
