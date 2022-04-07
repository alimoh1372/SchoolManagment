using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    public interface ITeacherCanTeachLessonRepository : IBaseRepository<TeacherCanTeachLesson>
    {
        bool Insert(int LessonId, int teacherId);
        int GetIdByLessonIdAndTeacherId(int lessonId, int teacherId);
        
    }
}
