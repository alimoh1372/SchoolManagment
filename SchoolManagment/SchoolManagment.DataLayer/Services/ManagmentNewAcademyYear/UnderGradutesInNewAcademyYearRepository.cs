using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
    public class UnderGradutesInNewAcademyYearRepository : BaseRepository<UnderGradutesInNewAcademyYear>, IUnderGradutesInNewAcademyYearRepository
    {
        public UnderGradutesInNewAcademyYearRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        public int GetIdByAcademyAndUngradutes(int AcademyId, int UndgraduteId)
        {
            int Id = -1;
            Id = _dbSet.First(una => una.FkAcademyYearId == AcademyId && una.FkUnGraduteId == UndgraduteId).PkUnderGraduteInAcademyYearId;
            return Id;
        }
    }
}
