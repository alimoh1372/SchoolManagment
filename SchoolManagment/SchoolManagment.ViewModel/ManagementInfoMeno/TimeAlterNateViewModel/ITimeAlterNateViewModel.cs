using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    interface ITimeAlterNateViewModel
    {
        int PkTimeId { get; set; }
        string timeFromToTime { get; set; } 
    }
}
