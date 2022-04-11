using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using SchoolManagment.Utility;

namespace SchoolManagment.Bussiness
{
    public class TeacherTeachLessonAccToCalenderInClassHandler : ITeacherTeachLessonAccToCalenderInClassHandler
    {
        IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> _thisTeacherTeachLessonAccToCalenderInClassViewModels;
        public IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> FillLessonCalenderViewModel()
        {
            IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> teacherTeachLessonAccordingToCalenderViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {

                _thisTeacherTeachLessonAccToCalenderInClassViewModels = db.TeacherTeachLessonAccordingToCalenderRepository.Get().Select(t => new TeacherTeachLessonAccToCalenderInClassViewModel()
                {
                    PKTeacherTeachLessonAccordingToCalender = t.PKTeacherTeachLessonAccordingToCalender,
                    FkCalenderId = t.FkCalenderId,
                    FkCalenderIdString = t.Calender.CalenderName + "-" + t.Calender.DayAlternate.DayAlternateDescription + "ها-" + t.Calender.TimeAlterNate.FromTime.ToString(@"hh/:ss") + " " + t.Calender.TimeAlterNate.ToTime.ToString(@"hh/:ss"),
                    TeacherTeachLessonId = t.TeacherTeachsLessonsOfNewYearInUnGrade.TeacherTeachLessonId
                });
                using (TeacherTeachLessonAccordingToCalenderHandler tchCalenderHandler = new TeacherTeachLessonAccordingToCalenderHandler())
                {
                    teacherTeachLessonAccordingToCalenderViewModels = tchCalenderHandler.FillTeacherLessonCalenderViewModel();

                    _thisTeacherTeachLessonAccToCalenderInClassViewModels = _thisTeacherTeachLessonAccToCalenderInClassViewModels.Join(teacherTeachLessonAccordingToCalenderViewModels,
                       t => t.TeacherTeachLessonId, c => c.TeacherTeachLessonId, (t, c) => new TeacherTeachLessonAccToCalenderInClassViewModel()
                       {
                           PKTeacherTeachLessonAccordingToCalender=t.PKTeacherTeachLessonAccordingToCalender,
                           FkCalenderId=t.FkCalenderId,
                           FkCalenderIdString=t.FkCalenderIdString,
                           TeacherTeachLessonId=t.TeacherTeachLessonId,
                           FkTeacherId=c.FkTeacherId,
                           FkTeacherIdString=c.FkTeacherIdString,
                           PkLessonOfFieldOfNewYearInUnGradeId=c.PkLessonOfFieldOfNewYearInUnGradeId,
                           FkLessonId=c.FkLessonId,
                           FkLessonIdString=c.FkLessonIdString,
                           PkFieldsOfNewYearInUnGradutesId=c.PkFieldsOfNewYearInUnGradutesId,
                           FkFieldId=c.FkFieldId,
                           FkFieldIdString=c.FkFieldIdString,
                           PkUnderGraduteInAcademyYearId=c.PkUnderGraduteInAcademyYearId,
                           AcademyYearId=c.AcademyYearId,
                           AcademyYearString=c.AcademyYearString,
                           FkUnGraduteId=c.FkUnGraduteId,
                           FkUnGraduteIdString=c.FkUnGraduteIdString
                       }).ToList()
                       ;
                }
            }
            return _thisTeacherTeachLessonAccToCalenderInClassViewModels;
        }
    }
}
