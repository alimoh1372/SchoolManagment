using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public interface IFieldsOfNewYearInUnGradutesHandler:IDisposable
    {
        int InsertFieldToUngraduteInNewYear(DataGridView academyDataGridView, DataGridView dgvSelectedUnGradeInNewYear, DataGridView dgvFields);
        int DeleteFieldFromUnGraduteInNewYear(DataGridView academyDataGridView, DataGridView dgvSelectedUnGradeInNewYear,DataGridView dgvSelectedFields);
        int GetIdByFieldIdAndUnGraduteInNewYearId(int fieldId,int unGruduteInNewYear);
    }
}
