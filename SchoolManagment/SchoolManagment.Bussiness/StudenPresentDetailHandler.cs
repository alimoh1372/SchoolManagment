using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public class StudenPresentDetailHandler : IStudenPresentDetailHandler
    {
        public IList<DaysListForCalender> GetDaysListViewModel(DataGridView dgvNewAcademyYearAllLessons)
        {
            IList<DaysListForCalender> daysListForCalenders;
            int calenderId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkCalenderId"].Value);
            int academyYearId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearId"].Value);
            using (CalenderHandler calenderHandler =new CalenderHandler())
            {
                daysListForCalenders = calenderHandler.GenerateDayList(calenderId, academyYearId);
            }
            return daysListForCalenders;
        }
        public void Dispose()
        {
           
        }
    }
}
