using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
   public class TeacherTeachsLessonsOfNewYearInUnGradesRepository:BaseRepository<TeacherTeachsLessonsOfNewYearInUnGrade>, ITeacherTeachsLessonsOfNewYearInUnGradesRepository
    {
        public TeacherTeachsLessonsOfNewYearInUnGradesRepository(SchoolManagmentEntities db):base(db)
        {

        }
    }
}
