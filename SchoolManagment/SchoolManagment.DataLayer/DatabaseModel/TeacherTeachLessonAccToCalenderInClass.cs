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
    
    public partial class TeacherTeachLessonAccToCalenderInClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeacherTeachLessonAccToCalenderInClass()
        {
            this.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClasses = new HashSet<StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass>();
        }
    
        public int PkTeacherTeachLessonAccToCalInClassId { get; set; }
        public int FkTeacherTeachLessonAccToCalId { get; set; }
        public int FkClassId { get; set; }
    
        public virtual Class Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass> StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClasses { get; set; }
        public virtual TeacherTeachLessonAccordingToCalender TeacherTeachLessonAccordingToCalender { get; set; }
    }
}
