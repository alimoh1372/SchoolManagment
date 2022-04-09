using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
   public interface IFieldsOfNewYearInUnGradutesRepository:IBaseRepository<FieldsOfNewYearInUnGradute>
    {
        int GetIdByFieldIdAndUnGradutesInNewYearId(int fieldId, int UnGradutesInNewYearId);
    }
}
