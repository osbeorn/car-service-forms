//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarServiceForms.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.WorkOrders = new HashSet<WorkOrder>();
        }
    
        public long Id { get; set; }
        public string RegistrationNumber { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public string IdentificationNumber { get; set; }
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string MKBCode { get; set; }
        public string GKBCode { get; set; }
        public int Mileage { get; set; }
        public int ModelYear { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public bool Active { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
