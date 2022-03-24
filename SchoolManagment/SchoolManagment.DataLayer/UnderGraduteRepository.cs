using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
namespace SchoolManagment.DataLayer
{
    public class UnderGraduteRepository : BaseRepository<UnderGradute>, IUnderGraduteRepository
    {
        public UnderGraduteRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        public virtual int GetIdByName(string UnderGraduteName)
        {
            if (UnderGraduteName == "بدون پیشنیاز")
            {
                return 0;
            }
            else
            {
                return _dbSet.First(u => u.UnGraduteName == UnderGraduteName).PkUnGraduteId;
            }

        }

        public virtual string GetNameById(int id)
        {
            if (Convert.ToInt32(id) == 0 || id.ToString() == string.Empty)
            {
                return "بدون پیشنیاز";
            }
            else
            {
                return _dbSet.Find(id).UnGraduteName;

            }
        }
    }
}
