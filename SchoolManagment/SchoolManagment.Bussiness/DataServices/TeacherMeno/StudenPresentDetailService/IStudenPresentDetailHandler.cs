using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
  public  interface IStudenPresentDetailHandler:IDisposable
    {
        IList<DaysListForCalender> GetDaysListViewModel(DataGridView dgvNewAcademyYearAllLessons);
    }
}
