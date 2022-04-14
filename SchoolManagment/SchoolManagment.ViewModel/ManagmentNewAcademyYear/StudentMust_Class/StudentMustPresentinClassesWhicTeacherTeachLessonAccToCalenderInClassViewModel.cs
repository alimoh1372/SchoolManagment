using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel : TeacherTeachLessonAccToCalenderInClassViewModel, IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel
    {
        public int PkTeacherTeachLessonAccToCalInClassId { get ; set ; }
        public int FkClassId { get ; set ; }
        public string FkClassIdString { get ; set ; }

    }
}
