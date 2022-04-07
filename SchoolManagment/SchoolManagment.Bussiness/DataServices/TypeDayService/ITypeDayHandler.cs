using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.DataLayer;

namespace SchoolManagment.Bussiness
{
   public interface ITypeDayHandler
    {
        IEnumerable<TypeDay> GetTypeDays();
    }
}
