using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
   public class TeacherTeachLessonAccordingToCalenderRepository:BaseRepository<TeacherTeachLessonAccordingToCalender>,ITeacherTeachLessonAccordingToCalenderRepository
    {
        public TeacherTeachLessonAccordingToCalenderRepository(SchoolManagmentEntities db):base(db)
        {

        }

    }
}
