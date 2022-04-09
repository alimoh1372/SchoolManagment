using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class TeacherTeachsLessonsOfNewYearInUnGradesViewModel : ITeacherTeachsLessonsOfNewYearInUnGradesViewModel
    {
        public int PkLessonOfFieldOfNewYearInUnGradeId { get; set; }
        public int FkLessonId { get; set; }
        public string FkLessonIdString { get; set; }
        public int PkFieldsOfNewYearInUnGradutesId { get; set; }
        public int FkFieldId { get; set; }
        public string FkFieldIdString { get; set; }
        public int PkUnderGraduteInAcademyYearId { get; set; }
        public int AcademyYearId { get; set; }
        public int AcademyYearString { get; set; }
        public int FkUnGraduteId { get; set; }
        public string FkUnGraduteIdString { get; set; }
    }
}
