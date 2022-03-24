using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private SchoolManagmentEntities _db;
        public UnitOfWork(SchoolManagmentEntities db)
        {
            _db = db;
        }

        private IGradeRepository _gradeRepository;
        public IGradeRepository GradeRepository
        {
            get
            {
                if (_gradeRepository == null)
                {
                    _gradeRepository = new GradeRepository(_db);
                }
                return _gradeRepository;
            }
        }

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
