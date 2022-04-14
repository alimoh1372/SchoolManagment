using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public class ScoreOfStudentsForLessonsHandler : IScoreOfStudentsForLessonsHandler
    {
        public IEnumerable<ITeacherMenoAllLessonsClassViewModel> GetAllLessonClassWithPresentForeignKey()
        {
            IEnumerable<TeacherMenoAllLessonsClassViewModel> allLessonForTeacherMenoViewModels;
            IEnumerable<TeacherMenoAllLessonsClassViewModel> joinAlllessonsViewModelToStudentMustViewModel;
            IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> studentMustViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                allLessonForTeacherMenoViewModels = db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Get().GroupBy(sc => sc.FkTeacherTeachLessonAccToCalenderInClass)
                    .Select(sc => sc.FirstOrDefault())
                    .Select(sc => new TeacherMenoAllLessonsClassViewModel()
                    {
                        PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId = sc.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId,
                        PkTeacherTeachLessonAccToCalInClassId = sc.FkTeacherTeachLessonAccToCalenderInClass
                    }).ToList();
            }
            using (StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler stMustHandler = new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
            {
                studentMustViewModels = stMustHandler.FillStudentsClassInCalenderViewModel();
            }
            joinAlllessonsViewModelToStudentMustViewModel = allLessonForTeacherMenoViewModels.Join(studentMustViewModels, a => a.PkTeacherTeachLessonAccToCalInClassId, sm => sm.PkTeacherTeachLessonAccToCalInClassId,
                (a, sM) => new TeacherMenoAllLessonsClassViewModel()
                {
                    PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId = a.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId,
                    PkTeacherTeachLessonAccToCalInClassId = a.PkTeacherTeachLessonAccToCalInClassId,
                    FkClassId = sM.FkClassId,
                    FkClassIdString = sM.FkClassIdString,
                    PKTeacherTeachLessonAccordingToCalender = sM.PKTeacherTeachLessonAccordingToCalender,
                    FkCalenderId = sM.FkCalenderId,
                    FkCalenderIdString = sM.FkCalenderIdString,
                    TeacherTeachLessonId = sM.TeacherTeachLessonId,
                    FkTeacherId = sM.FkTeacherId,
                    FkTeacherIdString = sM.FkTeacherIdString,
                    PkLessonOfFieldOfNewYearInUnGradeId = sM.PkLessonOfFieldOfNewYearInUnGradeId,
                    FkLessonId = sM.FkLessonId,
                    FkLessonIdString = sM.FkLessonIdString,
                    PkFieldsOfNewYearInUnGradutesId = sM.PkFieldsOfNewYearInUnGradutesId,
                    FkFieldId = sM.FkFieldId,
                    FkFieldIdString = sM.FkFieldIdString,
                    PkUnderGraduteInAcademyYearId = sM.PkUnderGraduteInAcademyYearId,
                    AcademyYearId = sM.AcademyYearId,
                    AcademyYearString = sM.AcademyYearString,
                    FkUnGraduteId = sM.FkUnGraduteId,
                    FkUnGraduteIdString = sM.FkUnGraduteIdString
                }
                ).ToList();
            return joinAlllessonsViewModelToStudentMustViewModel;

        }
        public IEnumerable<IScoreStudentViewModel> GetScoreStudentViewModels(DataGridView dgvNewAcademyYearAllLessons)
        {
            IEnumerable<StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass> stMusts;
            IEnumerable<IScoreStudentViewModel> scoreStudentViewModels = null;
            int PkTeacherTeachLessonAccToCalInClassId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PkTeacherTeachLessonAccToCalInClassId"].Value);
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
               
            }
            return scoreStudentViewModels;
        }
            
        public void Dispose()
        {
        }
    }
}
