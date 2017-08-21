using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Classes
{
    class InvoiceItemDescriptionDTO
    {
        public string Code { get; set; }
        public string Value { get; set; }

        public long GetId()
        {
            var index = Code.IndexOf("-");
            return long.Parse(Code.Substring(index));
        }
    }
}
