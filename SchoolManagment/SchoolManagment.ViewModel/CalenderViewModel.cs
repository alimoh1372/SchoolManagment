using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class CalenderViewModel : ICalenderViewModel
    {
        public int CalenderId { get ; set ; }
        public string CalenderName { get ; set ; }
        public string CalenderDescription { get; set ; }
        public int FkDayAlterNate { get ; set ; }
        public string FkDayAlterNateString { get ; set; }
        public int FkTimeAlterNateId { get ; set ; }
        public string FkTimeAlterNateIdString { get ; set ; }
    }
}
