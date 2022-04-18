using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public interface IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler : IDisposable
    {
        int StudentsInFieldNumber(int fieldId);
        int StudentsInFieldNumber(Field field);
        IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> FillStudentsClassInCalenderViewModel();
        IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> FilterSearchGridView(IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> studentclassInCalenderViewModels,
            TextBox txtSearch);
        IEnumerable<IStudentViewModel> GetStudentsViewModel();
        IEnumerable<IStudentViewModel> FillStudentDataGridView(DataGridView dgvNewAcademyYearAllLessons
           , IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> studentClassViewModel
           , IEnumerable<IStudentViewModel> studentViewModels);
        bool checkIsStudentAssigned(int studentId, int fkTeacherTeachLessonAccToCalInClassId);
        IEnumerable<IStudentViewModel> FilterSearch(IEnumerable<IStudentViewModel> AllStudentViewModels, TextBox txtSearch);
        IEnumerable<IStudentViewModel> FilterSearch(IEnumerable<IStudentViewModel> AllStudentViewModels, TextBox txtSearch, bool? SelectAssignedStudents = null);
        bool? SelectAssignedStudents(RadioButton rdbAllStudent, RadioButton rdbSelectedStudent);
        IEnumerable<IStudentViewModel> GetSelectedStudent(DataGridView dgvNewAcademyYearAllLessons, IEnumerable<IStudentViewModel> studentDgvStudentViewModel);
        bool InsertDeleteSyncStudentsToClass(DataGridView dgvNewAcademyYearAllLessons, IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> classCalenderViewModel,
           DataGridView dgvAllStudentInThisField,
           IEnumerable<IStudentViewModel> _dgvAllStudentInFieldViewModels,
           IEnumerable<IStudentViewModel> selectedStudentForDgvSelectedStudent);
    }
}
