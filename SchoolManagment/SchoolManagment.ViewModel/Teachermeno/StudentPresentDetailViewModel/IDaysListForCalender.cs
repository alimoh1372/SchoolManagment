using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public interface IDaysListForCalender
    {
        DateTime dateTime { get; set; }
        string persianDate { get;}
    }
}
