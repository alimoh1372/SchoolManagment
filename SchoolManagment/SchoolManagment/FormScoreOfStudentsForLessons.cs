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
        private IEnumerable<ITeacherMenoAllLessonsClassViewModel> teacherMenoForDgvAllLessonsViewModels;
        public FormScoreOfStudentsForLessons()
        {
            InitializeComponent();
            _isNeesToLoadAllLessonViewModel = true;
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
        }

        private void FormScoreOfStudentsForLessons_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void ReloadFormAndData()
        {
            ScoreOfStudentsForLessonsHandler scoreStudentHandler = new ScoreOfStudentsForLessonsHandler();
            if (_isNeesToLoadAllLessonViewModel)
            {
                teacherMenoForDgvAllLessonsViewModels = scoreStudentHandler.GetAllLessonClassWithPresentForeignKey();
                dgvNewAcademyYearAllLessons.DataSource = teacherMenoForDgvAllLessonsViewModels;
                _isNeesToLoadAllLessonViewModel = false;
            }



            scoreStudentHandler.Dispose();
        }
    }
}
