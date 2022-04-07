using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    public class AcademyYearRepository : BaseRepository<AcademyYear>,IAcademyYearRepository
    {
        public AcademyYearRepository(SchoolManagmentEntities db):base(db)
        {

        }
    }
}
