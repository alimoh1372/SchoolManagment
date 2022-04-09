using SchoolManagment.Bussiness;
using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.App
{
    public partial class FormLessonsOfFileldsOfNewYearInUngrade : Form
    {

        public FormLessonsOfFileldsOfNewYearInUngrade()
        {
            InitializeComponent();
            dgvNewAcademyYearAllField.AutoGenerateColumns = false;
            dgvLesson.AutoGenerateColumns = false;
            dgvSelectedLessons.AutoGenerateColumns = false;
        }
        private void btnAddNewLesson_Click(object sender, EventArgs e)
        {
            int result = -1;
            using (LessonsOfFileldsOfNewYearInUngradeHandler lsOfHandler = new LessonsOfFileldsOfNewYearInUngradeHandler())
            {
                result = lsOfHandler.InsertLessonToFieldOfNewYear(dgvNewAcademyYearAllField, dgvLesson);
                if (result > 0)
                {
                    ReloadDataAndForm();
                }
            }

        }
        private void btnDeleteSelectedLesson_Click(object sender, EventArgs e)
        {
            int result = -1;
            using (LessonsOfFileldsOfNewYearInUngradeHandler lsOfHandler = new LessonsOfFileldsOfNewYearInUngradeHandler())
            {
                result = lsOfHandler.DeleteLessonFromFieldOfNewYear(dgvNewAcademyYearAllField, dgvSelectedLessons);
                if (result > 0)
                {
                    ReloadDataAndForm();
                }
            }

        }
        private void FormLessonsOfFileldsOfNewYearInUngrade_Load(object sender, EventArgs e)
        {
            ReloadDataAndForm();

        }

        private void ReloadDataAndForm()
        {
            using (LessonsOfFileldsOfNewYearInUngradeHandler lessonsOfFileldsOfNewYearInUngradeHandler = new LessonsOfFileldsOfNewYearInUngradeHandler())
            {
                IEnumerable<FieldsOfNewYearInUnGradutesViewModel> fieldsOfNewYearInUnGradutesViewModels = lessonsOfFileldsOfNewYearInUngradeHandler.FillFieldOfNewYearInUngradeViewModels();
                dgvNewAcademyYearAllField.DataSource = fieldsOfNewYearInUnGradutesViewModels;
                dgvNewAcademyYearAllField.MultiSelect = false;
                dgvNewAcademyYearAllField.CurrentCell = null;
                dgvLesson.DataSource = null;
                dgvLesson.MultiSelect = false;
                dgvLesson.CurrentCell = null;

                dgvSelectedLessons.DataSource = null;
                dgvSelectedLessons.MultiSelect = false;
                dgvSelectedLessons.CurrentCell = null;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (LessonsOfFileldsOfNewYearInUngradeHandler lessonsOfFileldsOfNewYearInUngradeHandler = new LessonsOfFileldsOfNewYearInUngradeHandler())
            {
                IEnumerable<FieldsOfNewYearInUnGradutesViewModel> fieldsOfNewYearInUnGradutesViewModels = lessonsOfFileldsOfNewYearInUngradeHandler.FillFieldOfNewYearInUngradeViewModels(
                    fVm => fVm.AcademyYearString.ToLower().Contains(txtSearch.Text) ||
                    fVm.FkFieldsOfNewYearInUnGradutesIdString.ToLower().Contains(txtSearch.Text) ||
                    fVm.FkUnderGraduteInAcademyYearIdString.ToLower().Contains(txtSearch.Text));
                dgvNewAcademyYearAllField.DataSource = fieldsOfNewYearInUnGradutesViewModels;
                dgvNewAcademyYearAllField.MultiSelect = false;
                dgvNewAcademyYearAllField.CurrentCell = null;
            }
        }

        private void dgvNewAcademyYearAllField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (LessonsOfFileldsOfNewYearInUngradeHandler lessonsOfFileldsOfNewYearInUngradeHandler = new LessonsOfFileldsOfNewYearInUngradeHandler())
            {
                int fkFieldId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[0].Value.ToString());
                dgvLesson.DataSource = lessonsOfFileldsOfNewYearInUngradeHandler.FillLessonViewModel(ls => ls.FkFileldId == fkFieldId).ToList();
                dgvLesson.MultiSelect = false;
                dgvLesson.CurrentCell = null;
                dgvSelectedLessons.DataSource = lessonsOfFileldsOfNewYearInUngradeHandler.FillSelectedLessonViewModel(dgvNewAcademyYearAllField);
                dgvSelectedLessons.MultiSelect = false;
                dgvSelectedLessons.CurrentCell = null;
            }
        }

       
    }
}
