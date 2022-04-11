using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.ViewModel;
using SchoolManagment.DataLayer.DatabaseModel;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public interface ITeacherTeachLessonAccToCalenderInClassHandler:IDisposable
    {
        IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> FillLessonCalenderViewModel();
        IEnumerable<Class> FillClasses();

        IEnumerable<Class> FillSelectedClassess(DataGridView dgvNewAcademyYearAllLessons,IEnumerable<Class> classes);
        IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> FileterSearch(IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> calenderLessons, TextBox txtSearch);

        int InsertSelectedClassToCalenderLesson(DataGridView dgvNewAcademyYearAllLessons,DataGridView dgvClass);

        int DeleteSelectedClassFromCalenderLessonClass(DataGridView dgvNewAcademyYearAllLessons, DataGridView dgvSelectedClass);
    }
}
