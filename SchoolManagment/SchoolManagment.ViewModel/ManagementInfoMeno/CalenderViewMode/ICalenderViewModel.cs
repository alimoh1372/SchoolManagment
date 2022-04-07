using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
   public interface ICalenderViewModel
    {
        int CalenderId { get; set; }
        string CalenderName { get; set; }
        string CalenderDescription { get; set; }

        int FkDayAlterNate { get; set; }

        string FkDayAlterNateString { get; set; }

        int FkTimeAlterNateId { get; set; }
         
        string FkTimeAlterNateIdString { get; set; }
    }
}
