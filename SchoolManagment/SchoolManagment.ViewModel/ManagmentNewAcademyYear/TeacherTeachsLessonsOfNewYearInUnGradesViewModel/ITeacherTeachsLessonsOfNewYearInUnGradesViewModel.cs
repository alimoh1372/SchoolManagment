using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public interface ITeacherTeachsLessonsOfNewYearInUnGradesViewModel
    {
        int PkLessonOfFieldOfNewYearInUnGradeId { get; set; }
        int FkLessonId { get; set; }

        string FkLessonIdString { get; set; }

        int PkFieldsOfNewYearInUnGradutesId { get; set; }

        int FkFieldId { get; set; }

        string FkFieldIdString { get; set; }

        int PkUnderGraduteInAcademyYearId { get; set; }

        int AcademyYearId { get; set; }

        string AcademyYearString { get; set; }

        int FkUnGraduteId { get; set; }

        string FkUnGraduteIdString { get; set; }


    }
}
