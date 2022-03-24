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
    public class GradeRepository : BaseRepository<Grade>, IGradeRepository
    {
        public GradeRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        public int GetIdByName(string gradeName)
        {
            if (gradeName== "بدون پیشنیاز")
            {
                return 0;
            }
            else
            {
                return _dbSet.Single(g => g.GradeName == gradeName).PkGradeId;
            }
        }

        public virtual string GetNameById(object id)
        {
            if (Convert.ToInt32(id)==0 || id.ToString()==string.Empty)
            {
                return "بدون پیشنیاز";
            }
            else
            {
                return _db.Grades.Find(id).GradeName;
            }

        }


    }
}
