using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class FieldsOfNewYearInUnGradutesViewModel : IFieldsOfNewYearInUnGradutesViewModel
    {
        public int FkFieldsOfNewYearInUnGradutesId { get ; set ; }
        public string FkFieldsOfNewYearInUnGradutesIdString { get ; set ; }
        public int AcademyYearId { get ; set ; }
        public string AcademyYearString { get ; set ; }
        public int FkUnderGraduteInAcademyYearId { get ; set ; }
        public string FkUnderGraduteInAcademyYearIdString { get ; set ; }
    }
}
