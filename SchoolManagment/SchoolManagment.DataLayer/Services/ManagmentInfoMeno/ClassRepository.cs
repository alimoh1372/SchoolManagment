using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
    public class ClassRepository : BaseRepository<Class>, IClassRepository
    {
        public ClassRepository(SchoolManagmentEntities db):base(db)
        {

        }
    }
}
