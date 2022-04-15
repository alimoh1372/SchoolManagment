using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
   public interface IScoreOfStudentsForLessonsHandler:IDisposable
    {
        IEnumerable<ITeacherMenoAllLessonsClassViewModel> GetAllLessonClassWithPresentForeignKey();
        IEnumerable<IScoreStudentViewModel> GetScoreStudentViewModels(DataGridView dgvNewAcademyYearAllLessons);
        IEnumerable<ITeacherMenoAllLessonsClassViewModel> FilterDgvAll(IEnumerable<ITeacherMenoAllLessonsClassViewModel> allTeacherMenoViewModels, TextBox txtSearch);
        IEnumerable<IScoreStudentViewModel> FilterDgvStudent(IEnumerable<IScoreStudentViewModel> scoreStudentViewModels, TextBox txtStudentSearch);

    }
}
