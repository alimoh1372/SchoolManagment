using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private SchoolManagmentEntities _db = new SchoolManagmentEntities();
        public void Dispose()
        {
            _db.Dispose();
        }

        public int Save()
        {
            return _db.SaveChanges();
        }
    }
}
