﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdelanteRedo.Models
{
    using System;
    using System.Collections.Generic;

    public partial class StudentParent
    {
        public int StudentParentID { get; set; }
        public int StudentID { get; set; }
        public int ParentID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Parent Parent { get; set; }
    }
}
