//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HossamAndHoda2021.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderTBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderTBL()
        {
            this.OrderDetailTBL = new HashSet<OrderDetailTBL>();
        }
    
        public int OrderID { get; set; }
        public string OrderAutoCode { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string UserGovernorate { get; set; }
        public string UserCity { get; set; }
        public string UserAddress { get; set; }
        public string UserIP { get; set; }
        public Nullable<System.DateTime> DateOfMaking { get; set; }
        public Nullable<int> TotalPrice { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetailTBL> OrderDetailTBL { get; set; }
    }
}