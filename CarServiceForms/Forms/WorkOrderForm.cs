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
    public partial class WorkOrderForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }

        private Customer Customer { get; set; }
        private Vehicle Vehicle { get; set; }
        private WorkOrder WorkOrder { get; set; }
        private IList<WorkOrderInstruction> WorkOrderInstructions { get; set; }

        public WorkOrderForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DBContext = new CarServiceFormsDBContext();
            workOrderInstructionsDataGridView.AutoGenerateColumns = false;
        }

        private void CleanupComponents()
        {
            DBContext.Dispose();
        }

        private void SelectCustomerButton_Click(object sender, EventArgs e)
        {
            using (var form = new SearchCustomerWithVehicleForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var customerId = form.ReturnValue1;
                    var vehicleId = form.ReturnValue2;

                    Customer = DBContext.Customer.Find(customerId);
                    Vehicle = DBContext.Vehicle.Find(vehicleId);

                    customerDataTextBox.Lines = new string[]
                    {
                        string.Format("{0} {1}", Customer.FirstName, Customer.LastName),
                        Customer.Street,
                        Customer.Post,
                        Customer.Phone
                    };

                    vehicleRegistrationNumberTextBox.Text = Vehicle.RegistrationNumber;
                    vehicleIdentificationNumberTextBox.Text = Vehicle.IdentificationNumber;
                    vehicleTypeCodeTextBox.Text = Vehicle.TypeCode;
                    vehicleTypeTextBox.Text = Vehicle.Type;
                    vehicleMKBTextBox.Text = Vehicle.MKBCode;
                    vehicleGKBTextBox.Text = Vehicle.GKBCode;
                    vehicleRegistrationDateDateTimePicker.Value = Vehicle.RegistrationDate;

                    WorkOrderInstructions = new List<WorkOrderInstruction>();
                    workOrderInstructionsDataGridView.DataSource = new BindingList<WorkOrderInstruction>(WorkOrderInstructions);
                }
            }
        }

        private void WorkOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            WorkOrder = new WorkOrder()
            {
                Number = wordOrderNumberTextBox.Text,
                Created = DateTime.Now,
                Deadline = workOrderDeadlineDateTimePicker.Value,
                Vehicle = Vehicle,
                WorkOrderInstructions = WorkOrderInstructions
            };

            DBContext.WorkOrder.Add(WorkOrder);
            DBContext.SaveChanges();

            CloseForm();
        }

        private void CloseForm()
        {
            Dispose();
            Close();
        }
    }
}
