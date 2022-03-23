using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    public class GradeRepository : IGradeRepository
    {
        private SchoolManagmentEntities _db;
        private DbSet<Grade>_dbSet;
            
        public GradeRepository(SchoolManagmentEntities db)
        {
            _db = db;
            _dbSet = db.Set<Grade>();
        }
        public string GetNameById(object id)
        {
          return  _dbSet.Find(id).GradeName;
        }
    }
}
