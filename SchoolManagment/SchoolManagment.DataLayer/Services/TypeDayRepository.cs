using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
  public  class TypeDayRepository:BaseRepository<TypeDay>,ITypeDayRepository
    {
        public TypeDayRepository(SchoolManagmentEntities db) : base(db)
        {

        }
    }
}
