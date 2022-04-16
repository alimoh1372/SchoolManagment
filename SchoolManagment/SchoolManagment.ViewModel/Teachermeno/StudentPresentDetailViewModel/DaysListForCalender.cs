using SchoolManagment.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolManagment.ViewModel
{
    public class DaysListForCalender : IDaysListForCalender
    {
        public DateTime dateTime { get ; set ; }
        public string persianDate => dateTime.DateTimeToPersianStringShortDate();
    }
}
