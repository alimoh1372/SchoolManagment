using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
   public interface IUnderGradutesInNewAcademyYearRepository:IBaseRepository<UnderGradutesInNewAcademyYear>
    {
        int GetIdByAcademyAndUngradutes(int AcademyId, int UndgraduteId);
    }
}
