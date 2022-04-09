using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public interface ILessonsOfFileldsOfNewYearInUngradeHandler : IDisposable
    {

        IEnumerable<FieldsOfNewYearInUnGradutesViewModel> FillFieldOfNewYearInUngradeViewModels(Expression<Func<FieldsOfNewYearInUnGradutesViewModel, bool>> where = null);
        IEnumerable<LessonViewModel> FillLessonViewModel(Expression<Func<LessonViewModel, bool>> where = null);
        IEnumerable<LessonViewModel> FillSelectedLessonViewModel(DataGridView dgvNewAcademyYearAllField);
        int GetIdBylessonIdAndFieldOfnewYearInUngradutes(int lessonId, int fieldsOfNewYearInUnGradutesId);
        int InsertLessonToFieldOfNewYear(DataGridView dgvNewAcademyYearAllField, DataGridView dgvLesson );
        int DeleteLessonFromFieldOfNewYear(DataGridView dgvNewAcademyYearAllField, DataGridView dgvSedgvSelectedLessons);
       
    }
}
