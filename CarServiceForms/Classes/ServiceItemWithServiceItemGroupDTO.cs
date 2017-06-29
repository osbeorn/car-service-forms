using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Classes
{
    class ServiceItemWithServiceItemGroupDTO
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public bool HasRemarks { get; set; }

        public long ServiceItemGroupId { get; set; }
        public string ServiceItemGroupName { get; set; }
        public int ServiceItemGroupOrder { get; set; }
    }
}
