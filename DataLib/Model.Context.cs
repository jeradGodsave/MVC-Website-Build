﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class goyals420_troutEntities : DbContext
    {
        public goyals420_troutEntities()
            : base("name=goyals420_troutEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Donor> Donors { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MeetingStaffAttendance> MeetingStaffAttendances { get; set; }
        public virtual DbSet<MeetingStudentAttendance> MeetingStudentAttendances { get; set; }
        public virtual DbSet<MeetingVolunteerAttendance> MeetingVolunteerAttendances { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Volunteer> Volunteers { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
    }
}
