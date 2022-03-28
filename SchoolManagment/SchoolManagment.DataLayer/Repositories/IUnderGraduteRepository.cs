using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.DataLayer
{
    public interface IUnderGraduteRepository : IBaseRepository<UnderGradute>
    {
        string GetNameById(int ? id);

        int GetIdByName(string UnderGraduteName);

        IEnumerable<IUnderGradutesViewModel> FillUnderGradutesViewModel();
    }
}
