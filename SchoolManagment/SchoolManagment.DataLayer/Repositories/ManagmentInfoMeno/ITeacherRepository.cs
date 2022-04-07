using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.ViewModel;

namespace SchoolManagment.DataLayer
{
  public  interface ITeacherRepository :IBaseRepository<Teacher>
    {
       IEnumerable<LessonViewModel> FillLessonsOfTeacherThatCantTeach(int teacherId);
    }
}
