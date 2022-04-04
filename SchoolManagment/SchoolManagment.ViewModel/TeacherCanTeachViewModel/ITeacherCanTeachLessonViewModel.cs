using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public interface ITeacherCanTeachLessonViewModel
    {
        int PKLessonId1 { get; set; }

        string lessonString { get; set; }
    }
}
