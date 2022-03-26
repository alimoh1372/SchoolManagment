using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.DataLayer
{
    public class FieldRepository : BaseRepository<Field>, IFieldRepository
    {
        public FieldRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        public IEnumerable<IFieldViewModel> FillFieldViewModel()
        {

            IEnumerable<IFieldViewModel> fieldViewModels;
            var context = _db.Fields.Include(f=>f.UnderGradute).Include(fUn=>fUn.UnderGradute.Grade);
            fieldViewModels = context.Select(f => new FieldViewModel()
            {
                PkFieldId = f.PkFieldId,
                FieldName = f.FieldName,
                FKUnGraduteId = f.FKUnGraduteId,
                FKUnGraduteIdString = f.UnderGradute.UnGraduteName + " " +f.UnderGradute.Grade.GradeName 
            });
            return fieldViewModels;

        }
    }
}
