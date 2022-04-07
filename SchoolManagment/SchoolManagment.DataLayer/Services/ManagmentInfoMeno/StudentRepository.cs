using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SchoolManagment.DataLayer
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolManagmentEntities db) : base(db)
        {

        }

        public IEnumerable<IStudentViewModel> FillStudentViewModel()
        {
            IQueryable<IStudentViewModel> studentViewModels;
            studentViewModels = _dbSet.Include(st => st.Field).Include(st => st.UnderGradute).Include(st => st.UnderGradute.Grade).Select(st => new StudentViewModel()
            {
                StudentId = st.StudentId,
                StudentName = st.StudentName,
                StudentNationCode = st.StudentNationCode,
                FkStudentFieldId = st.FkStudentFieldId,
                FkStudentFieldIdString = st.Field.FieldName,
                FkLastPassedUgraduteId = (st.FkLastPassedUgraduteId == 0 || st.FkLastPassedUgraduteId == null) ? 0 : st.FkLastPassedUgraduteId,
                FkLastPassedUgraduteIdString = (st.FkLastPassedUgraduteId == 0 || st.FkLastPassedUgraduteId == null) ? "شروع به تحصیل" : st.UnderGradute.UnGraduteName + " " + st.UnderGradute.Grade.GradeName
            });
            return studentViewModels;

        }
    }
}
