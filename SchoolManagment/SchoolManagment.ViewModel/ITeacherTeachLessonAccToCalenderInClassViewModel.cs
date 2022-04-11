using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public interface ITeacherTeachLessonAccToCalenderInClassViewModel : ITeacherTeachLessonAccordingToCalenderViewModel
    {
        int PKTeacherTeachLessonAccordingToCalender { get; set; }

        int FkCalenderId { get; set; }
        string FkCalenderIdString { get; set; }
        int TeacherTeachLessonId { get; set; }
        int FkTeacherId { get; set; }
        string FkTeacherIdString { get; set; }
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
