using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceForms.Classes
{
    class CustomerWithVehicleDTO
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Post { get; set; }
        public string Phone { get; set; }

        public long VehicleId { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string IdentificationNumber { get; set; }
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string MKBCode { get; set; }
        public string GKBCode { get; set; }
        public int Mileage { get; set; }
        public int ModelYear { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
    }
}
