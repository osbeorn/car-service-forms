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
    
    public partial class ServiceItemGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceItemGroup()
        {
            this.ServiceItems = new HashSet<ServiceItem>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceItem> ServiceItems { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
