using CarServiceForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Classes
{
    class CarServiceFormReportDTO
    {
        public string WorkOrderNumber { get; set; }
        public string VehicleTypeCode { get; set; }
        public string VehicleType { get; set; }
        public string VehicleIdentificationNumber { get; set; }
        public string VehicleMKBCode { get; set; }
        public string VehicleGKBCode { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public DateTime VehicleRegistrationDate { get; set; }
        public string VehicleMileage { get; set; }
        public string VehicleModelYear { get; set; }

        public ServiceType ServiceType { get; set; }
    }
}
