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
                if (_teacherRepository == null)
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
                if (_classRepository == null)
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
                if (_teacherCanTeachLessonRepository == null)
                {
                    _teacherCanTeachLessonRepository = new TeacherCanTeachLessonRepository(_db);
                }
                return _teacherCanTeachLessonRepository;
            }
        }

        private ITypeDayRepository _typeDayRepository;
        public ITypeDayRepository TypeDayRepository
        {
            get
            {
                if (_typeDayRepository == null)
                {
                    _typeDayRepository = new TypeDayRepository(_db);
                }
                return _typeDayRepository;
            }
        }
        private ITimeAlterNateRepository _timeAlterNateRepository;

        public ITimeAlterNateRepository TimeAlterNateRepository
        {
            get
            {
                if (_timeAlterNateRepository == null)
                {
                    _timeAlterNateRepository = new TimeAlterNateRepository(_db);
                }
                return _timeAlterNateRepository;
            }
        }

        private IDayAlternateRepository _dayAlternateRepository;
        public IDayAlternateRepository DayAlternateRepository
        {
            get
            {
                if (_dayAlternateRepository == null)
                {
                    _dayAlternateRepository = new DayAlternateRepository(_db);
                }
                return _dayAlternateRepository;
            }
        }
        private ICalenderRepository _calenderRepository;
        public ICalenderRepository CalenderRepository
        {
            get
            {
                if (_calenderRepository == null)
                {
                    _calenderRepository = new CalenderRepository(_db);
                }
                return _calenderRepository;
            }
        }
        private IUnderGradutesInNewAcademyYearRepository _underGradutesInNewAcademyYearRepository;
        public IUnderGradutesInNewAcademyYearRepository UnderGradutesInNewAcademyYearRepository
        {
            get
            {
                if (_underGradutesInNewAcademyYearRepository == null)
                {
                    _underGradutesInNewAcademyYearRepository = new UnderGradutesInNewAcademyYearRepository(_db);
                }
                return _underGradutesInNewAcademyYearRepository;
            }
        }
        private IFieldsOfNewYearInUnGradutesRepository _fieldsOfNewYearInUnGradutesRepository;
        public IFieldsOfNewYearInUnGradutesRepository FieldsOfNewYearInUnGradutesRepository
        {
            get
            {
                if (_fieldsOfNewYearInUnGradutesRepository == null)
                {
                    _fieldsOfNewYearInUnGradutesRepository = new FieldsOfNewYearInUnGradutesRepositroy(_db);
                }
                return _fieldsOfNewYearInUnGradutesRepository;
            }
        }
        private ILessonsOfFileldsOfNewYearInUngradeRepository _lessonsOfFileldsOfNewYearInUngradeRepository;
        public ILessonsOfFileldsOfNewYearInUngradeRepository LessonsOfFileldsOfNewYearInUngradeRepository
        {
            get
            {
                if (_lessonsOfFileldsOfNewYearInUngradeRepository == null)
                {
                    _lessonsOfFileldsOfNewYearInUngradeRepository = new LessonsOfFileldsOfNewYearInUngradeRepository(_db);
                }
                return _lessonsOfFileldsOfNewYearInUngradeRepository;
            }
        }

        private ITeacherTeachsLessonsOfNewYearInUnGradesRepository _teachsLessonsOfNewYearInUnGradesRepository;
        public ITeacherTeachsLessonsOfNewYearInUnGradesRepository TeacherTeachsLessonsOfNewYearInUnGradesRepository
        {
            get
            {
                if (_teachsLessonsOfNewYearInUnGradesRepository==null)
                {
                    _teachsLessonsOfNewYearInUnGradesRepository = new TeacherTeachsLessonsOfNewYearInUnGradesRepository(_db);
                }
                return _teachsLessonsOfNewYearInUnGradesRepository;
            }
        }
        private ITeacherTeachLessonAccordingToCalenderRepository _teacherTeachLessonAccordingToCalenderRepository;
        public  ITeacherTeachLessonAccordingToCalenderRepository TeacherTeachLessonAccordingToCalenderRepository
        {
            get
            {
                if (_teacherTeachLessonAccordingToCalenderRepository==null)
                {
                    _teacherTeachLessonAccordingToCalenderRepository = new TeacherTeachLessonAccordingToCalenderRepository(_db);
                }
                return _teacherTeachLessonAccordingToCalenderRepository;
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
