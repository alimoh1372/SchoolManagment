using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class TeacherTeachLessonAccordingToCalenderViewModel : TeacherTeachsLessonsOfNewYearInUnGradesViewModel, ITeacherTeachLessonAccordingToCalenderViewModel
    {
 
        public int TeacherTeachLessonId { get; set; }
        public int FkTeacherId { get; set; }
        public string FkTeacherIdString { get ; set ; }
        
    }
}
