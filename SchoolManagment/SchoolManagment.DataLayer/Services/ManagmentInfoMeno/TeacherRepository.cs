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

        public IEnumerable<LessonViewModel> FillLessonsOfTeacherThatCantTeach(int teacherId)
        {
            IEnumerable<LessonViewModel> lessonViewModels;
           lessonViewModels= _db.TeacherCanTeachLessons.Where(tc => tc.FkTeacherId == teacherId).Include(tc => tc.Lesson).Include(tc=>tc.Lesson.Field).Select(tc => new LessonViewModel()
            {
                PKLessonId=tc.FkLessonId,
                LessonName=tc.Lesson.LessonName,
                LessonUnits=tc.Lesson.LessonUnits,
                FkFileldId=tc.Lesson.FkFileldId,
                FkFileldIdString=tc.Lesson.Field.FieldName
                
            });
            return lessonViewModels;
        }
    }
}
