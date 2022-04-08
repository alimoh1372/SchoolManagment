using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public interface IUnderGradutesInNewAcademyYearHandler:IDisposable
    {
        IEnumerable<UnderGradutesViewModel> GetUnderGradutesViewModels(int AcademyYearId);
        int InsertUnGradeToAcademyYear(DataGridView AcademyDataGridView, DataGridView UnderGradutesDataGridView);
        int DeleteUnGradeFromAcademyYear(DataGridView AcademyDataGridView, DataGridView selectedUnGradutedDataGridView);



    }
}
