using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.DataLayer
{
    public class LessonRepository : BaseRepository<Lesson>, ILessonRepository
    {
        public LessonRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        public IEnumerable<LessonViewModel> FillViewModel()
        {
            IEnumerable<LessonViewModel> lessonViewModels;
           lessonViewModels= GetIncludeEntity(c => c.Field).Select(le => new LessonViewModel()
            {
                PKLessonId = le.PKLessonId,
                LessonName = le.LessonName,
                LessonUnits = le.LessonUnits,
                FkFileldId = le.FkFileldId,
                FkFileldIdString = le.Field.FieldName
            });
            return lessonViewModels;
        }
    }
}
