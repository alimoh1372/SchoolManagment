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
using SchoolManagment.Bussiness;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.App
{
    public partial class FormTeacherTeachLessonAccToCalenderInClass : Form
    {
        private IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> _thisTeacherTeachLessonAccToCalenderInClassViewModels;
        private IEnumerable<Class> _thisClasses;
        public FormTeacherTeachLessonAccToCalenderInClass()
        {
            InitializeComponent();
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
            dgvClass.AutoGenerateColumns = false;
            dgvSelectedClass.AutoGenerateColumns = false;
        }

        private void FormTeacherTeachLessonAccToCalenderInClass_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();

        }
        //Insert Selected Class for selected CalenderLesson
        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            int result = -1;
            using (TeacherTeachLessonAccToCalenderInClassHandler teacherTeachLessonAccToCalenderInClassHandler = new TeacherTeachLessonAccToCalenderInClassHandler())
            {
                result = teacherTeachLessonAccToCalenderInClassHandler.InsertSelectedClassToCalenderLesson(dgvNewAcademyYearAllLessons, dgvClass);
                if (result > 0)
                {
                    ReloadFormAndData();
                }
            }
        }
        private void btnDeleteSelectedClass_Click(object sender, EventArgs e)
        {
            int result = -1;
            using (TeacherTeachLessonAccToCalenderInClassHandler teacherTeachLessonAccToCalenderInClassHandler = new TeacherTeachLessonAccToCalenderInClassHandler())
            {
                result = teacherTeachLessonAccToCalenderInClassHandler.DeleteSelectedClassFromCalenderLessonClass(dgvNewAcademyYearAllLessons, dgvSelectedClass);
                if (result > 0)
                {
                    ReloadFormAndData();
                }
            }
        }
        private void ReloadFormAndData()
        {
            txtSearch.Text = string.Empty;

            using (ITeacherTeachLessonAccToCalenderInClassHandler teacherTeachLessonAccToCalenderInClassHandler = new TeacherTeachLessonAccToCalenderInClassHandler())
            {
                //Fill main datagridView
                if (_thisTeacherTeachLessonAccToCalenderInClassViewModels == null && dgvNewAcademyYearAllLessons.DataSource == null)
                {
                    _thisTeacherTeachLessonAccToCalenderInClassViewModels = teacherTeachLessonAccToCalenderInClassHandler.FillLessonCalenderViewModel();
                    dgvNewAcademyYearAllLessons.DataSource = _thisTeacherTeachLessonAccToCalenderInClassViewModels;
                    dgvNewAcademyYearAllLessons.CurrentCell = null;
                }
                else
                {
                    dgvNewAcademyYearAllLessons.DataSource = _thisTeacherTeachLessonAccToCalenderInClassViewModels;
                    dgvNewAcademyYearAllLessons.CurrentCell = null;
                }

                //Clear DataGridView dgvClass
                if (_thisClasses == null)
                {
                    _thisClasses = teacherTeachLessonAccToCalenderInClassHandler.FillClasses();
                    dgvClass.DataSource = _thisClasses;
                    dgvClass.CurrentCell = null;
                }
                else
                {
                    dgvClass.CurrentCell = null;
                }
            }
            //Clear DataGridView dgvSelectedClasses
            dgvSelectedClass.DataSource = null;

        }

        private void dgvNewAcademyYearAllLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IEnumerable<Class> classes;
            using (TeacherTeachLessonAccToCalenderInClassHandler teacherTeachLessonAccToCalenderInClassHandler = new TeacherTeachLessonAccToCalenderInClassHandler())
            {
                classes = teacherTeachLessonAccToCalenderInClassHandler.FillSelectedClassess(dgvNewAcademyYearAllLessons, _thisClasses);
                dgvSelectedClass.DataSource = classes;
                dgvSelectedClass.CurrentCell = null;
            }
        }
        //Filter the gridView from textbox search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != string.Empty)
            {
                using (TeacherTeachLessonAccToCalenderInClassHandler teacherTeachLessonAccToCalenderInClassHandler = new TeacherTeachLessonAccToCalenderInClassHandler())
                {
                    dgvNewAcademyYearAllLessons.DataSource = teacherTeachLessonAccToCalenderInClassHandler.FileterSearch(_thisTeacherTeachLessonAccToCalenderInClassViewModels, txtSearch);
                }
            }

        }


    }
}
