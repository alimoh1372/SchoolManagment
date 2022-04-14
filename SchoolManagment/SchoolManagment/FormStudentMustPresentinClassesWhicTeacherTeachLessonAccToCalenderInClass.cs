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
        IEnumerable<IStudentViewModel> selectedStudentForDgvSelectedStudent;

        private bool _isfirstTimeEnded;
        private bool _isNeedToReloadDgvStudentViewModel;

        public FormStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass()
        {
            InitializeComponent();
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.AutoGenerateColumns = false;
            _isfirstTimeEnded = false;
            _isNeedToReloadDgvStudentViewModel = false;
        }

        private void FormStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void ReloadFormAndData()
        {
            
            txtSearch.Text = string.Empty;
            txtSearchStudents.Text = string.Empty;

            using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                    new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
            {
                if (!_isfirstTimeEnded)
                {
                    //fill Main DataGridView and clear the selection
                    _classCalenderViewModel = studentClassCalenderHandler.FillStudentsClassInCalenderViewModel();
                    dgvNewAcademyYearAllLessons.DataSource = _classCalenderViewModel;
                    dgvNewAcademyYearAllLessons.CurrentCell = null;


                    //fill the student ViewModel for show on main datagridview cell click
                    _studentViewModels = studentClassCalenderHandler.GetStudentsViewModel();
                    dgvStudent.DataSource = null;
                    _isfirstTimeEnded = true;
                }
                if (_isNeedToReloadDgvStudentViewModel)
                {
                    //fill the student ViewModel for show on main datagridview cell click
                    _studentViewModels = studentClassCalenderHandler.GetStudentsViewModel();
                    dgvSelectedStudentInClass.DataSource = null;
                    _isNeedToReloadDgvStudentViewModel = false;
                }

            }
            rdbAllStudent.Checked = true;

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
                dgvStudent.CurrentCell = null;
                rdbAllStudent.Checked = true;
                selectedStudentForDgvSelectedStudent = studentClassCalenderHandler.GetSelectedStudent(dgvNewAcademyYearAllLessons,_dgvStudentViewModels);
                dgvSelectedStudentInClass.DataSource = selectedStudentForDgvSelectedStudent.ToList();
                dgvSelectedStudentInClass.CurrentCell = null;


            }
        }

        private void txtSearchStudents_TextChanged(object sender, EventArgs e)
        {

            IEnumerable<IStudentViewModel> thisStudentViewModel;
            bool? isSelected;
            if (_dgvStudentViewModels != null)
            {
                using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                       new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
                {
                    isSelected = studentClassCalenderHandler.SelectAssignedStudents(rdbAllStudent, rdbSelectedStudent);
                    thisStudentViewModel = studentClassCalenderHandler.FilterSearch(_dgvStudentViewModels, txtSearchStudents, isSelected);
                    dgvStudent.DataSource = thisStudentViewModel.ToList();
                }
            }

        }

        private void rdbAllStudent_CheckedChanged(object sender, EventArgs e)
        {

            IEnumerable<IStudentViewModel> thisStudentViewModel;
            bool? isSelected;
            if (_dgvStudentViewModels != null)
            {
                using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                       new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
                {
                    isSelected = studentClassCalenderHandler.SelectAssignedStudents(rdbAllStudent, rdbSelectedStudent);
                    thisStudentViewModel = studentClassCalenderHandler.FilterSearch(_dgvStudentViewModels, txtSearchStudents, isSelected);
                    dgvStudent.DataSource = thisStudentViewModel.ToList();
                }
            }

        }

        private void rdbSelectedStudent_CheckedChanged(object sender, EventArgs e)
        {

            IEnumerable<IStudentViewModel> thisStudentViewModel;
            bool? isSelected;
            if (_dgvStudentViewModels != null)
            {
                using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                       new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
                {
                    isSelected = studentClassCalenderHandler.SelectAssignedStudents(rdbAllStudent, rdbSelectedStudent);
                    thisStudentViewModel = studentClassCalenderHandler.FilterSearch(_dgvStudentViewModels, txtSearchStudents, isSelected);
                    dgvStudent.DataSource = thisStudentViewModel.ToList();
                }
            }

        }

        private void rdbUnselectedStudent_CheckedChanged(object sender, EventArgs e)
        {

            IEnumerable<IStudentViewModel> thisStudentViewModel;
            bool? isSelected;
            if (_dgvStudentViewModels != null)
            {
                using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                       new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
                {
                    isSelected = studentClassCalenderHandler.SelectAssignedStudents(rdbAllStudent, rdbSelectedStudent);
                    thisStudentViewModel = studentClassCalenderHandler.FilterSearch(_dgvStudentViewModels, txtSearchStudents, isSelected);
                    dgvStudent.DataSource = thisStudentViewModel.ToList();
                }
            }

        }

        private void btnInsertDeleteSync_Click(object sender, EventArgs e)
        {
            bool result;
            using (IStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler studentClassCalenderHandler =
                       new StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassHandler())
            {
               result= studentClassCalenderHandler.InsertDeleteSyncStudentsToClass(dgvNewAcademyYearAllLessons, dgvStudent, _dgvStudentViewModels, selectedStudentForDgvSelectedStudent);
                if (result)
                {
                    _isNeedToReloadDgvStudentViewModel = true;
                    _isfirstTimeEnded = false;
                    ReloadFormAndData();
                    
                }
            }
        }
    }
}
