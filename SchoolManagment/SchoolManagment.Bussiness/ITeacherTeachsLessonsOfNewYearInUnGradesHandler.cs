using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.Bussiness
{
    public interface ITeacherTeachsLessonsOfNewYearInUnGradesHandler : IDisposable
    {
        IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> FillTeacherTeachsLessonsOfNewYearInUnGradesViewModels(Expression<Func<LessonsOfFileldsOfNewYearInUngrade, bool>> where = null);
        IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> FillTeacherTeachsLessonsOfNewYearInUnGradesViewModels(IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> lessonofFieldviewModel, TextBox txtSeach);
        //Fiil Teacher DataGridView
        IEnumerable<Teacher> FillTeachers(Expression<Func<Teacher, bool>> where = null);
        IEnumerable<Teacher> FillTeachers(DataGridView dgvNewAcademyYearAllLessons, Expression<Func<Teacher, bool>> where = null);
        IQueryable<TeacherCanTeachLesson> GetTeacherCanTeachLessons();
        IEnumerable<Teacher> FillTeachers(IEnumerable<TeacherCanTeachLesson> teacherCanTeachLessons, Expression<Func<Teacher, bool>> where = null);

        IEnumerable<Teacher> FillSelectedTeacherGridview(DataGridView dgvNewAcademyYearAllLessons);
    }
}
