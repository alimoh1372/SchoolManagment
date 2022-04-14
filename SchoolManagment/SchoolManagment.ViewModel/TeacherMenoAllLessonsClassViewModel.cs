using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class TeacherMenoAllLessonsClassViewModel : StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel , ITeacherMenoAllLessonsClassViewModel
    {
        public int PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId { get ; set ; }
    }
}
