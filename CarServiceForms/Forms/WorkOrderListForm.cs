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
using Microsoft.Reporting.WinForms;
using CarServiceForms.Classes;
using CarServiceForms.Core.Collections;

namespace CarServiceForms.Forms
{
    public partial class WorkOrderListForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }

        public WorkOrderListForm()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            DBContext = new CarServiceFormsDBContext();
            workOrdersDataGridView.AutoGenerateColumns = false;

            LoadWorkOrders();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            using (var form = new WorkOrderForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadWorkOrders();
                }
            }
        }

        private void LoadWorkOrders()
        {
            var workOrders = DBContext.WorkOrder
                .OrderBy(wo => wo.Created)
                .ToList()
                .Select(wo => new WorkOrderDTO()
                {
                    Id = wo.Id,
                    Number = wo.Number,
                    Created = wo.Created,
                    Deadline = wo.Deadline,
                    Customer = wo.Vehicle.Customer.ShortDescription,
                    Vehicle = wo.Vehicle.ShortDescription
                })
                .ToList();
            workOrdersDataGridView.DataSource = new SortableBindingList<WorkOrderDTO>(workOrders);
        }

        private void WorkOrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var workOrdersDataGridView = (DataGridView) sender;

            if (e.RowIndex >= 0 && workOrdersDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && workOrdersDataGridView.Columns[e.ColumnIndex].Name == "Service")
            {
                var workOrder = workOrdersDataGridView.Rows[e.RowIndex].DataBoundItem as WorkOrderDTO;
                //using (var form = new ServiceSelectionForm(workOrder.Id))
                using (var form = new ExtendedServiceSelectionForm(workOrder.Id))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadWorkOrders();
                    }
                }
            }
            else if (e.RowIndex >= 0 && workOrdersDataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && workOrdersDataGridView.Columns[e.ColumnIndex].Name == "Invoice")
            {
                var workOrder = workOrdersDataGridView.Rows[e.RowIndex].DataBoundItem as WorkOrderDTO;
                using (var form = new InvoiceForm(workOrder.Id))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadWorkOrders();
                    }
                }
            }
        }

        private void WorkOrdersDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var workOrder = workOrdersDataGridView.Rows[e.RowIndex].DataBoundItem as WorkOrderDTO;
            using (var form = new WorkOrderForm(workOrder.Id))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadWorkOrders();
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditServiceItemsForm().Show();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSearchCustomerWithVehicleForm();
        }

        private void OpenSearchCustomerWithVehicleForm()
        {
            using (var form = new SearchCustomerWithVehicleForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var selectedCustomerId = form.ReturnValue1;
                    var selectedVehicleId = form.ReturnValue2;

                    using (var form2 = new EditCustomerWithVehicleForm(selectedCustomerId.Value, selectedVehicleId.Value))
                    {
                        form2.ShowDialog();
                    }

                    OpenSearchCustomerWithVehicleForm();
                }
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void ServiceItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditServiceItemsForm().ShowDialog();
        }

        private void ServiceTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WorkOrdersDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var workOrderDTO = workOrdersDataGridView.Rows[e.RowIndex].DataBoundItem as WorkOrderDTO;
            var workOrder = DBContext.WorkOrder.Find(workOrderDTO.Id);

            var dataGridViewColumn = workOrdersDataGridView.Columns[e.ColumnIndex];
            var dataGridViewCell = workOrdersDataGridView[e.ColumnIndex, e.RowIndex];
            if (dataGridViewColumn.Name == "Service")
            {
                var serviceExist = workOrder.Service != null;
                var dataGridViewButtonCell = (DataGridViewButtonCell)dataGridViewCell;
                if (serviceExist)
                {
                    dataGridViewButtonCell.Value = "✔";
                }
                else
                {
                    dataGridViewButtonCell.Value = "...";
                }
            }
            else if (dataGridViewColumn.Name == "Invoice")
            {
                var invoiceExist = workOrder.Invoice != null;
                var dataGridViewButtonCell = (DataGridViewButtonCell)dataGridViewCell;
                if (invoiceExist)
                {
                    dataGridViewButtonCell.Value = "✔";
                }
                else
                {
                    dataGridViewButtonCell.Value = "...";
                }
            }
        }
    }
}
