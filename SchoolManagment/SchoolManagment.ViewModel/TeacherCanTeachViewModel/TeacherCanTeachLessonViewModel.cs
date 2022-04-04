using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class TeacherCanTeachLessonViewModel : ITeacherCanTeachLessonViewModel
    {
        public int PKLessonId1 { get ; set; }
        public string lessonString { get ; set ; }
    }
}
