using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public interface IStudentReportCardDetailHandler : IDisposable
    {
        IEnumerable<IStudentViewModel> GetStudentViewModel();
        IEnumerable<ITeacherMenoAllLessonsClassViewModel> GetAllLessonClassWithPresentForeignKey(DataGridView dgvStudent);
        IEnumerable<IScoreOfStudentsForLessonViewModel> GetStudentReportCardDetailViewModelsFromScoreTable(Expression<Func<ScoreOfStudentsForLesson, bool>> where = null);
    }
}
