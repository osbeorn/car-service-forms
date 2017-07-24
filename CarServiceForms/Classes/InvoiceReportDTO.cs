using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Classes
{
    class InvoiceReportDTO
    {
        // invoice
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceCreated { get; set; }

        // work order
        public string WorkOrderNumber { get; set; }
        public DateTime WorkOrderCreated { get; set; }
        public DateTime WorkOrderDeadline { get; set; }
        public DateTime? WorkOrderFinished { get; set; }

        // customer
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerStreet { get; set; }
        public string CustomerPost { get; set; }

        // vehicle
        public string VehicleRegistrationNumber { get; set; }
        public DateTime VehicleRegistrationDate { get; set; }
        public string VehicleIdentificationNumber { get; set; }
        public string VehicleType { get; set; }
        public string VehicleTypeCode { get; set; }
        public string VehicleMKBCode { get; set; }
        public string VehicleGKBCode { get; set; }
        public int VehicleMileage { get; set; }
        public int VehicleModelYear { get; set; }
        public string VehicleEngine { get; set; }
        public string VehicleTransmission { get; set; }
    }
}
