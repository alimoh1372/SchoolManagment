using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
    class ScoreOfStudentsForLessonsRepository:BaseRepository<ScoreOfStudentsForLesson>,IScoreOfStudentsForLessonsRepository
    {
        public ScoreOfStudentsForLessonsRepository(SchoolManagmentEntities db):base(db)
        {

        }
    }
}
