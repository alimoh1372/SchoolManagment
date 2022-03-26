using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
    interface IUnitOfWork:IDisposable
    {
        IGradeRepository GradeRepository { get; }
        IUnderGraduteRepository UnderGraduteRepository { get; }
        IAcademyYearRepository AcademyYearRepository { get; }
        IFieldRepository FieldRepository { get; }
        int Save();

       
    }
}
