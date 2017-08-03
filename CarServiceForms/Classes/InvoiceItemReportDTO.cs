using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Classes
{
    class InvoiceItemReportDTO
    {
        public string InvoiceItemDescription { get; set; }
        public decimal InvoiceItemQuantity { get; set; }
        public decimal InvoiceItemPrice { get; set; }
        public decimal InvoiceItemSalePrice { get; set; }
        public decimal InvoiceItemDiscount { get; set; }
        public decimal InvoiceItemTaxPercentage { get; set; }
        public decimal InvoiceItemTaxBase { get; set; }
        public decimal InvoiceItemFinalPrice { get; set; }
    }
}
