//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GaptWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timetable
    {
        public int ID { get; set; }
        public System.TimeSpan tTime { get; set; }
        public string UnitID { get; set; }
        public string tDate { get; set; }
        public int LocationID { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    
        public virtual StudyUnit StudyUnit { get; set; }
        public virtual Location Location { get; set; }
    }
}
