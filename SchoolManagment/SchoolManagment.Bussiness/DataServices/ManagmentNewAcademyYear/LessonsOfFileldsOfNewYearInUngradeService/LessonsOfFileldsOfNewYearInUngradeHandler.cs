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
    public class LessonsOfFileldsOfNewYearInUngradeHandler : ILessonsOfFileldsOfNewYearInUngradeHandler
    {
        IEnumerable<FieldsOfNewYearInUnGradutesViewModel> fieldsOfNewYearInUnGradutesViewModels;
        IEnumerable<LessonViewModel> lessonViewModels;
        public virtual IEnumerable<FieldsOfNewYearInUnGradutesViewModel> FillFieldOfNewYearInUngradeViewModels(Expression<Func<FieldsOfNewYearInUnGradutesViewModel, bool>> where = null)
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                IEnumerable<FieldsOfNewYearInUnGradute> fieldsOfNewYearInUnGradutes = db.FieldsOfNewYearInUnGradutesRepository.GetIncludeEntities(fi => fi.Field, fi => fi.UnderGradutesInNewAcademyYear.UnderGradute, fi => fi.UnderGradutesInNewAcademyYear.AcademyYear).AsQueryable();

                if (where == null)
                {

                    fieldsOfNewYearInUnGradutesViewModels = fieldsOfNewYearInUnGradutes.Select(fi => new FieldsOfNewYearInUnGradutesViewModel()
                    {
                        AcademyYearId = fi.UnderGradutesInNewAcademyYear.FkAcademyYearId,
                        AcademyYearString = fi.UnderGradutesInNewAcademyYear.AcademyYear.AcademyYearName,
                        FkUnderGraduteInAcademyYearId = fi.UnderGradutesInNewAcademyYear.FkUnGraduteId,
                        FkUnderGraduteInAcademyYearIdString = fi.UnderGradutesInNewAcademyYear.UnderGradute.UnGraduteName + " " + fi.UnderGradutesInNewAcademyYear.UnderGradute.Grade.GradeName,
                        FkFieldsOfNewYearInUnGradutesId = fi.FkFieldId,
                        FkFieldsOfNewYearInUnGradutesIdString = fi.Field.FieldName
                    }).ToList();
                }
                else
                {
                    fieldsOfNewYearInUnGradutesViewModels = fieldsOfNewYearInUnGradutes
                        .Select(fi => new FieldsOfNewYearInUnGradutesViewModel()
                        {
                            AcademyYearId = fi.UnderGradutesInNewAcademyYear.FkAcademyYearId,
                            AcademyYearString = fi.UnderGradutesInNewAcademyYear.AcademyYear.AcademyYearName,
                            FkUnderGraduteInAcademyYearId = fi.UnderGradutesInNewAcademyYear.FkUnGraduteId,
                            FkUnderGraduteInAcademyYearIdString = fi.UnderGradutesInNewAcademyYear.UnderGradute.UnGraduteName + " " + fi.UnderGradutesInNewAcademyYear.UnderGradute.Grade.GradeName,
                            FkFieldsOfNewYearInUnGradutesId = fi.FkFieldId,
                            FkFieldsOfNewYearInUnGradutesIdString = fi.Field.FieldName
                        }).AsQueryable().Where(where).ToList();

                }
                return fieldsOfNewYearInUnGradutesViewModels;
            }

        }
        public IEnumerable<LessonViewModel> FillLessonViewModel(Expression<Func<LessonViewModel, bool>> where = null)
        {

            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                if (where == null)
                {
                    lessonViewModels = db.LessonRepository.FillViewModel().ToList();
                }
                else
                {
                    lessonViewModels = db.LessonRepository.FillViewModel().AsQueryable().Where(where).ToList();
                }
            }
            return lessonViewModels;
        }
        public IEnumerable<LessonViewModel> FillSelectedLessonViewModel(DataGridView dgvNewAcademyYearAllField)
        {

            IEnumerable<LessonsOfFileldsOfNewYearInUngrade> lessonsOfFileldsOfNewYearInUngrades;
            IEnumerable<LessonViewModel> lessonViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                int FkFieldOfNewYearInUnGraduteId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[0].Value.ToString());
                int fkAcademyYearId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells["AcademyYearId"].Value.ToString());
                int fkUnGraduteId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells["FkUnderGraduteInAcademyYearId"].Value.ToString());
                lessonsOfFileldsOfNewYearInUngrades = db.LessonsOfFileldsOfNewYearInUngradeRepository.GetIncludeEntities(ls => ls.Lesson, ls => ls.FieldsOfNewYearInUnGradute)
                      .Where(ls => ls.Lesson.Field.FKUnGraduteId == ls.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.FkUnGraduteId
                      && ls.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.FkAcademyYearId == fkAcademyYearId
                      && ls.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.FkUnGraduteId == fkUnGraduteId);
                string FileldIdString = dgvNewAcademyYearAllField.CurrentRow.Cells[1].Value.ToString();
                lessonViewModels = lessonsOfFileldsOfNewYearInUngrades.Select(ls => new LessonViewModel()
                {
                    FkFileldId = ls.FieldsOfNewYearInUnGradute.PkFieldsOfNewYearInUnGradutesId,
                    FkFileldIdString = FileldIdString,
                    LessonName = ls.Lesson.LessonName,
                    LessonUnits = ls.Lesson.LessonUnits,
                    PKLessonId = ls.Lesson.PKLessonId
                });
                return lessonViewModels.ToList();
            }
        }

        public int GetIdBylessonIdAndFieldOfnewYearInUngradutes(int lessonId, int fieldsOfNewYearInUnGradutesId)
        {
            int result = -1;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                if (db.LessonsOfFileldsOfNewYearInUngradeRepository.Get(leO => leO.FkLessonId == lessonId && leO.FkFieldOfNewYearInUnGraduteId == fieldsOfNewYearInUnGradutesId).Any())
                {
                    result = db.LessonsOfFileldsOfNewYearInUngradeRepository.Get(leO => leO.FkLessonId == lessonId && leO.FkFieldOfNewYearInUnGraduteId == fieldsOfNewYearInUnGradutesId).First().PkLessonOfFieldOfNewYearInUnGradeId;
                }
            }
            return result;
        }
        public virtual int InsertLessonToFieldOfNewYear(DataGridView dgvNewAcademyYearAllField, DataGridView dgvLesson)
        {
            int result = -1;
            string attemMessage;
            if (dgvLesson.CurrentCell != null && dgvLesson.CurrentRow != null && dgvLesson.SelectedCells.Count > 0)
            {
                attemMessage = "آیا از افزودن درس " + dgvLesson.CurrentRow.Cells[1].Value + "  رشته ی " + dgvNewAcademyYearAllField.CurrentRow.Cells[1].Value + " درس سال تحصیلی " +
                     dgvNewAcademyYearAllField.CurrentRow.Cells[3].Value + " اطمینان دارید؟";
                if (RtlMessageBox.Show(attemMessage, "افزودن درس ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int academyYearId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[2].Value.ToString());
                    int unGradeId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[4].Value.ToString());
                    int fieldId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[0].Value.ToString());
                    int FkUnGradutesInNewYearId;
                    int fkFieldOfNewYearInUnGraduteId;
                    int pkLessonOfFieldOfNewYearInUnGradeId = -1;
                    int selectedLessonId = Convert.ToInt32(dgvLesson.CurrentRow.Cells[0].Value.ToString());
                    using (IFieldsOfNewYearInUnGradutesHandler flHandler = new FieldsOfNewYearInUnGradutesHandler())
                    {
                        using (IUnderGradutesInNewAcademyYearHandler unHandler = new UnderGradutesInNewAcademyYearHandler())
                        {
                            FkUnGradutesInNewYearId = unHandler.GetUnderGradutesInNewAcademyYearId(academyYearId, unGradeId);
                        }
                        fkFieldOfNewYearInUnGraduteId = flHandler.GetIdByFieldIdAndUnGraduteInNewYearId(fieldId, FkUnGradutesInNewYearId);
                    }
                    pkLessonOfFieldOfNewYearInUnGradeId = GetIdBylessonIdAndFieldOfnewYearInUngradutes(selectedLessonId, fkFieldOfNewYearInUnGraduteId);
                    if (pkLessonOfFieldOfNewYearInUnGradeId <= 0)
                    {
                        LessonsOfFileldsOfNewYearInUngrade lessonsOfFileldsOfNewYearInUngrade = new LessonsOfFileldsOfNewYearInUngrade()
                        {
                            FkFieldOfNewYearInUnGraduteId = fkFieldOfNewYearInUnGraduteId,
                            FkLessonId = selectedLessonId
                        };
                        using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                        {
                            db.LessonsOfFileldsOfNewYearInUngradeRepository.Insert(lessonsOfFileldsOfNewYearInUngrade);
                            result = db.Save();
                            if (result <= 0)
                            {
                                attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        attemMessage = "عدم امکان افزودن درس  تکراری به رشته.این درس قبلا در این رشته ارائه شده است.";
                        RtlMessageBox.Show(attemMessage, "عدم امکان افزودن درس تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                attemMessage = "عدم انتخاب یک درس برای افزودن به رشته ی سال تحصیلی جدید" +
                    "(ابتدا باید یک ردیف از رشته های سال تحصیلی جدید انتخاب نمائید)" + "\n" +
                    "در صورتی که درسی برای شما نمایش داده نشده" +
                    "باید از منو مدیریت اطلاعات-->درس -->یک درس به این رشته اضافه نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب درس");
            }
            return result;
        }

        public int DeleteLessonFromFieldOfNewYear(DataGridView dgvNewAcademyYearAllField, DataGridView dgvSedgvSelectedLessons)
        {
            int result = -1;
            string attemMessage;
            if (dgvSedgvSelectedLessons.CurrentCell != null && dgvSedgvSelectedLessons.CurrentRow != null && dgvSedgvSelectedLessons.SelectedCells.Count > 0)
            {
                attemMessage = "آیا از حذف درس " + dgvSedgvSelectedLessons.CurrentRow.Cells[1].Value + " در رشته ی " + dgvNewAcademyYearAllField.CurrentRow.Cells[1].Value + " در سال تحصیلی " +
                     dgvNewAcademyYearAllField.CurrentRow.Cells[3].Value + " اطمینان دارید؟";
                if (RtlMessageBox.Show(attemMessage, "حذف  درس ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int pkLessonOfFieldOfNewYearInUnGradeId = -1;
                    int academyYearId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[2].Value.ToString());
                    int unGradeId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[4].Value.ToString());
                    int fieldId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[0].Value.ToString());
                    int FkUnGradutesInNewYearId;
                    int fkFieldOfNewYearInUnGraduteId;
                    int selectedLessonId = Convert.ToInt32(dgvSedgvSelectedLessons.CurrentRow.Cells[0].Value.ToString());
                    using (IFieldsOfNewYearInUnGradutesHandler flHandler = new FieldsOfNewYearInUnGradutesHandler())
                    {
                        using (IUnderGradutesInNewAcademyYearHandler unHandler = new UnderGradutesInNewAcademyYearHandler())
                        {
                            FkUnGradutesInNewYearId = unHandler.GetUnderGradutesInNewAcademyYearId(academyYearId, unGradeId);
                        }
                        fkFieldOfNewYearInUnGraduteId = flHandler.GetIdByFieldIdAndUnGraduteInNewYearId(fieldId, FkUnGradutesInNewYearId);
                    }
                    pkLessonOfFieldOfNewYearInUnGradeId = GetIdBylessonIdAndFieldOfnewYearInUngradutes(selectedLessonId, fkFieldOfNewYearInUnGraduteId);
                    if (pkLessonOfFieldOfNewYearInUnGradeId > 0)
                    {
                        using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                        {
                            db.LessonsOfFileldsOfNewYearInUngradeRepository.Delete(pkLessonOfFieldOfNewYearInUnGradeId);
                            result = db.Save();
                            if (result <= 0)
                            {
                                attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    

                }
            }
            else
            {
                attemMessage = "عدم انتخاب یک درس برای حذف از رشته ی سال تحصیلی جدید" +
                    "(ابتدا باید یک ردیف از رشته های سال تحصیلی جدید انتخاب نمائید)" + "\n" +
                    "سپس از لیست دروس نمایش داده شده در پایین درس مورد نظر را انتخاب نمائید."
                    ;
                RtlMessageBox.Show(attemMessage, "عدم انتخاب درس");
            }
            return result;
        }
        public void Dispose()
        {
            if (fieldsOfNewYearInUnGradutesViewModels != null)
            {
                fieldsOfNewYearInUnGradutesViewModels = null;
            }
            if (lessonViewModels != null)
            {
                lessonViewModels = null;
            }
        }

    }
}
