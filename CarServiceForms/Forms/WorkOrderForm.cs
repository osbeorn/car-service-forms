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
        private const string WORK_ORDER_NUMBER_FORMAT = "{0}/{1}";

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
            using (var form = new SearchCustomerWithVehicleForm(true))
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
                    Number = workOrderNumberMaskedTextBox.Text,
                    Created = DateTime.Now,
                    Deadline = workOrderDeadlineDateTimePicker.Value,
                    Vehicle = Vehicle,
                    WorkOrderInstructions = WorkOrderInstructions
                };
                DBContext.WorkOrder.Add(WorkOrder);
            } else
            {
                WorkOrder.Number = workOrderNumberMaskedTextBox.Text;
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
            {
                var workOrderNumber = GetNextWorkOrderNumber();
                workOrderNumberMaskedTextBox.Text = string.Format(WORK_ORDER_NUMBER_FORMAT, DateTime.Now.Year, workOrderNumber);

                return;
            }

            if (workOrderId.HasValue)
            {
                WorkOrder = DBContext.WorkOrder.Find(workOrderId.Value);
                Customer = WorkOrder.Vehicle.Customer;
                Vehicle = WorkOrder.Vehicle;
                WorkOrderInstructions = WorkOrder.WorkOrderInstructions.ToList();

                workOrderNumberMaskedTextBox.Text = WorkOrder.Number;
                workOrderNumberMaskedTextBox.ReadOnly = true;

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
            vehicleEngineTextBox.Text = Vehicle.Engine;
            vehicleMKBTextBox.Text = Vehicle.MKBCode;
            vehicleTransmissionTextBox.Text = Vehicle.Transmission;
            vehicleGKBTextBox.Text = Vehicle.GKBCode;
            vehicleRegistrationDateDateTimePicker.Value = Vehicle.RegistrationDate;
            vehicleMileageNumericUpDown.Value = Vehicle.Mileage;
            vehicleModelYearNumericUpDown.Value = Vehicle.ModelYear;

            workOrderInstructionsDataGridView.DataSource = new BindingList<WorkOrderInstruction>(WorkOrderInstructions);
        }

        private string GetNextWorkOrderNumber()
        {
            var maxWorkOrderNumber = DBContext.WorkOrder
                    .Where(wo => wo.Created.Year == DateTime.Now.Year)
                    .Select(wo => wo.Number.ToString())
                    .ToList()
                    .Select(n =>
                    {
                        var split = n.Split('/');
                        if (split.Length == 2)
                        {
                            int result;
                            bool success = Int32.TryParse(split[1], out result);
                            return success ? result : 0;
                        }
                        return 0;
                    })
                    .DefaultIfEmpty()
                    .Max();

            return (++maxWorkOrderNumber).ToString("D4");
        }

        private void WorkOrderNumberMaskedTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void VehicleMileageNumericUpDown_Enter(object sender, EventArgs e)
        {
            vehicleMileageNumericUpDown.Select(0, vehicleMileageNumericUpDown.Text.Length);
        }

        private void WorkOrderInstructionsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                var textBoxControl = (TextBox)e.Control;
                textBoxControl.CharacterCasing = CharacterCasing.Upper;
            }
        }
    }
}
