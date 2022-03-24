using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.DataLayer
{
    //public class CountryRepository : GenericRepository<Country>
    //{
    //    public CountryRepository(MainContext context) : base(context) { }

    //    public virtual Country GetByCode(string code)
    //    {
    //        return dbSet.Where(c => c.Code == code).First();
    //    }
    //}
    public class GradeRepository : BaseRepository<Grade>,IGradeRepository
    {
        public GradeRepository(SchoolManagmentEntities db):base(db)
        {

        }

        public virtual string GetNameById(object id)
        {
           return _db.Grades.Find(id).GradeName;
        }


    }
}
