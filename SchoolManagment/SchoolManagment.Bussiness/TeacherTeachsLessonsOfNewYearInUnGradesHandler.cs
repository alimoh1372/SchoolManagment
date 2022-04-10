using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.ViewModel;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.DataLayer;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public class TeacherTeachsLessonsOfNewYearInUnGradesHandler : ITeacherTeachsLessonsOfNewYearInUnGradesHandler
    {
        IEnumerable<TeacherTeachsLessonsOfNewYearInUnGradesViewModel> teacherTeachsLessonsOfNewYearInUnGrades;
        public IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> FillTeacherTeachsLessonsOfNewYearInUnGradesViewModels(Expression<Func<LessonsOfFileldsOfNewYearInUngrade, bool>> where = null)
        {
            IEnumerable<LessonsOfFileldsOfNewYearInUngrade> lessonsOfFileldsOfNewYearInUngrades;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                var query = db.LessonsOfFileldsOfNewYearInUngradeRepository.Get().AsQueryable();
                if (where == null)
                {
                    teacherTeachsLessonsOfNewYearInUnGrades = query.Select(lsOf => new TeacherTeachsLessonsOfNewYearInUnGradesViewModel()
                    {
                        PkLessonOfFieldOfNewYearInUnGradeId = lsOf.PkLessonOfFieldOfNewYearInUnGradeId,
                        FkLessonId = lsOf.FkLessonId,
                        FkLessonIdString = lsOf.Lesson.LessonName,
                        PkFieldsOfNewYearInUnGradutesId = lsOf.FieldsOfNewYearInUnGradute.PkFieldsOfNewYearInUnGradutesId,
                        FkFieldId = lsOf.FieldsOfNewYearInUnGradute.FkFieldId,
                        FkFieldIdString = lsOf.FieldsOfNewYearInUnGradute.Field.FieldName,
                        PkUnderGraduteInAcademyYearId = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.PkUnderGraduteInAcademyYearId,
                        AcademyYearId = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.FkAcademyYearId,
                        AcademyYearString = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.AcademyYear.AcademyYearName,
                        FkUnGraduteId = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.FkUnGraduteId,
                        FkUnGraduteIdString = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.UnderGradute.UnGraduteName + " " + lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.UnderGradute.Grade.GradeName,
                    });
                }
                else
                {
                    teacherTeachsLessonsOfNewYearInUnGrades = query.Where(where).Select(lsOf => new TeacherTeachsLessonsOfNewYearInUnGradesViewModel()
                    {
                        PkLessonOfFieldOfNewYearInUnGradeId = lsOf.PkLessonOfFieldOfNewYearInUnGradeId,
                        FkLessonId = lsOf.FkLessonId,
                        FkLessonIdString = lsOf.Lesson.LessonName,
                        PkFieldsOfNewYearInUnGradutesId = lsOf.FieldsOfNewYearInUnGradute.PkFieldsOfNewYearInUnGradutesId,
                        FkFieldId = lsOf.FieldsOfNewYearInUnGradute.FkFieldId,
                        FkFieldIdString = lsOf.FieldsOfNewYearInUnGradute.Field.FieldName,
                        PkUnderGraduteInAcademyYearId = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.PkUnderGraduteInAcademyYearId,
                        AcademyYearId = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.FkAcademyYearId,
                        AcademyYearString = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.AcademyYear.AcademyYearName,
                        FkUnGraduteId = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.FkUnGraduteId,
                        FkUnGraduteIdString = lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.UnderGradute.UnGraduteName + " " + lsOf.FieldsOfNewYearInUnGradute.UnderGradutesInNewAcademyYear.UnderGradute.Grade.GradeName,
                    });
                }
                return teacherTeachsLessonsOfNewYearInUnGrades.ToList();
            }
        }
        //For FilterText
        public IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> FillTeacherTeachsLessonsOfNewYearInUnGradesViewModels(IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> lessonofFieldviewModel, TextBox txtSeach)
        {
            IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> lessonsOfField;
            if (txtSeach.Text.Trim() == string.Empty)
            {
                lessonsOfField = lessonofFieldviewModel;
            }
            else
            {
                lessonsOfField = lessonofFieldviewModel.Where(lsof => lsof.AcademyYearString.Trim().ToLower().Contains(txtSeach.Text.Trim())
                    || lsof.FkFieldIdString.Trim().ToLower().Contains(txtSeach.Text.Trim())
                    || lsof.FkLessonIdString.Trim().ToLower().Contains(txtSeach.Text.Trim())
                    || lsof.FkUnGraduteIdString.Trim().ToLower().Contains(txtSeach.Text.Trim())).ToList();
            }
            return lessonsOfField;
        }

        //For Set Teacher DataGridView 

        public IEnumerable<Teacher> FillTeachers(Expression<Func<Teacher, bool>> where = null)
        {
            IQueryable<Teacher> teachers;
            IEnumerable<Teacher> resultTeachers;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                teachers = db.TeacherRepository.Get().AsQueryable();
                if (where == null)
                {
                    resultTeachers = teachers.ToList();
                }
                else
                {
                    resultTeachers = teachers.Where(where).ToList();
                }
            }
            return resultTeachers;
        }

        // Fill the Teacher list for teacher Datagridview
        public IEnumerable<Teacher> FillTeachers(DataGridView dgvNewAcademyYearAllLessons, Expression<Func<Teacher, bool>> where = null)
        {
            IQueryable<TeacherCanTeachLesson> teachersCan;
            IEnumerable<Teacher> resultTeachers;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                teachersCan = db.TeacherCanTeachLessonRepository.GetIncludeEntities(t => t.Teacher).AsQueryable();
                if (where == null)
                {
                    int _fkLessonId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonId"].Value.ToString());
                    resultTeachers = teachersCan.Where(t => t.FkLessonId == _fkLessonId).AsEnumerable().Select(tc => new Teacher()
                    {
                        TeacherId = tc.Teacher.TeacherId,
                        TeacherName = tc.Teacher.TeacherName,
                        TeacherEducation = tc.Teacher.TeacherEducation
                    }).ToList();
                }
                else
                {
                    int _fkLessonId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonId"].Value.ToString());
                    resultTeachers = teachersCan.Where(t => t.FkLessonId == _fkLessonId).Select(tc => new Teacher()
                    {
                        TeacherId = tc.Teacher.TeacherId,
                        TeacherName = tc.Teacher.TeacherName,
                        TeacherEducation = tc.Teacher.TeacherEducation
                    }).AsQueryable().Where(where).ToList();
                }
            }
            return resultTeachers;
        }
        //Get All TeachersCanTeachLesson
        public IQueryable<TeacherCanTeachLesson> GetTeacherCanTeachLessons()
        {
            IEnumerable<TeacherCanTeachLesson> _teacherCanTeachLessons;
            IQueryable<TeacherCanTeachLesson> _teacherCanTeachIqueryable;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                _teacherCanTeachLessons = db.TeacherCanTeachLessonRepository.GetIncludeEntities(t => t.Teacher);
                _teacherCanTeachIqueryable = _teacherCanTeachLessons.AsQueryable();

            }
            return _teacherCanTeachIqueryable;
        }

        //Fill the teacher DataGridView With Filter
        public IEnumerable<Teacher> FillTeachers(IEnumerable<TeacherCanTeachLesson> teacherCanTeachLessons, Expression<Func<Teacher, bool>> where = null)
        {

            if (where == null)
            {
                return teacherCanTeachLessons.Select(tc => new Teacher()
                {
                    TeacherId = tc.Teacher.TeacherId,
                    TeacherName = tc.Teacher.TeacherName,
                    TeacherEducation = tc.Teacher.TeacherEducation
                });
            }
            else
            {
                return teacherCanTeachLessons.Select(tc => new Teacher()
                {
                    TeacherId = tc.Teacher.TeacherId,
                    TeacherName = tc.Teacher.TeacherName,
                    TeacherEducation = tc.Teacher.TeacherEducation
                }).AsQueryable().Where(where);
            }

        }
        //Fill the selectedteacher DataGridView
        public IEnumerable<Teacher> FillSelectedTeacherGridview(DataGridView dgvNewAcademyYearAllLessons)
        {
            IEnumerable<TeacherTeachsLessonsOfNewYearInUnGrade> _teacherTeachsLessonsOfNewYearInUnGrades;
            IEnumerable<Teacher> _teachers;
            int _fkLessonId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonId"].Value.ToString());
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {

                _teacherTeachsLessonsOfNewYearInUnGrades = db.TeacherTeachsLessonsOfNewYearInUnGradesRepository.Get().AsQueryable();
                _teachers = _teacherTeachsLessonsOfNewYearInUnGrades.Where(tTL => tTL.LessonsOfFileldsOfNewYearInUngrade.FkLessonId == _fkLessonId).Select(tTL => new Teacher()
                {
                    TeacherId = tTL.Teacher.TeacherId,
                    TeacherName = tTL.Teacher.TeacherName,
                    TeacherEducation = tTL.Teacher.TeacherEducation
                }).ToList();
                return _teachers;
            }
        }

        // Insert Selected Teacher From Teacher datagrid view Into The selected teachers for teach lesson

        public virtual int InsertIntoTeacherTeachsLesson(DataGridView dgvNewAcademyYearAllLessons, DataGridView dgvTeacher)
        {

            int result = -1;
            string attemMessage;
            if (dgvTeacher.CurrentCell != null && dgvTeacher.CurrentRow != null && dgvTeacher.SelectedCells.Count > 0)
            {
                attemMessage = "آیا از انتخاب معلم  " + dgvTeacher.CurrentRow.Cells[1].Value + "  برای تدریس درس " + dgvNewAcademyYearAllLessons.CurrentRow.Cells[2].Value + " در سال تحصیلی " +
                dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearName"].Value + " اطمینان دارید؟";
                if (RtlMessageBox.Show(attemMessage, "  انتخاب معلم برای تدریس ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int fkLessonOfFieldOfNewYearInUnGradeId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PkLessonOfFieldOfNewYearInUnGradeId"].Value.ToString());
                    int lessonId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonId"].Value.ToString());
                    int selectedTeacherId = Convert.ToInt32(dgvTeacher.CurrentRow.Cells[0].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        bool isExistBefor;
                        isExistBefor = db.TeacherTeachsLessonsOfNewYearInUnGradesRepository.Get(tlo => tlo.FkLessonOfFieldsOfNewYearInUnGrade == fkLessonOfFieldOfNewYearInUnGradeId &&
                          tlo.LessonsOfFileldsOfNewYearInUngrade.FkLessonId == lessonId
                          && tlo.FkTeacherId == selectedTeacherId).Any();
                        if (!isExistBefor)
                        {
                            TeacherTeachsLessonsOfNewYearInUnGrade teacherTolesson = new TeacherTeachsLessonsOfNewYearInUnGrade()
                            {
                                FkTeacherId = selectedTeacherId,
                                FkLessonOfFieldsOfNewYearInUnGrade = fkLessonOfFieldOfNewYearInUnGradeId
                            };
                            db.TeacherTeachsLessonsOfNewYearInUnGradesRepository.Insert(teacherTolesson);
                            result = db.Save();
                            if (result <= 0)
                            {
                                attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            attemMessage = "عدم امکان افزودن معلم تکراری  به لیست معلمینی که میتوانند این درس را تدریس کنند...";
                            RtlMessageBox.Show(attemMessage, "عدم امکان افزودن معلم تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            else
            {
                attemMessage = "عدم انتخاب یک معلم برای افزودن به لیست معلمانی که میتوانند این درس را تدریس کنند در سال تحصیلی جدید" +
                    "(ابتدا باید یک ردیف از جدول درس های ارائه شده در سال تحصیلی جدید انتخاب نمائید)" + "\n" +
                    "در صورتی که معلمی برای شما نمایش داده نشده" +
                    "باید از منو مدیریت اطلاعات-->درس های قابل تدریس معلم -->معلمی را به معلم هایی که میتوانند این درس را تدریس کنند اضافه نمائید..";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب معلم");
            }
            return result;

        }

        //Delete the selected teacher from list of teacher teaches the lesson in this year

        public int DeleteTeacherFromTeacherList(DataGridView dgvNewAcademyYearAllLessons, DataGridView dgvdgvSelectedTeacher)
        {
            int result = -1;
            string attemMessage;
            if (dgvdgvSelectedTeacher.CurrentCell != null && dgvdgvSelectedTeacher.CurrentRow != null && dgvdgvSelectedTeacher.SelectedCells.Count > 0)
            {
                attemMessage = "آیا از حذف معلم  " + dgvdgvSelectedTeacher.CurrentRow.Cells[1].Value + "  از لیست معلمانی که میتوانند درس  " + dgvNewAcademyYearAllLessons.CurrentRow.Cells[2].Value + " را در سال تحصیلی " +
                dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearName"].Value + "درس بدهند، اطمینان دارید؟";
                if (RtlMessageBox.Show(attemMessage, "انتخاب معلم برای تدریس", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int fkLessonOfFieldOfNewYearInUnGradeId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PkLessonOfFieldOfNewYearInUnGradeId"].Value.ToString());
                    int lessonId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkLessonId"].Value.ToString());
                    int selectedTeacherId = Convert.ToInt32(dgvdgvSelectedTeacher.CurrentRow.Cells[0].Value.ToString());
                    int pkTeacherTeachLesson = -1;
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        pkTeacherTeachLesson = db.TeacherTeachsLessonsOfNewYearInUnGradesRepository.Get(tlo => tlo.FkLessonOfFieldsOfNewYearInUnGrade == fkLessonOfFieldOfNewYearInUnGradeId
                         && tlo.FkTeacherId == selectedTeacherId).First().TeacherTeachLessonId;
                        db.TeacherTeachsLessonsOfNewYearInUnGradesRepository.Delete(pkTeacherTeachLesson);
                        result= db.Save();
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
                attemMessage = "عدم انتخاب یک معلم برای حذف از لیست معلمانی که میتوانند این درس را تدریس کنند در سال تحصیلی جدید" +
                    "(ابتدا باید یک ردیف از جدول معلمان لیست پایین انتخاب نمائید سپس دکمه حذف را بزنید)" + "\n";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب معلم جهت حذف از لیست پایین");
            }
            return result;
        }
        public void Dispose()
        {
            if (teacherTeachsLessonsOfNewYearInUnGrades != null)
            {
                teacherTeachsLessonsOfNewYearInUnGrades = null;
            }
        }

    }
}
