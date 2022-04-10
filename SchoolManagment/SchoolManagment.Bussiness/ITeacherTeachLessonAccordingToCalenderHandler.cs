using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.Bussiness
{
   public interface ITeacherTeachLessonAccordingToCalenderHandler:IDisposable
    {
       
            IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> FillTeacherLessonCalenderViewModel(Expression<Func<TeacherTeachLessonAccordingToCalender,bool>> where=null);
        
    }
}
