//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parent()
        {
            this.Students = new HashSet<Student>();
        }
    
        public string Parent_NUM { get; set; }
        public string Parent_FirstName { get; set; }
        public string Parent_LastName { get; set; }
        public string Parent_Address { get; set; }
        public string Parent_City { get; set; }
        public string Parent_State { get; set; }
        public string Parent_Zip { get; set; }
        public string Parent_HomeTele { get; set; }
        public string Parent_CellPhone { get; set; }
        public string Parent_Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
