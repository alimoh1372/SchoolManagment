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
               _teachers= _teacherTeachsLessonsOfNewYearInUnGrades.Where(tTL => tTL.LessonsOfFileldsOfNewYearInUngrade.FkLessonId == _fkLessonId).Select(tTL => new Teacher()
                {
                    TeacherId= tTL.Teacher.TeacherId,
                    TeacherName=tTL.Teacher.TeacherName,
                    TeacherEducation=tTL.Teacher.TeacherEducation
                }).ToList();
                return _teachers;
            }
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
