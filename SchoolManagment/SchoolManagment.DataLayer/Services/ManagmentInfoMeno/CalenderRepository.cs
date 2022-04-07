using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SchoolManagment.DataLayer
{
    public class CalenderRepository : BaseRepository<Calender>, ICalenderRepository
    {
        public CalenderRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        public IEnumerable<Calender> GetWithIncludes()
        {
            IEnumerable<Calender> _calenders;
            _calenders = _dbSet.Include(c => c.TimeAlterNate).Include(c => c.DayAlternate).Include(c => c.DayAlternate.TypeDay);
            return _calenders;
        }
    }
}
