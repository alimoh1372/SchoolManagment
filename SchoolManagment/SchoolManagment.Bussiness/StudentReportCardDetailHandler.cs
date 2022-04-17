using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public class StudentReportCardDetailHandler : IStudentReportCardDetailHandler
    {
        public IEnumerable<IStudentViewModel> GetStudentViewModel()
        {
            IEnumerable<IStudentViewModel> studentViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                studentViewModels = db.StudentRepository.FillStudentViewModel().ToList();
            }
            return studentViewModels;

        }
        public IEnumerable<IStudentViewModel> FilterDgvStudent(IEnumerable<IStudentViewModel> studentViewModels, TextBox txtStudentSearch)
        {
            IEnumerable<IStudentViewModel> resultStudentViewModels;
            string _txtStudentSearch = txtStudentSearch.Text.Trim().ToLower();
            if (_txtStudentSearch != string.Empty)
            {
                resultStudentViewModels = studentViewModels.Where(sc => sc.FkLastPassedUgraduteIdString.Trim().ToLower().Contains(_txtStudentSearch) ||
                sc.FkStudentFieldIdString.Trim().ToLower().Contains(_txtStudentSearch) ||
                sc.StudentName.Trim().ToLower().Contains(_txtStudentSearch) ||
                sc.StudentNationCode.Trim().ToLower().Contains(_txtStudentSearch)
                );
            }
            else
            {
                resultStudentViewModels = studentViewModels;
            }
            return resultStudentViewModels;
        }
        public IEnumerable<ITeacherMenoAllLessonsClassViewModel> GetAllLessonClassWithPresentForeignKey(DataGridView dgvStudent)
        {
            IEnumerable<ITeacherMenoAllLessonsClassViewModel> teacherMenoAllLessonsClassViewModels = null;
            IEnumerable<IScoreOfStudentsForLessonViewModel> studentReportCardDetailViewModels;
            int studentId = Convert.ToInt32(dgvStudent.CurrentRow.Cells["StudentId"].Value);
            if (dgvStudent.CurrentCell != null && dgvStudent.DataSource != null && dgvStudent.SelectedCells.Count > 0)
            {

                ScoreOfStudentsForLessonsHandler scoreOfHandler = new ScoreOfStudentsForLessonsHandler();
                teacherMenoAllLessonsClassViewModels = scoreOfHandler.GetAllLessonClassWithPresentForeignKey();
                studentReportCardDetailViewModels = GetStudentReportCardDetailViewModelsFromScoreTable(st => st.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.Student.StudentId == studentId);
                teacherMenoAllLessonsClassViewModels = teacherMenoAllLessonsClassViewModels.Join(studentReportCardDetailViewModels,
                    t => t.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId, s => s.FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId,
                    (t, s) => t).ToList();
                scoreOfHandler.Dispose();
            }
            else
            {
                RtlMessageBox.Show("دانش آموزی انتخاب نشده است");
            }
            return teacherMenoAllLessonsClassViewModels;
        }
        public IEnumerable<IScoreOfStudentsForLessonViewModel> GetStudentReportCardDetailViewModelsFromScoreTable(Expression<Func<ScoreOfStudentsForLesson, bool>> where = null)
        {
            IEnumerable<ScoreOfStudentsForLesson> queryStudentReportCardViewModel;
            IEnumerable<IScoreOfStudentsForLessonViewModel> studentReportCardViewModel;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                if (where == null)
                {
                    queryStudentReportCardViewModel = db.ScoreOfStudentsForLessonsRepository.Get();
                }
                else
                {
                    queryStudentReportCardViewModel = db.ScoreOfStudentsForLessonsRepository.Get(where);
                }
                studentReportCardViewModel = queryStudentReportCardViewModel.Select(st => new ScoreOfStudentsForLessonViewModel()
                {
                    PkScoreOfStudentsForLessons = st.PkScoreOfStudentsForLessons,
                    ScoreOfLesson = st.ScoreOfLesson,
                    FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId = st.FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId,
                    PKLessonId = st.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass
                    .TeacherTeachLessonAccToCalenderInClass.TeacherTeachLessonAccordingToCalender
                    .TeacherTeachsLessonsOfNewYearInUnGrade.LessonsOfFileldsOfNewYearInUngrade.FkLessonId,
                    LessonName= st.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass
                    .TeacherTeachLessonAccToCalenderInClass.TeacherTeachLessonAccordingToCalender
                    .TeacherTeachsLessonsOfNewYearInUnGrade.LessonsOfFileldsOfNewYearInUngrade.Lesson.LessonName,
                    LessonUnits= st.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass
                    .TeacherTeachLessonAccToCalenderInClass.TeacherTeachLessonAccordingToCalender
                    .TeacherTeachsLessonsOfNewYearInUnGrade.LessonsOfFileldsOfNewYearInUngrade.Lesson.LessonUnits
                });
                return studentReportCardViewModel.ToList();
            }
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
                   t.FkFieldIdString.Trim().ToLower().Contains(_txtSearchText) ||
                   t.FkUnGraduteIdString.Trim().ToLower().Contains(_txtSearchText)
                    ).ToList();
            }
            else
            {
                _allTeacherMenoViewModel = allTeacherMenoViewModels;
            }
            return _allTeacherMenoViewModel;
        }
        public IEnumerable<IScoreOfStudentsForLessonViewModel> GetStudentReportCardLessons(DataGridView dgvStudent, DataGridView dgvNewAcademyYearAllLessons)
        {
            IEnumerable<IScoreOfStudentsForLessonViewModel> studentScoresForLessonsReportCardViewModels = null;

            int studentId;
            int fkStudentFieldId;
            int academyYearId;
            if (dgvNewAcademyYearAllLessons.CurrentCell != null && dgvNewAcademyYearAllLessons.CurrentRow != null && dgvNewAcademyYearAllLessons.SelectedCells != null)
            {
                studentId = Convert.ToInt32(dgvStudent.CurrentRow.Cells[0].Value);
                fkStudentFieldId = Convert.ToInt32(dgvStudent.CurrentRow.Cells["FkStudentFieldId"].Value);
                academyYearId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearId"].Value);
                studentScoresForLessonsReportCardViewModels= GetStudentReportCardDetailViewModelsFromScoreTable(s => s.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.Student.StudentId == studentId &&
                s.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.TeacherTeachLessonAccToCalenderInClass.TeacherTeachLessonAccordingToCalender
                .TeacherTeachsLessonsOfNewYearInUnGrade.LessonsOfFileldsOfNewYearInUngrade.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.FkAcademyYearId == academyYearId);
            }
            return studentScoresForLessonsReportCardViewModels;
        }
        public decimal? GetAverageLessons(IEnumerable<IScoreOfStudentsForLessonViewModel> scoreOfStudentsForLessonViewModels)
        {
            decimal? average=null;
            int sumlessonUnit = scoreOfStudentsForLessonViewModels.Sum(t=>t.LessonUnits);
            average = scoreOfStudentsForLessonViewModels.Select(t => t.LessonUnits*t.ScoreOfLesson).Sum()/sumlessonUnit;
            return average;
        }
        public void Dispose()
        {

        }
    }
}
