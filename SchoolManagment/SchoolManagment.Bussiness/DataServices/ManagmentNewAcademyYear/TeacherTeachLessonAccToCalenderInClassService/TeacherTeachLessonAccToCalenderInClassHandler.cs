using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using SchoolManagment.Utility;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public class TeacherTeachLessonAccToCalenderInClassHandler : ITeacherTeachLessonAccToCalenderInClassHandler
    {
        private IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> _thisTeacherTeachLessonAccToCalenderInClassViewModels;
        private IEnumerable<Class> _thisClasses;


        public IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> FillLessonCalenderViewModel()
        {
            IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> teacherTeachLessonAccordingToCalenderViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {

                _thisTeacherTeachLessonAccToCalenderInClassViewModels = db.TeacherTeachLessonAccordingToCalenderRepository.Get().Select(t => new TeacherTeachLessonAccToCalenderInClassViewModel()
                {
                    PKTeacherTeachLessonAccordingToCalender = t.PKTeacherTeachLessonAccordingToCalender,
                    FkCalenderId = t.FkCalenderId,
                    FkCalenderIdString = /*t.Calender.CalenderName + "-" +*/ t.Calender.DayAlternate.DayAlternateDescription + " ها-از ساعت" + t.Calender.TimeAlterNate.FromTime.ToString(@"hh\:mm") + " تا  " + t.Calender.TimeAlterNate.ToTime.ToString(@"hh\:mm"),
                    TeacherTeachLessonId = t.TeacherTeachsLessonsOfNewYearInUnGrade.TeacherTeachLessonId
                }).ToList();
                using (TeacherTeachLessonAccordingToCalenderHandler tchCalenderHandler = new TeacherTeachLessonAccordingToCalenderHandler())
                {
                    teacherTeachLessonAccordingToCalenderViewModels = tchCalenderHandler.FillTeacherLessonCalenderViewModel();

                    _thisTeacherTeachLessonAccToCalenderInClassViewModels = _thisTeacherTeachLessonAccToCalenderInClassViewModels.Join(teacherTeachLessonAccordingToCalenderViewModels,
                       t => t.TeacherTeachLessonId, c => c.TeacherTeachLessonId, (t, c) => new TeacherTeachLessonAccToCalenderInClassViewModel()
                       {
                           PKTeacherTeachLessonAccordingToCalender = t.PKTeacherTeachLessonAccordingToCalender,
                           FkCalenderId = t.FkCalenderId,
                           FkCalenderIdString = t.FkCalenderIdString,
                           TeacherTeachLessonId = t.TeacherTeachLessonId,
                           FkTeacherId = c.FkTeacherId,
                           FkTeacherIdString = c.FkTeacherIdString,
                           PkLessonOfFieldOfNewYearInUnGradeId = c.PkLessonOfFieldOfNewYearInUnGradeId,
                           FkLessonId = c.FkLessonId,
                           FkLessonIdString = c.FkLessonIdString,
                           PkFieldsOfNewYearInUnGradutesId = c.PkFieldsOfNewYearInUnGradutesId,
                           FkFieldId = c.FkFieldId,
                           FkFieldIdString = c.FkFieldIdString,
                           PkUnderGraduteInAcademyYearId = c.PkUnderGraduteInAcademyYearId,
                           AcademyYearId = c.AcademyYearId,
                           AcademyYearString = c.AcademyYearString,
                           FkUnGraduteId = c.FkUnGraduteId,
                           FkUnGraduteIdString = c.FkUnGraduteIdString
                       }).ToList()
                       ;
                }
            }
            return _thisTeacherTeachLessonAccToCalenderInClassViewModels;
        }

        //Fill Classes DataGridveiw
        public IEnumerable<Class> FillClasses()
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                _thisClasses = db.ClassRepository.Get().ToList();
                return _thisClasses;
            }
        }
        //Fill Class Of selected Class
        public IEnumerable<Class> FillSelectedClassess(DataGridView dgvNewAcademyYearAllLessons, IEnumerable<Class> classes)
        {

            int currentCalenderLesson = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells[0].Value.ToString());


            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                if (db.TeacherTeachLessonAccToCalenderInClassRepository.Get(t => t.FkTeacherTeachLessonAccToCalId == currentCalenderLesson).Any())
                {
                    _thisClasses = db.TeacherTeachLessonAccToCalenderInClassRepository.Get(t => t.FkTeacherTeachLessonAccToCalId == currentCalenderLesson)
                       .Join(classes, t => t.FkClassId, c => c.PkClassId, (t, c) => c).ToList();
                }
                else
                {
                    _thisClasses = null;
                }

            }


            return _thisClasses;
        }
        //filter Main Datagridview From textbox Search
        public IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> FileterSearch(IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> calenderLessons, TextBox txtSearch)
        {

            _thisTeacherTeachLessonAccToCalenderInClassViewModels = calenderLessons.Where(t => t.AcademyYearString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkCalenderIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkFieldIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkLessonIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkTeacherIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                || t.FkUnGraduteIdString.Trim().ToLower().Contains(txtSearch.Text.Trim())
                ).ToList();
            return _thisTeacherTeachLessonAccToCalenderInClassViewModels;
        }
        //Insert A selected class to CalenderLessonClass Table
        public int InsertSelectedClassToCalenderLesson(DataGridView dgvNewAcademyYearAllLessons, DataGridView dgvClass)
        {
            int result = -1;
            string attemMessage;
            if (dgvClass.CurrentCell != null && dgvClass.CurrentRow != null && dgvClass.SelectedCells.Count > 0)
            {
                attemMessage = "آیا از انتخاب کلاس  " + dgvClass.CurrentRow.Cells[1].Value +
                    " برای درس " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonIdString"].Value +
                    "  در زمان ارائه درس " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkCalenderIdString"].Value +
                   " که توسط معلم " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkTeacherIdString"].Value +
                   " تدریس میشود در سال تحصیلی " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearName"].Value + " اطمینان دارید؟";
                if (RtlMessageBox.Show(attemMessage, "  انتخاب کلاس برای درس ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int _fkTeacherTeachLessonAccordingToCalender = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PKTeacherTeachLessonAccordingToCalender"].Value.ToString());
                    int _fkCalenderId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkCalenderId"].Value.ToString());
                    int _fkClassId = Convert.ToInt32(dgvClass.CurrentRow.Cells[0].Value.ToString());
                    
                    bool isExistEntity = true;
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        isExistEntity = db.TeacherTeachLessonAccToCalenderInClassRepository.Get(t => t.FkClassId==_fkClassId
                        && t.TeacherTeachLessonAccordingToCalender.FkCalenderId==_fkCalenderId).Any();
                        if (!isExistEntity)
                        {
                            var entity = new TeacherTeachLessonAccToCalenderInClass()
                            {
                                FkTeacherTeachLessonAccToCalId = _fkTeacherTeachLessonAccordingToCalender,
                                FkClassId = _fkClassId
                            };
                            db.TeacherTeachLessonAccToCalenderInClassRepository.Insert(entity);
                            result = db.Save();

                            if (result <= 0)
                            {
                                attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            attemMessage = "عدم امکان انتخاب یک کلاس با زمان و مکان تکراری (در این زمان کلاس پر میباشد)...";
                            RtlMessageBox.Show(attemMessage, "عدم امکان افزودن کلاس زمان تکراری(در این تقویم کلاس پر میباشد)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                attemMessage = "عدم انتخاب یک کلاس برای افزودن به لیست کلاس هایی که درس در آن کلاس تدریس خواهد شد..." +
                    "(ابتدا باید یک ردیف از جدول درس های ارائه شده در سال تحصیلی  انتخاب نمائید)" + "\n";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب کلاس");
            }
            return result;
        }
        //Delete A Selected Class From CalenderLessonClass Table
        public int DeleteSelectedClassFromCalenderLessonClass(DataGridView dgvNewAcademyYearAllLessons, DataGridView dgvSelectedClass)
        {
            int result = -1;
            string attemMessage;
            if (dgvSelectedClass.CurrentCell != null && dgvSelectedClass.CurrentRow != null && dgvSelectedClass.SelectedCells.Count > 0)
            {
                attemMessage = "آیا از حذف کلاس  " + dgvSelectedClass.CurrentRow.Cells[1].Value +
                    " برای درس " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonIdString"].Value +
                    "  در زمان ارائه درس " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkCalenderIdString"].Value +
                   " که توسط معلم " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkTeacherIdString"].Value +
                   " تدریس میشود در سال تحصیلی " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearName"].Value + " اطمینان دارید؟";
                if (RtlMessageBox.Show(attemMessage, "  انتخاب کلاس برای حذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int _fkTeacherTeachLessonAccordingToCalender = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PKTeacherTeachLessonAccordingToCalender"].Value.ToString());
                    int _fkClassId = Convert.ToInt32(dgvSelectedClass.CurrentRow.Cells[0].Value.ToString());
                    
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        var entity= db.TeacherTeachLessonAccToCalenderInClassRepository.Get(t => t.FkTeacherTeachLessonAccToCalId == _fkTeacherTeachLessonAccordingToCalender&& t.FkClassId== _fkClassId).First();
                        db.TeacherTeachLessonAccToCalenderInClassRepository.Delete(entity);
                        result = db.Save();
                        if (result <= 0)
                        {
                            attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                            RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                attemMessage = "عدم انتخاب یک کلاس برای حذف ..." +
                    "(ابتدا باید یک ردیف از جدول درس های ارائه شده در سال تحصیلی  انتخاب نمائید)" + "\n" +
                    "سپس کلاس لیست پایین را انتخاب نمائید. ";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب کلاس");
            }
            return result;
        }
        public void Dispose()
        {
            if (_thisTeacherTeachLessonAccToCalenderInClassViewModels != null)
            {
                _thisTeacherTeachLessonAccToCalenderInClassViewModels = null;
            }
            if (_thisClasses != null)
            {
                _thisClasses = null;
            }
        }

    }
}
