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
    public partial class WorkOrderForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }

        private Customer Customer { get; set; }
        private Vehicle Vehicle { get; set; }
        private WorkOrder WorkOrder { get; set; }
        private IList<WorkOrderInstruction> WorkOrderInstructions { get; set; }

        public WorkOrderForm()
        {
            SetupWorkOrderForm(null);
        }

        public WorkOrderForm(long workOrderId)
        {
            SetupWorkOrderForm(workOrderId);
        }

        private void SetupWorkOrderForm(long? workOrderId)
        {
            InitializeComponent();
            InitializeComponents(workOrderId);
        }

        private void InitializeComponents(long? workOrderId)
        {
            DBContext = new CarServiceFormsDBContext();
            workOrderInstructionsDataGridView.AutoGenerateColumns = false;
            SetupWorkOrderData(workOrderId, null, null);
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

                    SetupWorkOrderData(null, customerId, vehicleId);
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
            Vehicle.Mileage = Convert.ToInt32(vehicleMileageNumericUpDown.Value);

            if (WorkOrder == null)
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
            } else
            {
                WorkOrder.Number = wordOrderNumberTextBox.Text;
                WorkOrder.Deadline = workOrderDeadlineDateTimePicker.Value;
                WorkOrder.WorkOrderInstructions = WorkOrderInstructions;
            }

            DBContext.SaveChanges();

            CloseForm();
        }

        private void CloseForm()
        {
            Dispose();
            Close();
        }

        private void SetupWorkOrderData(long? workOrderId, long? customerId, long? vehicleId)
        {
            if (!workOrderId.HasValue && !customerId.HasValue && !vehicleId.HasValue)
                return;

            if (workOrderId.HasValue)
            {
                WorkOrder = DBContext.WorkOrder.Find(workOrderId.Value);
                Customer = WorkOrder.Vehicle.Customer;
                Vehicle = WorkOrder.Vehicle;
                WorkOrderInstructions = WorkOrder.WorkOrderInstructions.ToList();

                wordOrderNumberTextBox.Text = WorkOrder.Number;
                workOrderDeadlineDateTimePicker.Value = WorkOrder.Deadline;
            }
            else if (customerId.HasValue && vehicleId.HasValue)
            {
                Customer = DBContext.Customer.Find(customerId);
                Vehicle = DBContext.Vehicle.Find(vehicleId);
                WorkOrderInstructions = new List<WorkOrderInstruction>();
            }

            customerDataTextBox.Lines = Customer.LongDescription.Split('\n');

            vehicleRegistrationNumberTextBox.Text = Vehicle.RegistrationNumber;
            vehicleIdentificationNumberTextBox.Text = Vehicle.IdentificationNumber;
            vehicleTypeCodeTextBox.Text = Vehicle.TypeCode;
            vehicleTypeTextBox.Text = Vehicle.Type;
            vehicleMKBTextBox.Text = Vehicle.MKBCode;
            vehicleGKBTextBox.Text = Vehicle.GKBCode;
            vehicleRegistrationDateDateTimePicker.Value = Vehicle.RegistrationDate;
            vehicleMileageNumericUpDown.Value = Vehicle.Mileage;
            vehicleModelYearNumericUpDown.Value = Vehicle.ModelYear;

            workOrderInstructionsDataGridView.DataSource = new BindingList<WorkOrderInstruction>(WorkOrderInstructions);
        }
    }
}
