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
    
    public partial class WorkOrderInstruction
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Quantity { get; set; }
        public string Description { get; set; }
    
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
