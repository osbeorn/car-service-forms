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
                .Select(wo => new
                {
                    Id = wo.Id,
                    Created = wo.Created,
                    Deadline = wo.Deadline,
                    Customer = wo.Vehicle.Customer.ShortDescription,
                    Vehicle = wo.Vehicle.ShortDescription
                })
                .ToList();
            workOrdersDataGridView.DataSource = workOrders;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var serviceItems = DBContext.ServiceItem
                .Select(si =>
                    new ServiceItemWithServiceItemGroupDTO()
                    {
                        Id = si.Id,
                        Description = si.Description,
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
    }
}
