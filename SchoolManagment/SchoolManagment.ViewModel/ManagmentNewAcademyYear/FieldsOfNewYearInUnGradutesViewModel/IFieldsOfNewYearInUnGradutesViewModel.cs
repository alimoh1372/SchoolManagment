using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
   public interface IFieldsOfNewYearInUnGradutesViewModel
    {
        int FkFieldsOfNewYearInUnGradutesId { get; set; }
        string FkFieldsOfNewYearInUnGradutesIdString { get; set; }

        int AcademyYearId { get; set; }

        string AcademyYearString { get; set; }
         int FkUnderGraduteInAcademyYearId { get; set; }

        string FkUnderGraduteInAcademyYearIdString { get; set; }
    }
}
