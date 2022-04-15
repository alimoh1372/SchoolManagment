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
    public partial class FormScoreOfStudentsForLessons : Form
    {
        private bool _isNeesToLoadAllLessonViewModel;
        private bool _isNeedToLoadStudentViewModel;
        private IEnumerable<ITeacherMenoAllLessonsClassViewModel> teacherMenoForDgvAllLessonsViewModels;
        private IEnumerable<IScoreStudentViewModel> scoreStudentViewModels;
        public FormScoreOfStudentsForLessons()
        {
            InitializeComponent();
            _isNeesToLoadAllLessonViewModel = true;
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
            _isNeedToLoadStudentViewModel = false;
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.EditMode = DataGridViewEditMode.EditOnEnter;

        }

        private void FormScoreOfStudentsForLessons_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void ReloadFormAndData()
        {
            ScoreOfStudentsForLessonsHandler scoreStudentHandler = new ScoreOfStudentsForLessonsHandler();
            txtSearch.Text = string.Empty;
            txtSearchStudents.Text = string.Empty;
            dgvNewAcademyYearAllLessons.CurrentCell = null;
            if (_isNeesToLoadAllLessonViewModel)
            {
                teacherMenoForDgvAllLessonsViewModels = scoreStudentHandler.GetAllLessonClassWithPresentForeignKey();
                dgvNewAcademyYearAllLessons.DataSource = teacherMenoForDgvAllLessonsViewModels;
                _isNeesToLoadAllLessonViewModel = false;
            }
            if (_isNeedToLoadStudentViewModel)
            {
                scoreStudentViewModels = scoreStudentHandler.GetScoreStudentViewModels(dgvNewAcademyYearAllLessons);
                dgvStudent.DataSource = scoreStudentViewModels;
                dgvStudent.CurrentCell = null;
                _isNeedToLoadStudentViewModel = false;
            }
            dgvStudent.DataSource = null;

            scoreStudentHandler.Dispose();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (ScoreOfStudentsForLessonsHandler scoreStudentHandler = new ScoreOfStudentsForLessonsHandler())
            {
                dgvNewAcademyYearAllLessons.DataSource = scoreStudentHandler.FilterDgvAll(teacherMenoForDgvAllLessonsViewModels, txtSearch);
            }

        }

        private void dgvNewAcademyYearAllLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ScoreOfStudentsForLessonsHandler scoreStudentHandler = new ScoreOfStudentsForLessonsHandler())
            {
                _isNeedToLoadStudentViewModel = true;
                scoreStudentViewModels = scoreStudentHandler.GetScoreStudentViewModels(dgvNewAcademyYearAllLessons);
                dgvStudent.DataSource = scoreStudentViewModels;
                dgvStudent.CurrentCell = null;
            }
        }

        private void txtSearchStudents_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<IScoreStudentViewModel> _filteredScoreStrudentViewModel;
            using (ScoreOfStudentsForLessonsHandler scoreStudentHandler = new ScoreOfStudentsForLessonsHandler())
            {
                _filteredScoreStrudentViewModel = scoreStudentHandler.FilterDgvStudent(scoreStudentViewModels, txtSearchStudents);
                dgvStudent.DataSource = _filteredScoreStrudentViewModel.ToList();
                dgvStudent.CurrentCell = null;
            }
        }

        private void btnUpdateScores_Click(object sender, EventArgs e)
        {
            bool result;
            using (ScoreOfStudentsForLessonsHandler scoreStudentHandler = new ScoreOfStudentsForLessonsHandler())
            {
               result= scoreStudentHandler.SetScoreOfStudent(dgvStudent, scoreStudentViewModels);
                if (result==true)
                {
                    _isNeedToLoadStudentViewModel = false;
                    ReloadFormAndData();
                    
                }
            }

        }


    }
}
