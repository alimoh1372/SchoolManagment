using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.Bussiness
{
    public class TypeDayHandler : ITypeDayHandler,IDisposable
    {

        IEnumerable<TypeDay> typeDays;
        public IEnumerable<TypeDay> GetTypeDays()
        {
            using (UnitOfWork db=new UnitOfWork(new SchoolManagmentEntities()))
            {
                
                typeDays = db.TypeDayRepository.Get();
                return typeDays;
            }
        }
        public void Dispose()
        {
            if (typeDays!=null)
            {
                typeDays = null;
            }
        }
    }
}
