using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class TeacherTeachLessonAccToCalenderInClassViewModel : TeacherTeachLessonAccordingToCalenderViewModel, ITeacherTeachLessonAccToCalenderInClassViewModel
    {
        public int PKTeacherTeachLessonAccordingToCalender { get ; set ; }
        public int FkCalenderId { get ; set  ; }
        public string FkCalenderIdString { get ; set ; }
    }
}
