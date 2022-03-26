using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    public class FieldRepository:BaseRepository<Field>,IFieldRepository
    {
        public  FieldRepository(SchoolManagmentEntities db) : base(db)
        {

        }
    }
}
