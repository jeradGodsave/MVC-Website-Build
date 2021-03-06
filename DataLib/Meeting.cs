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
    
    public partial class Meeting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meeting()
        {
            this.MeetingStudentAttendances = new HashSet<MeetingStudentAttendance>();
            this.MeetingStaffAttendances = new HashSet<MeetingStaffAttendance>();
            this.MeetingVolunteerAttendances = new HashSet<MeetingVolunteerAttendance>();
        }
    
        public decimal Meeting_NUM { get; set; }
        public System.DateTime Meeting_Start { get; set; }
        public System.DateTime Meeting_End { get; set; }
        public string Meeting_Type { get; set; }
        public string Location_Name { get; set; }
    
        public virtual Location Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeetingStudentAttendance> MeetingStudentAttendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeetingStaffAttendance> MeetingStaffAttendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeetingVolunteerAttendance> MeetingVolunteerAttendances { get; set; }
    }
}
