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
    
    public partial class AcademyYear
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AcademyYear()
        {
            this.UnderGradutesInNewAcademyYears = new HashSet<UnderGradutesInNewAcademyYear>();
        }
    
        public int AcademyYearId { get; set; }
        public string AcademyYearName { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int NumberOfDaysOfYear { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnderGradutesInNewAcademyYear> UnderGradutesInNewAcademyYears { get; set; }
    }
}
