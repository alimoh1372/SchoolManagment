using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
    interface IUnitOfWork : IDisposable
    {
        #region ManagmentInfoMen
        IGradeRepository GradeRepository { get; }
        IUnderGraduteRepository UnderGraduteRepository { get; }
        IAcademyYearRepository AcademyYearRepository { get; }
        IFieldRepository FieldRepository { get; }
        ILessonRepository LessonRepository { get; }
        IStudentRepository StudentRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        IClassRepository ClassRepository { get; }
        ITeacherCanTeachLessonRepository TeacherCanTeachLessonRepository{get;}
        ITypeDayRepository TypeDayRepository { get; }
        ITimeAlterNateRepository TimeAlterNateRepository { get; }
        IDayAlternateRepository DayAlternateRepository { get; }
        ICalenderRepository CalenderRepository { get; }
        #endregion

        #region ManagmentNewAcademyYear
        IUnderGradutesInNewAcademyYearRepository UnderGradutesInNewAcademyYearRepository { get; }
        IFieldsOfNewYearInUnGradutesRepository FieldsOfNewYearInUnGradutesRepository { get; }
        ILessonsOfFileldsOfNewYearInUngradeRepository LessonsOfFileldsOfNewYearInUngradeRepository { get; }
        ITeacherTeachsLessonsOfNewYearInUnGradesRepository TeacherTeachsLessonsOfNewYearInUnGradesRepository { get; }
        ITeacherTeachLessonAccordingToCalenderRepository TeacherTeachLessonAccordingToCalenderRepository { get; }
        ITeacherTeachLessonAccToCalenderInClassRepository TeacherTeachLessonAccToCalenderInClassRepository { get; }
        IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository { get; }


        #endregion
        IScoreOfStudentsForLessonsRepository ScoreOfStudentsForLessonsRepository { get; }


        int Save();

       
    }
}
