using CarServiceForms.Classes;
using CarServiceForms.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class ServiceSelectionForm : Form
    {
        private CarServiceFormsDBContext DBContext { get; set; }
        private WorkOrder WorkOrder { get; set; }

        public ServiceSelectionForm(long workOrderId)
        {
            InitializeComponent();
            InitializeComponents(workOrderId);
        }

        private void InitializeComponents(long workOrderId)
        {
            DBContext = new CarServiceFormsDBContext();
            GetWorkOrderData(workOrderId);
            SetupServiceTypeComboBoxDatasource();
        }

        public void CleanupComponents()
        {
            DBContext.Dispose();
        }

        private void GetWorkOrderData(long workOrderId)
        {
            WorkOrder = DBContext.WorkOrder.Find(workOrderId);
        }

        private void SetupServiceTypeComboBoxDatasource()
        {
            var serviceTypes = new List<dynamic>()
            {
                new
                {
                    Value = ServiceType.OilChange,
                    Description = GetServiceTypeDescription(ServiceType.OilChange)
                },
                new
                {
                    Value = ServiceType.Inspection,
                    Description = GetServiceTypeDescription(ServiceType.Inspection)
                },
                new
                {
                    Value = ServiceType.Interval,
                    Description = GetServiceTypeDescription(ServiceType.Interval)
                }
            };
            serviceTypeComboBox.DataSource = serviceTypes;
        }

        private string GetServiceTypeDescription(ServiceType serviceType)
        {
            switch (serviceType)
            {
                case ServiceType.Inspection:
                    return "servisni pregled (časovno ali kilometrsko pogojeni)";
                case ServiceType.Interval:
                    return "intervalni servis (fiksno)";
                case ServiceType.OilChange:
                    return "servis z menjavo olja";
                default:
                    return "Neveljaven tip servisa.";
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var selectedServiceType = (ServiceType) serviceTypeComboBox.SelectedValue;

            var serviceItems = DBContext.ServiceItem
                .Where(si => 
                    si.ServiceTypes.Any(sist => sist.ServiceType == selectedServiceType) &&
                    si.Enabled &&
                    si.ServiceItemGroup.Enabled
                )
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
                    WorkOrderNumber = WorkOrder.Number,
                    VehicleIdentificationNumber = WorkOrder.Vehicle.IdentificationNumber,
                    VehicleType = WorkOrder.Vehicle.Type,
                    VehicleTypeCode = WorkOrder.Vehicle.TypeCode,
                    VehicleMKBCode = WorkOrder.Vehicle.MKBCode,
                    VehicleGKBCode = WorkOrder.Vehicle.GKBCode,
                    VehicleRegistrationNumber = WorkOrder.Vehicle.RegistrationNumber,
                    VehicleMileage = WorkOrder.Vehicle.Mileage.ToString(),
                    VehicleRegistrationDate = WorkOrder.Vehicle.RegistrationDate,
                    VehicleModelYear = WorkOrder.Vehicle.ModelYear.ToString(),
                    ServiceType = selectedServiceType
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
            form.ShowDialog();
        }

        private void ServiceSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }
    }
}
