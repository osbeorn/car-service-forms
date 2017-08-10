using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Classes
{
    class WorkOrderDTO
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }
        public string Customer { get; set; }
        public string Vehicle { get; set; }

        public bool HasService { get; set; }
        public bool HasInvoice { get; set; }
    }
}
