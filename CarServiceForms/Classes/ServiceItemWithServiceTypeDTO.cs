using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Classes
{
    class ServiceItemWithServiceTypeDTO
    {
        public long Id { get; set; }
        public long ServiceItemId { get; set; }
        public string ServiceItemName { get; set; }

        public ServiceType ServiceType { get; set; }
    }
}
