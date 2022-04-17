using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    internal class ScoreOfStudentsForLessonViewModel : LessonViewModel, IScoreOfStudentsForLessonViewModel
    {
        public decimal? ScoreOfLesson { get; set; }
        public int FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId { get; set; }
        public int PkScoreOfStudentsForLessons { get; set; }
        public string IsPassedLesson
        {
            get
            {
                string _isPassed = "عدم قبولی";
                if (ScoreOfLesson>=10)
                {
                    _isPassed = "قبول شده";
                }
                return _isPassed;
            }
        }
    }
}