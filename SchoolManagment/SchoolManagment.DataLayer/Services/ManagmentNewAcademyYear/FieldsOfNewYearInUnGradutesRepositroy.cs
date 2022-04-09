using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
    public class FieldsOfNewYearInUnGradutesRepositroy : BaseRepository<FieldsOfNewYearInUnGradute>, IFieldsOfNewYearInUnGradutesRepository
    {
        public FieldsOfNewYearInUnGradutesRepositroy(SchoolManagmentEntities db):base(db)
        {

        }

        public int GetIdByFieldIdAndUnGradutesInNewYearId(int fieldId, int UnGradutesInNewYearId)
        {
            if (_dbSet.Any(fiu=>fiu.FkFieldId==fieldId &&fiu.FkUnGradutesInNewYearId== UnGradutesInNewYearId))
            {
                return _dbSet.First(fiu => fiu.FkFieldId == fieldId && fiu.FkUnGradutesInNewYearId == UnGradutesInNewYearId).PkFieldsOfNewYearInUnGradutesId;
            }
            else
            {
                return 0;
            }
        }
    }
}
