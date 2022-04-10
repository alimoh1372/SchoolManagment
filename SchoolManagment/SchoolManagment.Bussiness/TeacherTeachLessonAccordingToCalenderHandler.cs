using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public class TeacherTeachLessonAccordingToCalenderHandler : ITeacherTeachLessonAccordingToCalenderHandler
    {
        private IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> _teacherTeachLessonAccordingToCalenderViewModel;

        private IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> _teacherTeachsLessonsOfNewYearInUnGradesViewModels;
        public IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> FillTeacherLessonCalenderViewModel(Expression<Func<TeacherTeachLessonAccordingToCalender, bool>> where = null)
        {


            if (where == null)
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    _teacherTeachLessonAccordingToCalenderViewModel = db.TeacherTeachsLessonsOfNewYearInUnGradesRepository.Get().Select(tLC => new TeacherTeachLessonAccordingToCalenderViewModel()
                    {
                        TeacherTeachLessonId = tLC.TeacherTeachLessonId,
                        FkTeacherId = tLC.FkTeacherId,
                        FkTeacherIdString = tLC.Teacher.TeacherName,
                        PkLessonOfFieldOfNewYearInUnGradeId = tLC.FkLessonOfFieldsOfNewYearInUnGrade
                    }).ToList();

                    using (TeacherTeachsLessonsOfNewYearInUnGradesHandler teacherLessonHandler = new TeacherTeachsLessonsOfNewYearInUnGradesHandler())
                    {
                        _teacherTeachsLessonsOfNewYearInUnGradesViewModels = teacherLessonHandler.FillTeacherTeachsLessonsOfNewYearInUnGradesViewModels().ToList();

                    

                        _teacherTeachLessonAccordingToCalenderViewModel = (from t in _teacherTeachLessonAccordingToCalenderViewModel
                                                                           join d in _teacherTeachsLessonsOfNewYearInUnGradesViewModels
                                                                           on t.PkLessonOfFieldOfNewYearInUnGradeId equals d.PkLessonOfFieldOfNewYearInUnGradeId
                                                                           select new TeacherTeachLessonAccordingToCalenderViewModel()
                                                                           {
                                                                               TeacherTeachLessonId = t.TeacherTeachLessonId,
                                                                               FkTeacherId = t.FkTeacherId,
                                                                               FkTeacherIdString = t.FkTeacherIdString,
                                                                               PkLessonOfFieldOfNewYearInUnGradeId = t.PkLessonOfFieldOfNewYearInUnGradeId,
                                                                               FkLessonId = d.FkLessonId,
                                                                               FkLessonIdString = d.FkLessonIdString,
                                                                               PkFieldsOfNewYearInUnGradutesId = d.PkFieldsOfNewYearInUnGradutesId,
                                                                               FkFieldId = d.FkFieldId,
                                                                               FkFieldIdString = d.FkFieldIdString,
                                                                               PkUnderGraduteInAcademyYearId = d.PkUnderGraduteInAcademyYearId,
                                                                               AcademyYearId = d.AcademyYearId,
                                                                               AcademyYearString = d.AcademyYearString,
                                                                               FkUnGraduteId = d.FkUnGraduteId,
                                                                               FkUnGraduteIdString = d.FkUnGraduteIdString
                                                                           }).ToList();
                    }
                }
            }
            return _teacherTeachLessonAccordingToCalenderViewModel;

        }
        public void Dispose()
        {
            if (_teacherTeachLessonAccordingToCalenderViewModel != null)
            {
                _teacherTeachLessonAccordingToCalenderViewModel = null;
            }
            if (_teacherTeachsLessonsOfNewYearInUnGradesViewModels != null)
            {
                _teacherTeachsLessonsOfNewYearInUnGradesViewModels = null;
            }
        }
    }
}
