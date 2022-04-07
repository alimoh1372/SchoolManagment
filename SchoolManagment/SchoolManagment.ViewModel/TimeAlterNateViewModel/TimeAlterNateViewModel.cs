using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class TimeAlterNateViewModel : ITimeAlterNateViewModel
    {
        public int PkTimeId { get ; set ; }
        public string timeFromToTime { get ; set; }
    }
}
