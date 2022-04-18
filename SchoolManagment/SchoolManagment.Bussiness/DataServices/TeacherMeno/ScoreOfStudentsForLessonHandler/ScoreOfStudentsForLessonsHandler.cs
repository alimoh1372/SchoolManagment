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
                allLessonForTeacherMenoViewModels = db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Get()
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

            IEnumerable<IScoreStudentViewModel> scoreStudentViewModels = null;
            int pkTeacherTeachLessonAccToCalInClassId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PkTeacherTeachLessonAccToCalInClassId"].Value);
            int fkLastPassedUgraduteId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkUnGraduteId"].Value);
            string fkLastPassedUgraduteIdString = dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkUnGraduteIdString"].Value.ToString();
            int fkStudentFieldId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkFieldId"].Value);
            string fkStudentFieldIdString = dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkFieldIdString"].Value.ToString();
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                scoreStudentViewModels = db.ScoreOfStudentsForLessonsRepository.Get(sc => sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.FkTeacherTeachLessonAccToCalenderInClass == pkTeacherTeachLessonAccToCalInClassId)
                      .Select(sc => new ScoreStudentViewModel()
                      {
                          checkboxSelectStudent = true,
                          PkScoreOfStudentsForLessons = sc.PkScoreOfStudentsForLessons,
                          ScoreOfLesson = sc.ScoreOfLesson,
                          StudentId = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.FkStudentId,
                          StudentName = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.Student.StudentName,
                          StudentNationCode = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.Student.StudentNationCode,
                          FkLastPassedUgraduteId = (int?)fkLastPassedUgraduteId,
                          FkLastPassedUgraduteIdString = fkLastPassedUgraduteIdString,
                          FkStudentFieldId = fkStudentFieldId,
                          FkStudentFieldIdString = fkStudentFieldIdString
                      }).ToList();
            }
            return scoreStudentViewModels;
        }

        public IEnumerable<ITeacherMenoAllLessonsClassViewModel> FilterDgvAll(IEnumerable<ITeacherMenoAllLessonsClassViewModel> allTeacherMenoViewModels, TextBox txtSearch)
        {
            IEnumerable<ITeacherMenoAllLessonsClassViewModel> _allTeacherMenoViewModel;
            string _txtSearchText = txtSearch.Text.Trim().ToLower();
            if (_txtSearchText != string.Empty)
            {
                _allTeacherMenoViewModel = allTeacherMenoViewModels
                    .Where(
                    t => t.AcademyYearString.Trim().ToLower().Contains(_txtSearchText) ||
                   t.FkCalenderIdString.Trim().ToLower().Contains(_txtSearchText) ||
                   t.FkClassIdString.Trim().ToLower().Contains(_txtSearchText) ||
                   t.FkFieldIdString.Trim().ToLower().Contains(_txtSearchText) ||
                   t.FkLessonIdString.Trim().ToLower().Contains(_txtSearchText) ||
                   t.FkTeacherIdString.Trim().ToLower().Contains(_txtSearchText) ||
                   t.FkUnGraduteIdString.Trim().ToLower().Contains(_txtSearchText)
                    ).ToList();
            }
            else
            {
                _allTeacherMenoViewModel = allTeacherMenoViewModels;
            }
            return _allTeacherMenoViewModel;
        }
        public IEnumerable<IScoreStudentViewModel> FilterDgvStudent(IEnumerable<IScoreStudentViewModel> scoreStudentViewModels, TextBox txtStudentSearch)
        {
            IEnumerable<IScoreStudentViewModel> resultStudentViewModel;
            string _txtStudentSearch = txtStudentSearch.Text.Trim().ToLower();
            if (_txtStudentSearch != string.Empty)
            {
                resultStudentViewModel = scoreStudentViewModels.Where(sc => sc.FkLastPassedUgraduteIdString.Trim().ToLower().Contains(_txtStudentSearch) ||
                sc.FkStudentFieldIdString.Trim().ToLower().Contains(_txtStudentSearch) ||
                sc.StudentName.Trim().ToLower().Contains(_txtStudentSearch) ||
                sc.StudentNationCode.Trim().ToLower().Contains(_txtStudentSearch));
            }
            else
            {
                resultStudentViewModel = scoreStudentViewModels;
            }
            return resultStudentViewModel;
        }
        public bool SetScoreOfStudent(DataGridView dgvStudent, IEnumerable<IScoreStudentViewModel> scoreStudentViewModels)
        {
            bool result = false;
            int numberOfChangeDb = -1;
            string attempMessage;
            int pkScoreOfStudentsForLessons;
            decimal? dgvScore;
            UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities());
            ScoreOfStudentsForLesson scoreStudentEntity;
            List<ScoreOfStudentsForLesson> _needToUpdateScoreStudentViewModel = new List<ScoreOfStudentsForLesson>();
            if (dgvStudent.CurrentCell != null && dgvStudent != null)
            {
                foreach (DataGridViewRow row in dgvStudent.Rows)
                {

                    pkScoreOfStudentsForLessons = Convert.ToInt32(row.Cells["PkScoreOfStudentsForLessons"].Value);
                    scoreStudentEntity = db.ScoreOfStudentsForLessonsRepository.GetById(pkScoreOfStudentsForLessons);
                    dgvScore = Convert.ToDecimal(row.Cells["ScoreOfLesson1"].Value);

                    if (dgvScore != scoreStudentEntity.ScoreOfLesson)
                    {
                        scoreStudentEntity.ScoreOfLesson = dgvScore;
                        _needToUpdateScoreStudentViewModel.Add(scoreStudentEntity);
                    }
                }
            }
            else
            {
                attempMessage = "جهت ثبت تغییرات در نمره ها لطفا یک مورد را تغییر دهید";
                RtlMessageBox.Show(attempMessage, "بدون تغییر");
            }
            attempMessage = "آیا از ثبت تغییرات به تعداد " + _needToUpdateScoreStudentViewModel.Count + " مطمئن هستید؟";
            if (RtlMessageBox.Show(attempMessage, "اطمینان از ثبت نمرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ScoreOfStudentsForLesson scoreOfStudentsForLesson;
                foreach (ScoreOfStudentsForLesson scoreVM in _needToUpdateScoreStudentViewModel)
                {
                    db.ScoreOfStudentsForLessonsRepository.Update(scoreVM);
                }
            }
            numberOfChangeDb = db.Save();
            if (numberOfChangeDb == _needToUpdateScoreStudentViewModel.Count)
            {
                result = true;
            }
            else
            {
                attempMessage = "مشکلی در ثبت تغییرات در دیتابیس رخ داده است.لطفا بعدا متحان کنید یا با ادمین خود تماس بگیرید.";
                RtlMessageBox.Show(attempMessage, "خطا در دیتابیس");
            }
            db.Dispose();
            return result;
        }
        public void Dispose()
        {
        }
    }
}
