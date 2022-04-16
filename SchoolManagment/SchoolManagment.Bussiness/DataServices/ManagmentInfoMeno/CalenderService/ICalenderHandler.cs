using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
  public  interface ICalenderHandler:IDisposable
    {
        IEnumerable<Calender> GetCalenders();
        IEnumerable<Calender> GetCalendersWithIncludes();
        IEnumerable<CalenderViewModel> GetCalenderAndFillViewModel();
        int InsertCalenderInfo(ComboBox txtDayAlternate,ComboBox txtTimeAlternate,TextBox ctxtCalenderName,TextBox txtCalenderDescription);
        int DeleteCalender(DataGridViewRow dataGridViewRow);
        int UpdateCalender(DataGridViewRow dataGridViewRow, ComboBox txtDayAlternate, ComboBox txtTimeAlternate, TextBox ctxtCalenderName, TextBox txtCalenderDescription);
        List<DaysListForCalender> GenerateDayList(int calenderId, int academyYearId);
    }
}
