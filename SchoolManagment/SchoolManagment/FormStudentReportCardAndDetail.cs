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
    public partial class FormStudentReportCardAndDetail : Form
    {
        bool _isNeedToUpdateDgvStudent;
        IEnumerable<IStudentViewModel> _studentViewModels;
        IEnumerable<ITeacherMenoAllLessonsClassViewModel> _teacherMenoAllLessonsClassViewModels;
        IEnumerable<IScoreOfStudentsForLessonViewModel> _scoreOfStudentsForLessonViewModels;
        public FormStudentReportCardAndDetail()
        {
            InitializeComponent();
            dgvStudent.AutoGenerateColumns = false;
            _isNeedToUpdateDgvStudent = true;
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
            dgvScoreLessonRepordCard.AutoGenerateColumns = false;
            


        }

        private void FormStudentReportCardAndDetail_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void ReloadFormAndData()
        {
            txtStudentSearch.Text = string.Empty;
            txtAverageOfYearlessons.Text = string.Empty;
            txtSearch.Text = string.Empty;
            //Load StudentDgvData
            if (_isNeedToUpdateDgvStudent==true)
            {
                StudentReportCardDetailHandler studentReportCardDetailHandler = new StudentReportCardDetailHandler();
                _studentViewModels = studentReportCardDetailHandler.GetStudentViewModel();
                dgvStudent.DataSource = _studentViewModels.ToList();
                dgvStudent.CurrentCell = null;
                _isNeedToUpdateDgvStudent = false;
            }
            dgvNewAcademyYearAllLessons.DataSource = null;
            dgvScoreLessonRepordCard.DataSource = null;

        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<IStudentViewModel> thisStudentViewModels;
            StudentReportCardDetailHandler studentReportCardDetailHandler = new StudentReportCardDetailHandler();
            thisStudentViewModels = studentReportCardDetailHandler.FilterDgvStudent(_studentViewModels, txtStudentSearch);
            dgvStudent.DataSource = thisStudentViewModels.ToList();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentReportCardDetailHandler studentReportCardDetailHandler = new StudentReportCardDetailHandler();
            _teacherMenoAllLessonsClassViewModels = studentReportCardDetailHandler.GetAllLessonClassWithPresentForeignKey(dgvStudent);
            dgvNewAcademyYearAllLessons.DataSource = _teacherMenoAllLessonsClassViewModels;
            dgvNewAcademyYearAllLessons.CurrentCell = null;
            dgvScoreLessonRepordCard.DataSource = null;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<ITeacherMenoAllLessonsClassViewModel> _thisteacherMenoAllLessonsClassViewModels;
            StudentReportCardDetailHandler studentReportCardDetailHandler = new StudentReportCardDetailHandler();
            _thisteacherMenoAllLessonsClassViewModels = studentReportCardDetailHandler.FilterDgvAll(_teacherMenoAllLessonsClassViewModels, txtSearch);
            dgvNewAcademyYearAllLessons.DataSource = _thisteacherMenoAllLessonsClassViewModels;
            dgvNewAcademyYearAllLessons.CurrentCell = null;

        }

        private void dgvNewAcademyYearAllLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAverageOfYearlessons.Text = string.Empty;
            decimal? average = null;   
            StudentReportCardDetailHandler studentReportCardDetailHandler = new StudentReportCardDetailHandler();
            _scoreOfStudentsForLessonViewModels = studentReportCardDetailHandler.GetStudentReportCardLessons(dgvStudent, dgvNewAcademyYearAllLessons);
            dgvScoreLessonRepordCard.DataSource = _scoreOfStudentsForLessonViewModels;
            average = studentReportCardDetailHandler.GetAverageLessons(_scoreOfStudentsForLessonViewModels);
            txtAverageOfYearlessons.Text = average.ToString();
        }
    }
}
