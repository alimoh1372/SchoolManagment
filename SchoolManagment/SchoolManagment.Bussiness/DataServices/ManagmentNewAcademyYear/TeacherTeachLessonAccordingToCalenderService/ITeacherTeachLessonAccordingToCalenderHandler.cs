using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public interface ITeacherTeachLessonAccordingToCalenderHandler : IDisposable
    {

        IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> FillTeacherLessonCalenderViewModel();

        IEnumerable<ICalenderViewModel> FillSelectedCalenderViewModel(DataGridView dgvNewAcademyYearAllLessons, IEnumerable<ICalenderViewModel> calenderViewModels);

        IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> FilterSearch(IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> teacherTeachLessonAccordingToCalenderViewModel,
            TextBox txtSearch);

        int InsertTeacherLessonCalender(DataGridView dgvNewAcademyYearAllLessons, DataGridView dgvCalenders);

        int DeleteFromTeacherLessonCalender(DataGridView dgvNewAcademyYearAllLessons,DataGridView dgvSelectedCalenders);
    }
}
