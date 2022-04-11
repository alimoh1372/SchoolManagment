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
    public class TeacherTeachLessonAccordingToCalenderHandler : ITeacherTeachLessonAccordingToCalenderHandler
    {
        private IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> _teacherTeachLessonAccordingToCalenderViewModel;

        private IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> _teacherTeachsLessonsOfNewYearInUnGradesViewModels;
        //Get ViewModel For Fill MainDataGridView
        public IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> FillTeacherLessonCalenderViewModel()
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

            return _teacherTeachLessonAccordingToCalenderViewModel;

        }
        //Get ViewModel For Fill MainDataGridView
        public IEnumerable<ICalenderViewModel> FillSelectedCalenderViewModel(DataGridView dgvNewAcademyYearAllLessons, IEnumerable<ICalenderViewModel> calenderViewModels)
        {
            int SelectedTeacherTeachLessonId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["TeacherTeachLessonId"].Value.ToString());
            IEnumerable<ICalenderViewModel> _calenderViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                _calenderViewModels = db.TeacherTeachLessonAccordingToCalenderRepository.Get(t => t.FKTeacherTeachLessonId == SelectedTeacherTeachLessonId).Join(calenderViewModels, t => t.FkCalenderId, c => c.CalenderId, (t, c) => c).ToList();
                return _calenderViewModels;
            }

        }
        //Filter Main data GridView
        public IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> FilterSearch(IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> teacherTeachLessonAccordingToCalenderViewModel, TextBox txtSearch)
        {
            if (txtSearch.Text.Trim() != string.Empty)
            {
                _teacherTeachLessonAccordingToCalenderViewModel = teacherTeachLessonAccordingToCalenderViewModel.Where(t => t.AcademyYearString.Trim().ToLower().Contains(txtSearch.Text)
            || t.FkFieldIdString.Trim().ToLower().Contains(txtSearch.Text)
            || t.FkLessonIdString.Trim().ToLower().Contains(txtSearch.Text)
            || t.FkTeacherIdString.Trim().ToLower().Contains(txtSearch.Text)
            || t.FkUnGraduteIdString.Trim().ToLower().Contains(txtSearch.Text)).ToList();
                return _teacherTeachLessonAccordingToCalenderViewModel;
            }
            else
            {
                return teacherTeachLessonAccordingToCalenderViewModel;
            }

        }


        //Insert Use DataGridViewInforMation

        public int InsertTeacherLessonCalender(DataGridView dgvNewAcademyYearAllLessons, DataGridView dgvCalenders)
        {
            int result = -1;
            string attemMessage;
            if (dgvCalenders.CurrentCell != null && dgvCalenders.CurrentRow != null && dgvCalenders.SelectedCells.Count > 0)
            {
                attemMessage = "آیا از انتخاب تویم  " + dgvCalenders.CurrentRow.Cells[1].Value + " برای زمان ارائه درس   " +
                    dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonIdString"].Value + " که توسط معلم "
                    + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkTeacherIdString"].Value +
                    " تدریس میشود در سال تحصیلی " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearName"].Value + " اطمینان دارید؟";
                if (RtlMessageBox.Show(attemMessage, "  انتخاب تقویم برای تخصیص تقویم به درس ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int _fkTeacherTeachLessonId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["TeacherTeachLessonId"].Value.ToString());
                    int _fkCalenderId = Convert.ToInt32(dgvCalenders.CurrentRow.Cells[0].Value.ToString());
                    bool isExistEntity = true;
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        isExistEntity = db.TeacherTeachLessonAccordingToCalenderRepository.Get(t => t.FKTeacherTeachLessonId == _fkTeacherTeachLessonId && t.FkCalenderId == _fkCalenderId).Any();
                        if (!isExistEntity)
                        {
                            TeacherTeachLessonAccordingToCalender entity = new TeacherTeachLessonAccordingToCalender()
                            {
                                FKTeacherTeachLessonId = _fkTeacherTeachLessonId,
                                FkCalenderId = _fkCalenderId
                            };
                            db.TeacherTeachLessonAccordingToCalenderRepository.Insert(entity);
                            result = db.Save();

                            if (result <= 0)
                            {
                                attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            attemMessage = "برای این درس تقویم انتخاب شده وجود دارد.امکان افزودن تقویم تکراری  به لیست تقویم های انتخاب شده به درس وجود ندادر....";
                            RtlMessageBox.Show(attemMessage, "عدم امکان افزودن تقویم تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                attemMessage = "عدم انتخاب یک تقویم برای افزودن به لیست تقویم هایی که درس در آن تقویم قابل ارائه میباشد." +
                    "(ابتدا باید یک ردیف از جدول درس های ارائه شده در سال تحصیلی جدید انتخاب نمائید)" + "\n";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب تقویم");
            }
            return result;
        }
        //Delete User DataGridView Informations
        public int DeleteFromTeacherLessonCalender(DataGridView dgvNewAcademyYearAllLessons, DataGridView dgvSelectedCalenders)
        {
            int result = -1;
            string attemMessage;
            if (dgvSelectedCalenders.CurrentCell != null && dgvSelectedCalenders.CurrentRow != null && dgvSelectedCalenders.SelectedCells.Count > 0)
            {
                attemMessage = "آیا از حذف تویم  " + dgvSelectedCalenders.CurrentRow.Cells[1].Value + " برای زمان ارائه درس   " +
                    dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonIdString"].Value + " که توسط معلم "
                    + dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkTeacherIdString"].Value +
                    " تدریس میشود در سال تحصیلی " + dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearName"].Value + " اطمینان دارید؟";
                if (RtlMessageBox.Show(attemMessage, " انتخاب تقویم برای حذف از تقویم های تخصیصی ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int _fkTeacherTeachLessonId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["TeacherTeachLessonId"].Value.ToString());
                    int _fkCalenderId = Convert.ToInt32(dgvSelectedCalenders.CurrentRow.Cells[0].Value.ToString());
                    TeacherTeachLessonAccordingToCalender entity;
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        entity = db.TeacherTeachLessonAccordingToCalenderRepository.Get(t => t.FKTeacherTeachLessonId == _fkTeacherTeachLessonId && t.FkCalenderId == _fkCalenderId).First();
                        db.TeacherTeachLessonAccordingToCalenderRepository.Delete(entity);
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
                attemMessage = "عدم انتخاب یک تقویم برای حذف از  لیست تقویم هایی که درس در آن تقویم قابل ارائه میباشد." + "\n" +
                    "(ابتدا باید یک ردیف از جدول درس های ارائه شده در سال تحصیلی جدید انتخاب نمائید)" + "\n" +
                     "پس از آن از لیست تقویم های انتخاب شده برای درس یک تقویم را انتخاب نمائید(لیست پایین)";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب تقویم از لیست تقویم های تخصیص داده شده");
            }
            return result;
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
