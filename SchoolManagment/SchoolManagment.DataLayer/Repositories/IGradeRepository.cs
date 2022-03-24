using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
namespace SchoolManagment.DataLayer
{
    public interface IGradeRepository:IBaseRepository <Grade>
    {

        string GetNameById(object id);
        int GetIdByName(string gradeName);
    }
}
