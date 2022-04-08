using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.Bussiness
{
    public class DayAlternateHandler : IDayAlternateHandler
    {
        private IEnumerable<DayAlternate> _dayAlternates; 

        public IEnumerable<DayAlternate> GetDayAlternates()
        {
            using (UnitOfWork db=new UnitOfWork(new SchoolManagmentEntities()))
            {
                _dayAlternates = db.DayAlternateRepository.Get();
            }
            return _dayAlternates;
        }

        public IEnumerable<DayAlternate> GetDayAlternates(int TypeDay)
        {
            using (UnitOfWork db=new UnitOfWork(new SchoolManagmentEntities()))
            {
                _dayAlternates = db.DayAlternateRepository.Get(ta => ta.FkTypeDay == TypeDay);
            }
            return _dayAlternates;
        }
        public void Dispose()
        {
            if (_dayAlternates!=null)
            {
                _dayAlternates = null;
            }
        }
    }
}
