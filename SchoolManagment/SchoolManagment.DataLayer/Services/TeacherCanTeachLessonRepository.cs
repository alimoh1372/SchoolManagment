using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
namespace SchoolManagment.DataLayer
{
   public class TeacherCanTeachLessonRepository:BaseRepository<TeacherCanTeachLesson>,ITeacherCanTeachLessonRepository
    {
        public TeacherCanTeachLessonRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        
        public bool Insert(int LessonId, int teacherId)
        {
            if (_dbSet.Any(tc => tc.FkLessonId == LessonId && tc.FkTeacherId == teacherId))
            {
                return false;
            }
            else
            {
                TeacherCanTeachLesson teacherCanTeachLesson = new TeacherCanTeachLesson()
                {
                    FkLessonId = LessonId,
                    FkTeacherId = teacherId
                };
                Insert(teacherCanTeachLesson);
                return true;
            }
            
        }
        public int GetIdByLessonIdAndTeacherId(int lessonId, int teacherId)
        {
            int tcID = _dbSet.First(tc => tc.FkLessonId == lessonId && tc.FkTeacherId == teacherId).PkTeacherCanTeachLessons;
            if (tcID!=0)
            {
                return tcID;
            }
            else
            {
                return 0;
            }
        }

    }
}
