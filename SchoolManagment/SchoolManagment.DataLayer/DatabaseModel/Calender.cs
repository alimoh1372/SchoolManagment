//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagment.DataLayer.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calender
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calender()
        {
            this.Days = new HashSet<Day>();
            this.TeacherTeachLessonAccordingToCalenders = new HashSet<TeacherTeachLessonAccordingToCalender>();
        }
    
        public int CalenderId { get; set; }
        public string CalenderName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Day> Days { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherTeachLessonAccordingToCalender> TeacherTeachLessonAccordingToCalenders { get; set; }
    }
}
