using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
    interface IUnitOfWork : IDisposable
    {
        IGradeRepository GradeRepository { get; }
        IUnderGraduteRepository UnderGraduteRepository { get; }
        IAcademyYearRepository AcademyYearRepository { get; }
        IFieldRepository FieldRepository { get; }
        ILessonRepository LessonRepository { get; }
        IStudentRepository StudentRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        IClassRepository ClassRepository { get; }
        ITeacherCanTeachLessonRepository TeacherCanTeachLessonRepository{get;}

        int Save();

       
    }
}
