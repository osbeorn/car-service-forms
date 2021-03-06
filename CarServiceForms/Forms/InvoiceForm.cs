﻿using CarServiceForms.Classes;
using CarServiceForms.Core.Helpers;
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
        private const string INVOICE_NUMBER_FORMAT = "{0}-{1}";

        private static KeyPressEventHandler NumericCheckHandler = new KeyPressEventHandler(NumericCheck);

        private CarServiceFormsDBContext DBContext { get; set; }

        private WorkOrder WorkOrder { get; set; }
        private Invoice Invoice { get; set; }

        private IList<InvoiceItem> InvoiceItems { get; set; }
        private List<long> DeletedInvoiceItems { get; set; }

        private static IList<InvoiceItemDescriptionDTO> InvoiceItemDescriptions { get; set; }

        public InvoiceForm(long workOrderId)
        {
            InitializeComponent();
            InitializeComponents(workOrderId);
        }

        private void InitializeComponents(long workOrderId)
        {
            DBContext = new CarServiceFormsDBContext();
            invoiceItemsDataGridView.AutoGenerateColumns = false;
            SetupInvoiceData(workOrderId);
        }

        private void SetupInvoiceData(long workOrderId)
        {
            WorkOrder = DBContext.WorkOrder.Find(workOrderId);
            if (WorkOrder.Invoice != null)
            {
                Invoice = WorkOrder.Invoice;
                InvoiceItems = Invoice.InvoiceItems.ToList();
                paymentDeadlineDateTimePicker.Value = Invoice.Deadline;
            }
            else
            {
                deleteButton.Visible = false;

                InvoiceItems = new List<InvoiceItem>();

                // set service type invoice item
                if (WorkOrder.Service != null)
                {
                    var serviceType = WorkOrder.Service.ServiceType;

                    InvoiceItems.Add(new InvoiceItem()
                    {
                        Description = serviceType.Name.ToUpperInvariant()
                    });
                }

                var paymentDeadline = SettingsHelper.GetConfigValue<int>(SettingsFields.PAYMENT_DEADLINE);
                paymentDeadlineDateTimePicker.Value = DateTime.Today.AddDays(paymentDeadline);
            }

            InvoiceItemDescriptions = new List<InvoiceItemDescriptionDTO>();
            DBContext
                .InvoiceItemDescription
                .Select(iid => new InvoiceItemDescriptionDTO()
                {
                    Code = "DESC-" + iid.Id,
                    Value = iid.Value
                })
                .ToList()
                .ForEach(iid => InvoiceItemDescriptions.Add(iid));
            DBContext
                .Supplies
                .Select(s => new InvoiceItemDescriptionDTO()
                {
                    Code = "SUPP-" + s.Id,
                    Value = s.Name
                })
                .ToList()
                .ForEach(s => InvoiceItemDescriptions.Add(s));

            InvoiceItemDescriptions = InvoiceItemDescriptions.OrderBy(iid => iid.Value).ToList(); ;

            var descriptionColumn = invoiceItemsDataGridView.Columns["Description"] as DataGridViewComboBoxColumn;
            descriptionColumn.ValueMember = "Value";
            descriptionColumn.DisplayMember = "Value";
            descriptionColumn.DataSource = new BindingList<InvoiceItemDescriptionDTO>(InvoiceItemDescriptions);

            invoiceItemsDataGridView.DataSource = new BindingList<InvoiceItem>(InvoiceItems);

            DeletedInvoiceItems = new List<long>();

            UpdateTotalLabels();
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
            var totalTaxBase = 0m;
            var totalTax = 0m;
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
                var taxBase = salePrice - discount;
                var tax = (taxBase * invoiceItem.TaxPercentage) / 100m;
                var finalPrice = salePrice - discount + tax;

                invoiceItem.SalePrice = salePrice;
                invoiceItem.TaxBase = taxBase;
                invoiceItem.FinalPrice = finalPrice;

                totalSalePrice += salePrice;
                totalDiscount += discount;
                totalTaxBase += taxBase;
                totalTax += tax;
                totalFinalPrice += finalPrice;

                invoiceItemsDataGridView.UpdateCellValue(invoiceItemsDataGridViewRow.Cells["SalePrice"].ColumnIndex, invoiceItemsDataGridViewRow.Index);
                invoiceItemsDataGridView.UpdateCellValue(invoiceItemsDataGridViewRow.Cells["TaxBase"].ColumnIndex, invoiceItemsDataGridViewRow.Index);
            }

            totalSalePriceLabel.Text = string.Format("{0:c}", totalSalePrice);
            totalDiscountLabel.Text = string.Format("{0:c}", totalDiscount);
            totalTaxBaseLabel.Text = string.Format("{0:c}", totalTaxBase);
            totalTaxLabel.Text = string.Format("{0:c}", totalTax); ;
            totalFinalPriceLabel.Text = string.Format("{0:c}", totalFinalPrice);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            SaveInvoice();
            PrintInvoice();
        }

        private void InvoiceItemsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var columnName = invoiceItemsDataGridView.CurrentCell.OwningColumn.Name;
            var row = invoiceItemsDataGridView.CurrentCell.OwningRow;
            var invoiceItem = invoiceItemsDataGridView.CurrentCell.OwningRow.DataBoundItem as InvoiceItem;

            if (columnName == "Quantity" || columnName == "Price" || columnName == "Discount")
            {
                e.Control.KeyPress -= NumericCheckHandler;
                e.Control.KeyPress += NumericCheckHandler;
            }
            else
            {
                if (columnName == "Description")
                {
                    var comboBox = e.Control as DataGridViewComboBoxEditingControl;
                    if (comboBox != null)
                    {
                        comboBox.KeyPress += UppercaseDropdown;
                        comboBox.Validating += ValidateDropdown;
                        comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                        comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                    }
                }

                e.Control.KeyPress -= NumericCheckHandler;
            }
        }

        private static void NumericCheck(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl control = sender as DataGridViewTextBoxEditingControl;
            if (control != null && (e.KeyChar == '.' || e.KeyChar == ','))
            {
                e.KeyChar = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
                e.Handled = control.Text.Contains(e.KeyChar);
            }
            else
            {
                e.Handled = !Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar);
            }
        }

        private void UppercaseDropdown(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpperInvariant(e.KeyChar);
            }
        }

        private void ValidateDropdown(object sender, CancelEventArgs e)
        {
            DataGridViewComboBoxEditingControl control = sender as DataGridViewComboBoxEditingControl;

            string value = control.Text;
            var exists = control.Items
                .Cast<InvoiceItemDescriptionDTO>()
                .FirstOrDefault(iid => iid.Value.ToUpperInvariant() == value.Trim().ToUpperInvariant());

            if (exists == null)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell) invoiceItemsDataGridView.CurrentCell;

                InvoiceItemDescriptions.Add(
                    new InvoiceItemDescriptionDTO()
                    {
                        Value = value.Trim().ToUpperInvariant()
                    }
                );
                invoiceItemsDataGridView.CurrentCell.Value = value.Trim().ToUpperInvariant();
            }

            if (exists != null)
            {
                var invoiceItem = invoiceItemsDataGridView.CurrentCell.OwningRow.DataBoundItem as InvoiceItem;
                if (invoiceItem != null)
                {
                    invoiceItem.Code = exists.Code;
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            invoiceItemsDataGridView.CancelEdit();

            SaveInvoice();            
        }

        private void SaveInvoice()
        {
            // save new InvoiceItemDescriptions
            foreach (DataGridViewRow row in invoiceItemsDataGridView.Rows)
            {
                var invoiceItem = row.DataBoundItem as InvoiceItem;
                if (invoiceItem != null && string.IsNullOrEmpty(invoiceItem.Code))
                {
                    var existingInvoiceItemDescription = DBContext.InvoiceItemDescription
                        .Where(iid => iid.Value == invoiceItem.Description)
                        .FirstOrDefault();

                    if (existingInvoiceItemDescription == null)
                    {
                        var invoiceItemDescription = new InvoiceItemDescription()
                        {
                            Value = invoiceItem.Description
                        };
                        DBContext.InvoiceItemDescription.Add(invoiceItemDescription);
                    }
                }
            }
            DBContext.SaveChanges();

            if (Invoice != null)
            {
                Invoice.InvoiceItems = InvoiceItems;
                Invoice.Deadline = paymentDeadlineDateTimePicker.Value;
            }
            else
            {
                var invoiceNumber = string.Format(INVOICE_NUMBER_FORMAT, DateTime.Now.Year, GetNextInvoiceNumber());

                Invoice = new Invoice()
                {
                    Created = DateTime.Now,
                    WorkOrder = WorkOrder,
                    InvoiceItems = InvoiceItems,
                    Number = invoiceNumber,
                    Deadline = paymentDeadlineDateTimePicker.Value
                };
                DBContext.Invoice.Add(Invoice);
            }

            // reduce supply quantity
            foreach (InvoiceItem invoiceItem in Invoice.InvoiceItems)
            {
                if (string.IsNullOrEmpty(invoiceItem.Code))
                {
                    var invoiceItemDescription = DBContext.InvoiceItemDescription
                        .Where(iid => iid.Value == invoiceItem.Description)
                        .FirstOrDefault();

                    if (invoiceItemDescription != null)
                    {
                        invoiceItem.Code = "DESC-" + invoiceItemDescription.Id;
                    }
                }

                if (invoiceItem.Id <= 0) // new record
                {
                    
                    if (!string.IsNullOrEmpty(invoiceItem.Code) && invoiceItem.Code.StartsWith("SUPP"))
                    {
                        var index = invoiceItem.Code.IndexOf("-");
                        var id = long.Parse(invoiceItem.Code.Substring(index + 1));

                        var supplies = DBContext.Supplies.Find(id);
                        supplies.Quantity -= invoiceItem.Quantity;
                    }
                }
                else // old records
                {
                    // compare new and old quantities
                    // TODO - it is currently not possible to edit old records
                }
            }

            foreach (long deletedInvoiceItemId in DeletedInvoiceItems)
            {
                var deletedInvoiceItem = DBContext.InvoiceItem.Find(deletedInvoiceItemId);
                if (deletedInvoiceItem.Code.StartsWith("SUPP"))
                {
                    var index = deletedInvoiceItem.Code.IndexOf("-");
                    var id = long.Parse(deletedInvoiceItem.Code.Substring(index + 1));

                    var supplies = DBContext.Supplies.Find(id);
                    if (supplies != null)
                    {
                        supplies.Quantity += deletedInvoiceItem.Quantity;
                    }
                }
                DBContext.InvoiceItem.Remove(deletedInvoiceItem);
            }

            DBContext.SaveChanges();
        }

        private void PrintInvoice()
        {
            var workOrder = DBContext.WorkOrder.Find(WorkOrder.Id);
            var invoice = new InvoiceReportDTO()
            {
                InvoiceNumber = workOrder.Invoice.Number,
                InvoiceCreated = workOrder.Invoice.Created,
                InvoiceDeadline = workOrder.Invoice.Deadline,

                InvoiceCompanyName = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_NAME),
                InvoiceCompanyAddress1 = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_ADDRESS_1),
                InvoiceCompanyAddress2 = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_ADDRESS_2),
                InvoiceCompanyBankAccount = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_BANK_ACCOUNT),
                InvoiceCompanyDirector = SettingsHelper.GetConfigValue<string>(SettingsFields.COMPANY_DIRECTOR),

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
                    InvoiceItemSalePrice = invoiceItem.SalePrice,
                    InvoiceItemDiscount = invoiceItem.Discount,
                    InvoiceItemTaxPercentage = invoiceItem.TaxPercentage,
                    InvoiceItemTaxBase = invoiceItem.TaxBase,
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
            form.ShowDialog();
        }

        private string GetNextInvoiceNumber()
        {
            var maxInvoiceNumber = DBContext.Invoice
                    .Where(wo => wo.Created.Year == DateTime.Now.Year)
                    .Select(wo => wo.Number.ToString())
                    .ToList()
                    .Select(n =>
                    {
                        var split = n.Split('-');
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

            return (++maxInvoiceNumber).ToString("D4");
        }

        private void InvoiceItemsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["TaxPercentage"].Value = 22.0m;
        }

        private void InvoiceItemsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var invoiceItem = e.Row.DataBoundItem as InvoiceItem;
            if (invoiceItem.Id > 0)
            {
                DeletedInvoiceItems.Add(invoiceItem.Id);
            }
        }

        private void InvoiceItemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var row = invoiceItemsDataGridView.Rows[e.RowIndex];
                var cell = row.Cells[e.ColumnIndex];

                var invoiceItem = row.DataBoundItem as InvoiceItem;
                if (invoiceItem != null && invoiceItem.Id > 0)
                {
                    cell.ReadOnly = true;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ali res želite stornirati izbrani račun?", "Storno računa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // reduce supply quantity
                foreach (InvoiceItem invoiceItem in Invoice.InvoiceItems)
                {
                    if (invoiceItem.Code.StartsWith("SUPP"))
                    {
                        var index = invoiceItem.Code.IndexOf("-");
                        var id = long.Parse(invoiceItem.Code.Substring(index + 1));

                        var supplies = DBContext.Supplies.Find(id);
                        if (supplies != null)
                        {
                            supplies.Quantity += invoiceItem.Quantity;
                        }
                    }
                }
                DBContext.InvoiceItem.RemoveRange(Invoice.InvoiceItems);
                DBContext.Invoice.Remove(Invoice);

                DBContext.SaveChanges();

                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            invoiceItemsDataGridView.CancelEdit();
        }
    }
}
