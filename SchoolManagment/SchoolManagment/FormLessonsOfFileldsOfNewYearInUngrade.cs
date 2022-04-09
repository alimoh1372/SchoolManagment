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
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (LessonsOfFileldsOfNewYearInUngradeHandler lessonsOfFileldsOfNewYearInUngradeHandler = new LessonsOfFileldsOfNewYearInUngradeHandler())
            {
                IEnumerable<FieldsOfNewYearInUnGradutesViewModel> fieldsOfNewYearInUnGradutesViewModels = lessonsOfFileldsOfNewYearInUngradeHandler.FillFieldOfNewYearInUngradeViewModels(
                    fVm=>fVm.AcademyYearString.ToLower().Contains(txtSearch.Text) || 
                    fVm.FkFieldsOfNewYearInUnGradutesIdString.ToLower().Contains(txtSearch.Text) ||
                    fVm.FkUnderGraduteInAcademyYearIdString.ToLower().Contains(txtSearch.Text));
                dgvNewAcademyYearAllField.DataSource = fieldsOfNewYearInUnGradutesViewModels;
                dgvNewAcademyYearAllField.MultiSelect = false;
                dgvNewAcademyYearAllField.CurrentCell = null;
            }
        }
    }
}
