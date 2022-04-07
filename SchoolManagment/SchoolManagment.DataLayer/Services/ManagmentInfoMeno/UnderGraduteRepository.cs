using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using System.Data.Entity;

namespace SchoolManagment.DataLayer
{
    public class UnderGraduteRepository : BaseRepository<UnderGradute>, IUnderGraduteRepository
    {
        public UnderGraduteRepository(SchoolManagmentEntities db) : base(db)
        {

        }
        //Fill The data of UnderGraudutes with relation Data
        public IEnumerable<IUnderGradutesViewModel> FillUnderGradutesViewModel()
        {
            IEnumerable<IUnderGradutesViewModel> underGradutesViewModels;
            var context = _dbSet.Include(un => un.Grade).AsEnumerable().Select(un => new UnderGradutesViewModel() {
                PkUnGraduteId = un.PkUnGraduteId,
                UnGraduteName = un.UnGraduteName + " " + un.Grade.GradeName,
                FkGradeId = un.FkGradeId,
                FkGradeIdString = un.Grade.GradeName,
                FkUnGradutePrequestis = un.FkUnGradutePrequestis,
                FkUnGradutePrequestisString=GetNameById(un.FkUnGradutePrequestis)
            });
            underGradutesViewModels = context;
            return underGradutesViewModels;
            
        }
        //Get The Id of UnderGradute By Id
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
        //Get The Name Of UnderGradute by Id
        public virtual string GetNameById(  int ?  id)
        {
            if (id == 0 || id.ToString() == string.Empty)
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
