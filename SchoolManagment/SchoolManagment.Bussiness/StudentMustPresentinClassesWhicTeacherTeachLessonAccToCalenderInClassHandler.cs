using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public class StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler : IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler
    {
        IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> _studentInClassCalenderViewModels;
        IEnumerable<IStudentViewModel> _thisStudentViewModels;
        public int StudentsInFieldNumber(int fieldId)
        {
            int studentNumber = -1;
            string attempMessage;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                studentNumber = db.StudentRepository.Get(st => st.FkStudentFieldId == fieldId).Count();
            }
            if (studentNumber < 0)
            {
                attempMessage = "خطا در دیتابیس لطفا بعدا مجددا امتحان فرمائید.یا با ادمین خود تماس حاصل فرمائید.";
                RtlMessageBox.Show(attempMessage, "خطا در دیتابیس");
            }
            return studentNumber;
        }


        public int StudentsInFieldNumber(Field field)
        {
            int fieldId = field.PkFieldId;
            return StudentsInFieldNumber(fieldId);
        }

        public IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> FillStudentsClassInCalenderViewModel()
        {
            IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> classINCalenderViewModel;
            IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> thisStudentInClassCalenderViewModels;
            using (TeacherTeachLessonAccToCalenderInClassHandler classInCalenderHandler = new TeacherTeachLessonAccToCalenderInClassHandler())
            {
                classINCalenderViewModel = classInCalenderHandler.FillLessonCalenderViewModel();
            }
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                thisStudentInClassCalenderViewModels = db.TeacherTeachLessonAccToCalenderInClassRepository.Get().Select(t => new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel()
                {
                    PkTeacherTeachLessonAccToCalInClassId = t.PkTeacherTeachLessonAccToCalInClassId,
                    FkClassId = t.FkClassId,
                    FkClassIdString = t.Class.ClassName + "-" + t.Class.ClassLocation + "-ظرفیت:" + t.Class.ClassCapacity.ToString(),
                    PKTeacherTeachLessonAccordingToCalender = t.TeacherTeachLessonAccordingToCalender.PKTeacherTeachLessonAccordingToCalender
                }).ToList();
            }
            _studentInClassCalenderViewModels = thisStudentInClassCalenderViewModels.
                Join(classINCalenderViewModel, s => s.PKTeacherTeachLessonAccordingToCalender, t => t.PKTeacherTeachLessonAccordingToCalender, (s, t) => new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel()
                {
                    PkTeacherTeachLessonAccToCalInClassId = s.PkTeacherTeachLessonAccToCalInClassId,
                    FkClassId = s.FkClassId,
                    FkClassIdString = s.FkClassIdString,
                    PKTeacherTeachLessonAccordingToCalender = s.PKTeacherTeachLessonAccordingToCalender,
                    FkCalenderId = t.FkCalenderId,
                    FkCalenderIdString = t.FkCalenderIdString,
                    TeacherTeachLessonId = t.TeacherTeachLessonId,
                    FkTeacherId = t.FkTeacherId,
                    FkTeacherIdString = t.FkTeacherIdString,
                    PkLessonOfFieldOfNewYearInUnGradeId = t.PkLessonOfFieldOfNewYearInUnGradeId,
                    FkLessonId = t.FkLessonId,
                    FkLessonIdString = t.FkLessonIdString,
                    PkFieldsOfNewYearInUnGradutesId = t.PkFieldsOfNewYearInUnGradutesId,
                    FkFieldId = t.FkFieldId,
                    FkFieldIdString = t.FkFieldIdString,
                    PkUnderGraduteInAcademyYearId = t.PkUnderGraduteInAcademyYearId,
                    AcademyYearId = t.AcademyYearId,
                    AcademyYearString = t.AcademyYearString,
                    FkUnGraduteId = t.FkUnGraduteId,
                    FkUnGraduteIdString = t.FkUnGraduteIdString
                }).ToList();
            return _studentInClassCalenderViewModels;
        }
        public IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> FilterSearchGridView(IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> studentclassInCalenderViewModels, TextBox txtSearch)
        {
            _studentInClassCalenderViewModels = studentclassInCalenderViewModels
                .Where(t => t.FkClassIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.AcademyYearString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkCalenderIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkFieldIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkLessonIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkTeacherIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkUnGraduteIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                ).ToList();
            return _studentInClassCalenderViewModels;
        }
        public IEnumerable<IStudentViewModel> GetStudentsViewModel()
        {
            IEnumerable<IStudentViewModel> studentViewModels;

            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                studentViewModels = db.StudentRepository.FillStudentViewModel();
                _thisStudentViewModels = studentViewModels.ToList();
            }
            return _thisStudentViewModels;
        }
        public IEnumerable<IStudentViewModel> FillStudentDataGridView(DataGridView dgvNewAcademyYearAllLessons
            , IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> studentClassViewModel
            , IEnumerable<IStudentViewModel> studentViewModels)
        {
            IEnumerable<IStudentViewModel> thisStudentViewModel;

            int fkSelectedFieldId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkFieldId"].Value.ToString());
            int fkTeacherTeachLessonAccToCalInClassId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PkTeacherTeachLessonAccToCalInClassId"].Value.ToString());
            int fkClassId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkFieldId"].Value.ToString());
            thisStudentViewModel = studentViewModels.Where(s => s.FkStudentFieldId == fkSelectedFieldId).Select(s => new StudentViewModel()
            {
                checkboxSelectStudent = checkIsStudentAssigned(s.StudentId, fkTeacherTeachLessonAccToCalInClassId),
                StudentId = s.StudentId,
                FkStudentFieldId = s.FkStudentFieldId,
                StudentName = s.StudentName,
                StudentNationCode = s.StudentNationCode,
                FkLastPassedUgraduteId = s.FkLastPassedUgraduteId,
                FkLastPassedUgraduteIdString = s.FkLastPassedUgraduteIdString,
                FkStudentFieldIdString = s.FkStudentFieldIdString
            }).ToList();
            return thisStudentViewModel;
        }

        public bool checkIsStudentAssigned(int studentId, int fkTeacherTeachLessonAccToCalInClassId)
        {
            bool isAssignedStudent = false;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                isAssignedStudent = db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Get(sM => sM.FkStudentId == studentId).Any();
            }
            return isAssignedStudent;
        }
        public IEnumerable<IStudentViewModel> FilterSearch(IEnumerable<IStudentViewModel> AllStudentViewModels, TextBox txtSearch)
        {
            IEnumerable<IStudentViewModel> thisStudentViewModel;
            string trimtxtSearch = txtSearch.Text.Trim().ToLower();
            if (trimtxtSearch != string.Empty)
            {
                thisStudentViewModel = AllStudentViewModels.Where(s =>
             s.FkLastPassedUgraduteIdString.Trim().ToLower().Contains(trimtxtSearch) ||
              s.FkStudentFieldIdString.Trim().ToLower().Contains(trimtxtSearch) ||
              s.StudentName.Trim().ToLower().Contains(trimtxtSearch) ||
              s.StudentNationCode.Trim().ToLower().Contains(trimtxtSearch)
            );
            }
            else
            {
                thisStudentViewModel = AllStudentViewModels;
            }
            return thisStudentViewModel;

        }
        public IEnumerable<IStudentViewModel> FilterSearch(IEnumerable<IStudentViewModel> AllStudentViewModels, TextBox txtSearch, bool? SelectAssignedStudents = null)
        {
            IEnumerable<IStudentViewModel> thisStudentViewModel;
            if (SelectAssignedStudents == null)
            {
                thisStudentViewModel = FilterSearch(AllStudentViewModels, txtSearch);


            }
            else if (SelectAssignedStudents==true)
            {
                thisStudentViewModel =FilterSearch( AllStudentViewModels.Where(s => s.checkboxSelectStudent = true),txtSearch);
            }
            else
            {
                thisStudentViewModel = FilterSearch(AllStudentViewModels.Where(s => s.checkboxSelectStudent = false), txtSearch);
            }


            return thisStudentViewModel;
        }
       public bool? SelectAssignedStudents( RadioButton rdbAllStudent,RadioButton rdbSelectedStudent)
        {
            bool? result;
            if (rdbAllStudent.Checked == true)
            {
                 result=null;
            }
            else if(rdbSelectedStudent.Checked==true)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public void Dispose()
        {
            if (_studentInClassCalenderViewModels != null)
            {
                _studentInClassCalenderViewModels = null;
            }
        }


    }
}
