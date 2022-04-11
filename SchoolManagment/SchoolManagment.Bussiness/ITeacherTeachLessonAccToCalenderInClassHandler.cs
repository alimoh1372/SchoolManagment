using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public interface ITeacherTeachLessonAccToCalenderInClassHandler
    {
        IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> FillLessonCalenderViewModel();
    }
}
