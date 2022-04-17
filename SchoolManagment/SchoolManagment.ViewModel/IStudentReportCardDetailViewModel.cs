using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
   public interface IScoreOfStudentsForLessonViewModel:ILessonViewModel
    {
        decimal? ScoreOfLesson { get; set; }
        string IsPassedLesson { get;  }
        int FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId { get; set; }
        int PkScoreOfStudentsForLessons { get; set; }
        int PKLessonId { get; set; }

        string LessonName { get; set; }

        int LessonUnits { get; set; }

        int? FkFileldId { get; set; }

        string FkFileldIdString { get; set; }
    }
}
