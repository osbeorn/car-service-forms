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

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var serviceItems = DBContext.ServiceItem
                .Where(si => si.ServiceTypes.Any(sist => sist.ServiceType == ServiceType.Inspection))
                .Select(si =>
                    new ServiceItemWithServiceItemGroupDTO()
                    {
                        Id = si.Id,
                        Name = si.Name,
                        Order = si.Order,
                        HasRemarks = si.HasRemarks,
                        ServiceItemGroupId = si.ServiceItemGroup.Id,
                        ServiceItemGroupName = si.ServiceItemGroup.Name,
                        ServiceItemGroupOrder = si.ServiceItemGroup.Order
                    }
                )
                .ToList();

            var serviceFormReport = new List<CarServiceFormReportDTO>()
            {
                new CarServiceFormReportDTO()
                {
                    WorkOrderNumber = "1234567890",
                    VehicleIdentificationNumber = "",
                    VehicleType = "",
                    VehicleTypeCode = "",
                    VehicleMKBCode = "",
                    VehicleGKBCode = "",
                    VehicleRegistrationNumber = "",
                    VehicleMileage = "21223",
                    VehicleRegistrationDate = DateTime.Now,
                    VehicleModelYear = DateTime.Now.Year.ToString(),
                    ServiceType = ServiceType.Inspection
                }
            };  

            var datasources = new List<ReportDataSource>()
            {
                new ReportDataSource("HeaderDataSet", serviceFormReport),
                new ReportDataSource("BodyDataSet", serviceItems)
            };

            var form = new ReportViewerForm();
            form.SetReport(
                "CarServiceForms.Reports.CarServiceFormReport.rdlc",
                datasources
            );
            form.Show();
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
                        workOrdersDataGridView.Refresh();
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
                        workOrdersDataGridView.Refresh();
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

            var dataGridViewColumn = workOrdersDataGridView.Columns[e.ColumnIndex];
            if (dataGridViewColumn.Name == "Service")
            {
                var servicesExist = DBContext.WorkOrder.Find(workOrderDTO.Id).Services.Any();
                if (servicesExist)
                {
                    var dataGridViewButtonColumn = (DataGridViewButtonColumn) dataGridViewColumn;
                    dataGridViewButtonColumn.Text = "✔";
                }
            }
            else if (dataGridViewColumn.Name == "Invoice")
            {
                var invoiceExist = DBContext.WorkOrder.Find(workOrderDTO.Id).Invoice != null;
                if (invoiceExist)
                {
                    var dataGridViewButtonColumn = (DataGridViewButtonColumn) dataGridViewColumn;
                    dataGridViewButtonColumn.Text = "✔";
                }
            }
        }
    }
}
