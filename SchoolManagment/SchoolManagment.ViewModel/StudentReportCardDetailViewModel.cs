using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class StudentReportCardDetailViewModel : LessonViewModel, IScoreOfStudentsForLessonViewModel
    {
        public int FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId { get; set; }
        public int PkScoreOfStudentsForLessons { get; set; }
        public decimal? ScoreOfLesson { get; set; }

        public string IsPassedLesson
        {
            get
            {
                string isPassed = "عدم قبولی";
                if (ScoreOfLesson>=10)
                {
                    isPassed = "قبول در درس";
                }
                return isPassed;
            }
        }

        
    }
}
