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
        private IUnderGraduteRepository _underGraduteRepository;
        public IUnderGraduteRepository UnderGraduteRepository
        {
            get
            {
                if (_underGraduteRepository == null)
                {
                    _underGraduteRepository = new UnderGraduteRepository(_db);
                }
                return _underGraduteRepository;
            }
        }

        private IAcademyYearRepository _academyYearRepository;

        public IAcademyYearRepository AcademyYearRepository
        {
            get
            {
                if (_academyYearRepository == null)
                {
                    _academyYearRepository = new AcademyYearRepository(_db);
                }
                return _academyYearRepository;
            }
        }

        private IFieldRepository _fieldRepository;

        public IFieldRepository FieldRepository
        {
            get
            {
                if (_fieldRepository == null)
                {
                    _fieldRepository = new FieldRepository(_db);
                }
                return _fieldRepository;
            }
        }

        private ILessonRepository _lessonRepository { get; set; }
        public ILessonRepository LessonRepository
        {
            get
            {
                if (_lessonRepository == null)
                {
                    _lessonRepository = new LessonRepository(_db);
                }
                return _lessonRepository;
            }
        }
        private IStudentRepository _studentRepository;
        public IStudentRepository StudentRepository
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new StudentRepository(_db);
                }
                return _studentRepository;
            }
        }
        private ITeacherRepository _teacherRepository;

        public ITeacherRepository TeacherRepository
        {
            get
            {
                if (_teacherRepository==null)
                {
                    _teacherRepository = new TeacherRepository(_db);
                }
                return _teacherRepository;
            }
        }

        private IClassRepository _classRepository;

        public IClassRepository ClassRepository
        {
            get
            {
                if (_classRepository==null)
                {
                    _classRepository = new ClassRepository(_db);
                }
                return _classRepository;
            }
        }

        private ITeacherCanTeachLessonRepository _teacherCanTeachLessonRepository;

        public ITeacherCanTeachLessonRepository TeacherCanTeachLessonRepository
        {
            get
            {
                if (_teacherCanTeachLessonRepository==null)
                {
                    _teacherCanTeachLessonRepository = new TeacherCanTeachLessonRepository(_db);
                }
                return _teacherCanTeachLessonRepository;
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
