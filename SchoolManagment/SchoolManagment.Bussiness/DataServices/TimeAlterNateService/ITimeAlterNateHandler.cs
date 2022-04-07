using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public interface ITimeAlterNateHandler : IDisposable
    {
        IEnumerable<TimeAlterNate> GetTimeAlterNates();
        IEnumerable<TimeAlterNateViewModel> GetAndFillViewModel();
    }
}
