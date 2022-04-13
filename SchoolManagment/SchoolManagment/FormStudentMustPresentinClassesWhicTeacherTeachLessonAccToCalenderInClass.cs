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
    public partial class FormStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass : Form
    {
        IEnumerable<IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassViewModel> _classCalenderViewModel;
        IEnumerable<IStudentViewModel> _studentViewModels;
        IEnumerable<IStudentViewModel> _dgvStudentViewModels;

        public FormStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass()
        {
            InitializeComponent();
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
            dgvStudent.AutoGenerateColumns = false;
            dgvSelectedStudentInClass.AutoGenerateColumns = false;
        }

        private void FormStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void ReloadFormAndData()
        {
            txtSearch.Text = string.Empty;
            txtSearchStudents.Text = string.Empty;
            rdbAllStudent.Checked = true;
            using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                    new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
            {
                //fill Main DataGridView and clear the selection
                if (_classCalenderViewModel == null)
                {
                    _classCalenderViewModel = studentClassCalenderHandler.FillStudentsClassInCalenderViewModel();
                    dgvNewAcademyYearAllLessons.DataSource = _classCalenderViewModel;
                    dgvNewAcademyYearAllLessons.CurrentCell = null;
                }
                //fill the student ViewModel for show on main datagridview cell click
                if (_studentViewModels == null)
                {
                    _studentViewModels = studentClassCalenderHandler.GetStudentsViewModel();

                }

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != string.Empty)
            {
                using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                    new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
                {
                    dgvNewAcademyYearAllLessons.DataSource = studentClassCalenderHandler.FilterSearchGridView(_classCalenderViewModel, txtSearch);
                    dgvNewAcademyYearAllLessons.CurrentCell = null;
                }
            }
        }

        private void dgvNewAcademyYearAllLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                   new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
            {
                _dgvStudentViewModels = studentClassCalenderHandler.FillStudentDataGridView(dgvNewAcademyYearAllLessons, _classCalenderViewModel, _studentViewModels);
                dgvStudent.DataSource = _dgvStudentViewModels;
            }
        }

        private void txtSearchStudents_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<IStudentViewModel> thisStudentViewModel;
            bool? isSelected; 
            using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                   new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
            {
                isSelected = studentClassCalenderHandler.SelectAssignedStudents(rdbAllStudent, rdbSelectedStudent);
                thisStudentViewModel = studentClassCalenderHandler.FilterSearch(_dgvStudentViewModels, txtSearch, isSelected);
                dgvStudent.DataSource = thisStudentViewModel;
            }
        }
    }
}
