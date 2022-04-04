using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SchoolManagment.DataLayer
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        public IEnumerable<TeacherCanTeachLessonViewModel> FillLessonsThatTeacherCanTeach(int teacherId)
        {
            IEnumerable<TeacherCanTeachLessonViewModel> teacherCanTeachLessonViewModels;
           teacherCanTeachLessonViewModels= _db.TeacherCanTeachLessons.Include(tcan => tcan.Lesson).Include(le=>le.Lesson.Field).Where(tcan => tcan.FkTeacherId == teacherId).Select(tcan=>new TeacherCanTeachLessonViewModel() {
               PKLessonId1=tcan.FkLessonId,
               lessonString=tcan.Lesson.LessonName+"-"+tcan.Lesson.Field.FieldName
            });
            return teacherCanTeachLessonViewModels;
        }
    }
}
