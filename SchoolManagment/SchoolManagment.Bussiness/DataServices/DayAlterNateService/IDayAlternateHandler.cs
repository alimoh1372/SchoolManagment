using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.Bussiness
{
    public interface IDayAlternateHandler:IDisposable
    {
        IEnumerable<DayAlternate> GetDayAlternates();
        IEnumerable<DayAlternate> GetDayAlternates(int TypeDay);
    }
}
