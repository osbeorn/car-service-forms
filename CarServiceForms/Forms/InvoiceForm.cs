using CarServiceForms.Classes;
using CarServiceForms.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceForms.Forms
{
    public partial class InvoiceForm : Form
    {
        private static KeyPressEventHandler NumericCheckHandler = new KeyPressEventHandler(NumericCheck);

        private CarServiceFormsDBContext DBContext { get; set; }

        private IList<InvoiceItem> InvoiceItems { get; set; }

        private long WorkOrderId { get; set; }

        public InvoiceForm(long workOrderId)
        {
            InitializeComponent();
            InitializeComponents(workOrderId);
        }

        private void InitializeComponents(long workOrderId)
        {
            DBContext = new CarServiceFormsDBContext();

            invoiceItemsDataGridView.AutoGenerateColumns = false;

            WorkOrderId = workOrderId;

            InvoiceItems = new List<InvoiceItem>();
            invoiceItemsDataGridView.DataSource = new BindingList<InvoiceItem>(InvoiceItems);
        }

        private void CleanupComponents()
        {
            DBContext.Dispose();
        }

        private void InvoiceItemsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotalLabels();
        }

        private void InvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupComponents();
        }

        private void InvoiceItemsDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            UpdateTotalLabels();
        }

        private void UpdateTotalLabels()
        {
            var totalSalePrice = 0m;
            var totalDiscount = 0m;
            var totalFinalPrice = 0m;

            foreach (DataGridViewRow invoiceItemsDataGridViewRow in invoiceItemsDataGridView.Rows)
            {
                var invoiceItem = invoiceItemsDataGridViewRow.DataBoundItem as InvoiceItem;
                if (invoiceItem == null)
                {
                    continue;
                }

                var salePrice = invoiceItem.Quantity * invoiceItem.Price;
                var discount = (salePrice * invoiceItem.Discount) / 100m;
                var finalPrice = salePrice - discount;

                invoiceItem.FinalPrice = finalPrice;

                totalSalePrice += salePrice;
                totalDiscount += discount;
                totalFinalPrice += finalPrice;
            }

            totalSalePriceLabel.Text = string.Format("{0:c}", totalSalePrice);
            totalDiscountLabel.Text = string.Format("{0:c}", totalDiscount);
            totalFinalPriceLabel.Text = string.Format("{0:c}", totalFinalPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var workOrder = DBContext.WorkOrder.Find(WorkOrderId);
            var invoice = new InvoiceReportDTO()
            {
                WorkOrderNumber = workOrder.Number,
                WorkOrderCreated = workOrder.Created,
                WorkOrderDeadline = workOrder.Deadline,
                WorkOrderFinished = workOrder.Finished,

                CustomerFirstName = workOrder.Vehicle.Customer.FirstName,
                CustomerLastName = workOrder.Vehicle.Customer.LastName,
                CustomerStreet = workOrder.Vehicle.Customer.Street,
                CustomerPost = workOrder.Vehicle.Customer.Post,

                VehicleRegistrationNumber = workOrder.Vehicle.RegistrationNumber,
                VehicleEngine = workOrder.Vehicle.Engine,
                VehicleGKBCode = workOrder.Vehicle.GKBCode,
                VehicleIdentificationNumber = workOrder.Vehicle.IdentificationNumber,
                VehicleMileage = workOrder.Vehicle.Mileage,
                VehicleMKBCode = workOrder.Vehicle.MKBCode,
                VehicleModelYear = workOrder.Vehicle.ModelYear,
                VehicleRegistrationDate = workOrder.Vehicle.RegistrationDate,
                VehicleTransmission = workOrder.Vehicle.Transmission,
                VehicleType = workOrder.Vehicle.Type,
                VehicleTypeCode = workOrder.Vehicle.TypeCode
            };

            var invoiceItems = new List<InvoiceItemReportDTO>();
            foreach (var invoiceItem in InvoiceItems)
            {
                invoiceItems.Add(new InvoiceItemReportDTO()
                {
                    InvoiceItemDescription = invoiceItem.Description,
                    InvoiceItemQuantity = invoiceItem.Quantity,
                    InvoiceItemPrice = invoiceItem.Price,
                    InvoiceItemDiscount = invoiceItem.Discount,
                    InvoiceItemFinalPrice = invoiceItem.FinalPrice
                });
            }

            var datasources = new List<ReportDataSource>()
            {
                new ReportDataSource("InvoiceDataSet", new List<InvoiceReportDTO>() { invoice }),
                new ReportDataSource("InvoiceItemsDataSet", invoiceItems)
            };

            var form = new ReportViewerForm();
            form.SetReport(
                "CarServiceForms.Reports.InvoiceReport.rdlc",
                datasources
            );
            form.Show();
        }

        private void InvoiceItemsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string columnName = invoiceItemsDataGridView.CurrentCell.OwningColumn.Name;
            if (columnName == "Quantity" || columnName == "Price" || columnName == "Discount")
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
            else
            {
                e.Control.KeyPress -= NumericCheckHandler;
            }
        }

        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl s = sender as DataGridViewTextBoxEditingControl;
            if (s != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = s.Text.Contains(e.KeyChar);
            }
            else
            {
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var workOrder = DBContext.WorkOrder.Find(WorkOrderId);

            var invoice = new Invoice()
            {
                Created = DateTime.Now,
                WorkOrder = workOrder,
                InvoiceItems = InvoiceItems,
                Number = "1"
            };

            DBContext.Invoice.Add(invoice);
            DBContext.SaveChanges();
        }
    }
}
