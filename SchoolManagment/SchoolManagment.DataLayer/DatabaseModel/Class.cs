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
    
    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            this.TeacherTeachLessonAccToCalenderInClasses = new HashSet<TeacherTeachLessonAccToCalenderInClass>();
        }
    
        public int PkClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassLocation { get; set; }
        public int ClassCapacity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherTeachLessonAccToCalenderInClass> TeacherTeachLessonAccToCalenderInClasses { get; set; }
    }
}
