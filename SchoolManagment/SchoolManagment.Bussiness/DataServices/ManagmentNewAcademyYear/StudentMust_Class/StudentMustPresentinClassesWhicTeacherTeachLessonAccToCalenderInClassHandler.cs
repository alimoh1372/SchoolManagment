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
        private IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> _studentInClassCalenderViewModels;
        private IEnumerable<IStudentViewModel> _thisStudentViewModels;


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
            , IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> studentMustClassViewModel
            , IEnumerable<IStudentViewModel> studentViewModels
            )
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
        public IEnumerable<IStudentViewModel> FilterSearch(IEnumerable<IStudentViewModel> AllStudentViewModels, TextBox txttudentSearch)
        {
            IEnumerable<IStudentViewModel> thisStudentViewModel;
            string trimtxtSearch = txttudentSearch.Text.Trim().ToLower();
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
        public IEnumerable<IStudentViewModel> FilterSearch(IEnumerable<IStudentViewModel> AllStudentViewModels, TextBox txttudentSearch, bool? SelectAssignedStudents = null)
        {

            IEnumerable<IStudentViewModel> thisStudentViewModel;
            if (SelectAssignedStudents == null)
            {
                thisStudentViewModel = FilterSearch(AllStudentViewModels, txttudentSearch);


            }
            else if (SelectAssignedStudents == true)
            {
                thisStudentViewModel = FilterSearch(AllStudentViewModels.Where(s => s.checkboxSelectStudent == true), txttudentSearch);
            }
            else
            {
                thisStudentViewModel = FilterSearch(AllStudentViewModels.Where(s => s.checkboxSelectStudent == false), txttudentSearch);
            }


            return thisStudentViewModel;
        }
        public bool? SelectAssignedStudents(RadioButton rdbAllStudent, RadioButton rdbSelectedStudent)
        {
            bool? result;
            if (rdbAllStudent.Checked == true)
            {
                result = null;
            }
            else if (rdbSelectedStudent.Checked == true)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public IEnumerable<IStudentViewModel> GetSelectedStudent(DataGridView dgvNewAcademyYearAllLessons, IEnumerable<IStudentViewModel> studentDgvStudentViewModel)
        {
            IEnumerable<IStudentViewModel> _studentViewModel;
            IEnumerable<StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass> studentInMustTable;
            int studentFieldId = studentDgvStudentViewModel.FirstOrDefault().FkStudentFieldId;
            int PkTeacherTeachLessonAccToCalInClassId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PkTeacherTeachLessonAccToCalInClassId"].Value.ToString());

            if (studentFieldId != 0)
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    studentInMustTable = db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Get(sM => sM.Student.FkStudentFieldId == studentFieldId && sM.FkTeacherTeachLessonAccToCalenderInClass == PkTeacherTeachLessonAccToCalInClassId).ToList();
                    _studentViewModel = studentInMustTable.Join(studentDgvStudentViewModel, sM => sM.FkStudentId, s => s.StudentId, (sM, s) => s).Where(s => s.checkboxSelectStudent == true)/*.Where(s=>s.checkboxSelectStudent=true)*/.ToList();

                }
            }
            else
            {
                //Send Default Value
                _studentViewModel = studentDgvStudentViewModel;
            }
            return _studentViewModel;



        }
        public bool InsertDeleteSyncStudentsToClass(DataGridView dgvNewAcademyYearAllLessons,
            DataGridView dgvAllStudentInThisField,
            IEnumerable<IStudentViewModel> _dgvAllStudentInFieldViewModels,
            IEnumerable<IStudentViewModel> selectedStudentForDgvSelectedStudent)

        {

            bool boolresult = false;
            UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities());
            string attempMessage;
            int[] results = new int[] { 0, 0 };
            int result = 0;
            int studentId = 0;
            bool isInMustTable;
            bool isInSelectedStudentDgv;
            bool isInStudentDgvSelected;
            int pkPkTeacherTeachLessonAccToCalInClassId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PkTeacherTeachLessonAccToCalInClassId"].Value.ToString());
            List<StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass> studentMustListToInsert = new List<StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass>();
            List<StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass> studentMustListToDelete = new List<StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass>();
            List<ScoreOfStudentsForLesson> scoreOfStudentsToInsert = new List<ScoreOfStudentsForLesson>();
            List<ScoreOfStudentsForLesson> scoreOfStudentsToDelete = new List<ScoreOfStudentsForLesson>();
            if (dgvAllStudentInThisField != null)
            {
                foreach (DataGridViewRow row in dgvAllStudentInThisField.Rows)
                {

                    studentId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    isInMustTable = checkIsStudentAssigned(studentId, pkPkTeacherTeachLessonAccToCalInClassId);
                    isInSelectedStudentDgv = selectedStudentForDgvSelectedStudent.Any(s => s.StudentId == studentId);
                    isInStudentDgvSelected = Convert.ToBoolean(row.Cells["checkboxSelectStudent"].Value.ToString());

                    if (isInStudentDgvSelected != isInMustTable)
                    {

                        if (isInStudentDgvSelected == true && isInMustTable == false && isInSelectedStudentDgv == true || isInStudentDgvSelected == false && isInMustTable == true && isInSelectedStudentDgv == true)
                        {
                            StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass entity = new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass();
                            entity = db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Get(s => s.FkStudentId == studentId && s.FkTeacherTeachLessonAccToCalenderInClass == pkPkTeacherTeachLessonAccToCalInClassId).First();
                            studentMustListToDelete.Add(entity);
                            ScoreOfStudentsForLesson scoreOfStudentEntity = db.ScoreOfStudentsForLessonsRepository.Get(sc => sc.FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId == entity.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId).First();

                            scoreOfStudentsToDelete.Add(scoreOfStudentEntity);
                            //db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Delete(entity);


                        }
                        else if (isInStudentDgvSelected == true && isInMustTable == false && isInSelectedStudentDgv == false)
                        {
                            StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass entity = new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass()
                            {
                                FkStudentId = studentId,
                                FkTeacherTeachLessonAccToCalenderInClass = pkPkTeacherTeachLessonAccToCalInClassId
                            };
                            studentMustListToInsert.Add(entity);
                            //db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Insert(entity);
                            
                        }
                        else
                        {
                            attempMessage = " دانش آموز با مشخصات زیر جزو کلاس" + " \"" + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkClassIdString"].Value + "\" " +
                                " نیست و شما نمیتوانید آن را حذف نمایئد.برای این کار ابتدا کلاس  دانش آموز را انتخاب سپس" +
                                "اقدام به حذف نمائید." + "\n" +
                                "نام دانش آموز:  " + row.Cells[2].Value + "\n" +
                            "کد ملی دانش آموز: " + row.Cells[3].Value;
                            RtlMessageBox.Show(attempMessage, "عدم امکان حذف دانش آموز از کلاس دیگر");
                        }

                    }
                }
                attempMessage = "آیا از ثبت تغییرات ذیل مطمئن هستید؟" + "\n" +
                    "تعداد حذف شده ها: " + (studentMustListToDelete.Count) + "\n" +
                    "تعداد اضافه شده ها: " + (studentMustListToInsert.Count);
                if (RtlMessageBox.Show(attempMessage, "اطمینان از ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int sumResults = studentMustListToInsert.Count+studentMustListToDelete.Count;
                    
                    foreach (var entity in studentMustListToInsert)
                    {
                        db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Insert(entity);
                        result +=  db.Save();
                        ScoreOfStudentsForLesson scoreOfStudentEntity = new ScoreOfStudentsForLesson()
                        {
                            FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId = entity.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId
                        };
                        db.ScoreOfStudentsForLessonsRepository.Insert(scoreOfStudentEntity);
                        result += db.Save();
                    }
                    foreach (var entity in studentMustListToDelete)
                    {
                        ScoreOfStudentsForLesson scoreEntity = new ScoreOfStudentsForLesson();
                        scoreEntity = db.ScoreOfStudentsForLessonsRepository.Get(sc => sc.FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId == entity.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId).First();

                        db.ScoreOfStudentsForLessonsRepository.Delete(scoreEntity);
                        result += db.Save();
                        db.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassRepository.Delete(entity);
                        result += db.Save();
                        
                    }
                    if (sumResults != result/2)
                    {
                        attempMessage = "در اعمال تغییرات برخی از دانش آموزان مشکلی پیش آمده است.لطفا بعدا سعی نمائید." +
                            "تعداد تغییر داده شده ها:" + result/2;

                        RtlMessageBox.Show(attempMessage, "خطا در دیتابیس");

                    }
                    else
                    {
                        boolresult = true;
                    }

                }

            }
            else
            {
                attempMessage = "هیج دانش آموزی جهت انجام تغییرات وجود ندارد لطفا دانش آموزان این رشته را ثبت نام فرمائید.";
                RtlMessageBox.Show(attempMessage, "عدم وجود دانش آموز");
            }
            
            db.Dispose();
            return boolresult;
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
