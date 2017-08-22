using CarServiceForms.Model;
using System;
using System.Windows.Forms;

namespace CarServiceForms.Forms
{
    public partial class EditCustomerWithVehicleForm : Form
    {
        private CarServiceFormsDBContext DbContext { get; set; }

        private long SelectedCustomerId { get; set; }
        private long SelectedVehicleId { get; set; }

        private Customer SelectedCustomer { get; set; }
        private Vehicle SelectedVehicle { get; set; }

        public EditCustomerWithVehicleForm(long selectedCustomerId, long selectedVehicleId)
        {
            InitializeComponent();
            InitializeComponents(selectedCustomerId, selectedVehicleId);
        }

        public void InitializeComponents(long selectedCustomerId, long selectedVehicleId)
        {
            DbContext = new CarServiceFormsDBContext();

            SelectedCustomerId = selectedCustomerId;
            SelectedVehicleId = selectedVehicleId;

            SelectedCustomer = DbContext.Customer.Find(selectedCustomerId);
            SelectedVehicle = DbContext.Vehicle.Find(selectedVehicleId);

            SetupCustomerFields();
            SetupVehicleFields();
        }

        public void CleanupComponents()
        {
            DbContext.Dispose();
        }

        private void SetupCustomerFields()
        {
            customerFirstNameTextBox.Text = SelectedCustomer.FirstName;
            customerLastNameTextBox.Text = SelectedCustomer.LastName;
            customerStreetTextBox.Text = SelectedCustomer.Street;
            customerPostTextBox.Text = SelectedCustomer.Post;
            customerPhoneTextBox.Text = SelectedCustomer.Phone;

            SetDeActivateButtonText(deActivateCustomerButton, SelectedCustomer.Active);
        }

        private void SetupVehicleFields()
        {
            vehicleRegistrationNumberTextBox.Text = SelectedVehicle.RegistrationNumber;
            vehicleRegistrationDateDateTimePicker.Value = SelectedVehicle.RegistrationDate;
            vehicleIdentificationNumberTextBox.Text = SelectedVehicle.IdentificationNumber;
            vehicleTypeTextBox.Text = SelectedVehicle.Type;
            vehicleTypeCodeTextBox.Text = SelectedVehicle.TypeCode;
            vehicleEngineTextBox.Text = SelectedVehicle.Engine;
            vehicleMKBTextBox.Text = SelectedVehicle.MKBCode;
            vehicleTransmissionTextBox.Text = SelectedVehicle.Transmission;
            vehicleGKBTextBox.Text = SelectedVehicle.GKBCode;
            vehicleMileageNumericUpDown.Value = SelectedVehicle.Mileage;
            vehicleModelYearNumericUpDown.Value = SelectedVehicle.ModelYear;

            SetDeActivateButtonText(deActivateVehicleButton, SelectedVehicle.Active);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SelectedCustomer.FirstName = customerFirstNameTextBox.Text;
            SelectedCustomer.LastName = customerLastNameTextBox.Text;
            SelectedCustomer.Street = customerStreetTextBox.Text;
            SelectedCustomer.Post = customerPostTextBox.Text;
            SelectedCustomer.Phone = customerPhoneTextBox.Text;

            SelectedVehicle.RegistrationNumber = vehicleRegistrationNumberTextBox.Text;
            SelectedVehicle.RegistrationDate = vehicleRegistrationDateDateTimePicker.Value;
            SelectedVehicle.IdentificationNumber = vehicleIdentificationNumberTextBox.Text;
            SelectedVehicle.Type = vehicleTypeTextBox.Text;
            SelectedVehicle.TypeCode = vehicleTypeCodeTextBox.Text;
            SelectedVehicle.Engine = vehicleEngineTextBox.Text;
            SelectedVehicle.MKBCode = vehicleMKBTextBox.Text;
            SelectedVehicle.Transmission = vehicleTransmissionTextBox.Text;
            SelectedVehicle.GKBCode = vehicleGKBTextBox.Text;
            SelectedVehicle.Mileage = Convert.ToInt32(vehicleMileageNumericUpDown.Value);
            SelectedVehicle.ModelYear = Convert.ToInt32(vehicleModelYearNumericUpDown.Value);

            DbContext.SaveChanges();

            Close();
            Dispose();
        }

        private void EditCustomerWithVehicleForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DeActivateButton_Click(object sender, EventArgs e)
        {
            SelectedCustomer.Active = !SelectedCustomer.Active;
            SetDeActivateButtonText(deActivateCustomerButton, SelectedCustomer.Active);
        }

        private void DeActivateVehicleButton_Click(object sender, EventArgs e)
        {
            SelectedVehicle.Active = !SelectedVehicle.Active;
            SetDeActivateButtonText(deActivateVehicleButton, SelectedVehicle.Active);
        }

        private void SetDeActivateButtonText(Control button, bool state)
        {
            if (state)
            {
                button.Text = "Deaktiviraj";
            }
            else
            {
                button.Text = "Aktiviraj";
            }
        }
    }
}
