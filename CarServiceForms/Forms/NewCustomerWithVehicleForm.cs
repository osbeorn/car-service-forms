using CarServiceForms.Core.Helpers;
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
    public partial class NewCustomerWithVehicleForm : Form
    {
        private CarServiceFormsDBContext DbContext { get; set; }
        private long? SelectedCustomerId { get; set; }
        private Customer SelectedCustomer { get; set; }

        public Vehicle ReturnValue2 { get; set; }

        public NewCustomerWithVehicleForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            DbContext = new CarServiceFormsDBContext();
        }

        public void CleanupComponents()
        {
            DbContext.Dispose();
        }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            using (var form = new SearchCustomerForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SelectedCustomerId = form.ReturnValue;
                    SelectedCustomer = DbContext.Customer.Find(SelectedCustomerId);

                    customerFirstNameTextBox.Text = SelectedCustomer.FirstName;
                    customerFirstNameTextBox.ReadOnly = true;

                    customerLastNameTextBox.Text = SelectedCustomer.LastName;
                    customerLastNameTextBox.ReadOnly = true;

                    customerStreetTextBox.Text = SelectedCustomer.Street;
                    customerStreetTextBox.ReadOnly = true;

                    customerPostTextBox.Text = SelectedCustomer.Post;
                    customerPostTextBox.ReadOnly = true;

                    customerPhoneTextBox.Text = SelectedCustomer.Phone;
                    customerPhoneTextBox.ReadOnly = true;
                }
            }            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            customerFirstNameTextBox.Text = "";
            customerFirstNameTextBox.ReadOnly = false;

            customerLastNameTextBox.Text = "";
            customerLastNameTextBox.ReadOnly = false;

            customerStreetTextBox.Text = "";
            customerStreetTextBox.ReadOnly = false;

            customerPostTextBox.Text = "";
            customerPostTextBox.ReadOnly = false;

            customerPhoneTextBox.Text = "";
            customerPhoneTextBox.ReadOnly = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.HasValidationErrors(this.Controls))
            {
                return;
            }

            if (SelectedCustomer != null)
            {
                // existing customer
                var vehicle = new Vehicle
                {
                    RegistrationNumber = vehicleRegistrationNumberTextBox.Text,
                    RegistrationDate = vehicleRegistrationDateDateTimePicker.Value,
                    IdentificationNumber = vehicleIdentificationNumberTextBox.Text,
                    Type = vehicleTypeTextBox.Text,
                    TypeCode = vehicleTypeCodeTextBox.Text,
                    Engine = vehicleEngineTextBox.Text,
                    MKBCode = vehicleMKBTextBox.Text,
                    Transmission = vehicleTransmissionTextBox.Text,
                    GKBCode = vehicleGKBTextBox.Text,
                    Mileage = Convert.ToInt32(vehicleMileageNumericUpDown.Value)
                };

                SelectedCustomer.Vehicles.Add(vehicle);
                DbContext.SaveChanges();
            } else
            {
                // new customer
                var customer = new Customer
                {
                    FirstName = customerFirstNameTextBox.Text,
                    LastName = customerLastNameTextBox.Text,
                    Street = customerStreetTextBox.Text,
                    Post = customerPostTextBox.Text,
                    Phone = customerPhoneTextBox.Text,
                    Active = true
                };

                var vehicle = new Vehicle
                {
                    RegistrationNumber = vehicleRegistrationNumberTextBox.Text,
                    RegistrationDate = vehicleRegistrationDateDateTimePicker.Value,
                    IdentificationNumber = vehicleIdentificationNumberTextBox.Text,
                    Type = vehicleTypeTextBox.Text,
                    TypeCode = vehicleTypeCodeTextBox.Text,
                    Engine = vehicleEngineTextBox.Text,
                    MKBCode = vehicleMKBTextBox.Text,
                    Transmission = vehicleTransmissionTextBox.Text,
                    GKBCode = vehicleGKBTextBox.Text,
                    Mileage = Convert.ToInt32(vehicleMileageNumericUpDown.Value),
                    ModelYear = Convert.ToInt32(vehicleModelYearNumericUpDown.Value),
                    Active = true
                };

                customer.Vehicles.Add(vehicle);

                DbContext.Customer.Add(customer);
                DbContext.SaveChanges();
            }

            DialogResult = DialogResult.OK;

            Close();
            Dispose();
        }

        private void NewCustomerWithVehicleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void VehicleModelYearNumericUpDown_Enter(object sender, EventArgs e)
        {
            vehicleModelYearNumericUpDown.Select(0, vehicleModelYearNumericUpDown.Text.Length);
        }

        private void VehicleMileageNumericUpDown_Enter(object sender, EventArgs e)
        {
            vehicleMileageNumericUpDown.Select(0, vehicleMileageNumericUpDown.Text.Length);
        }

        private void CustomerFirstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (customerFirstNameTextBox.Text.Trim() == "")
            {
                errorProvider.SetError(customerFirstNameTextBox, "Ime je obvezen podatek.");
                e.Cancel = true;
                return;
            }

            errorProvider.SetError(customerFirstNameTextBox, "");
        }

        private void CustomerLastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (customerLastNameTextBox.Text.Trim() == "")
            {
                errorProvider.SetError(customerLastNameTextBox, "Priimek je obvezen podatek.");
                e.Cancel = true;
                return;
            }

            errorProvider.SetError(customerLastNameTextBox, "");
        }

        private void VehicleRegistrationNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (vehicleRegistrationNumberTextBox.Text.Trim() == "")
            {
                errorProvider.SetError(vehicleRegistrationNumberTextBox, "Registrska številka je obvezen podatek.");
                e.Cancel = true;
                return;
            }

            errorProvider.SetError(vehicleRegistrationNumberTextBox, "");
        }
    }
}
