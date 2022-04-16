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
    public partial class FormStudenPresentDetail : Form
    {
        private bool _isNeesToLoadAllLessonViewModel;
        private bool _isNeedToLoadStudentViewModel;
        private IEnumerable<ITeacherMenoAllLessonsClassViewModel> teacherMenoForDgvAllLessonsViewModels;
        private IEnumerable<IStudenPresentDetailViewModel> studentPresentDetailViewModels;
        List<DaysListForCalender> _daylist;

        public FormStudenPresentDetail()
        {
            InitializeComponent();
            _isNeesToLoadAllLessonViewModel = true;
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
            dgvStudent.AutoGenerateColumns = false;
            lblDayOfWeek.Text = "";
        }

        private void FormStudenPresentDetail_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void ReloadFormAndData()
        {
            ScoreOfStudentsForLessonsHandler scoreStudentHandler = new ScoreOfStudentsForLessonsHandler();
            txtSearch.Text = string.Empty;
            txtSearchStudents.Text = string.Empty;
            lblDayOfWeek.Text = string.Empty;
            
            cmbxDateList.DataSource = null;
            dgvNewAcademyYearAllLessons.CurrentCell = null;
            if (_isNeesToLoadAllLessonViewModel)
            {
                teacherMenoForDgvAllLessonsViewModels = scoreStudentHandler.GetAllLessonClassWithPresentForeignKey();
                dgvNewAcademyYearAllLessons.DataSource = teacherMenoForDgvAllLessonsViewModels;
                dgvNewAcademyYearAllLessons.CurrentCell = null;
                _isNeesToLoadAllLessonViewModel = false;
            }
            dgvNewAcademyYearAllLessons.CurrentCell = null;
            cmbxDateList.DataSource = null;
            //if (_isNeedToLoadStudentViewModel)
            //{
            //    scoreStudentViewModels = scoreStudentHandler.GetScoreStudentViewModels(dgvNewAcademyYearAllLessons);
            //    dgvStudent.DataSource = scoreStudentViewModels;
            //    dgvStudent.CurrentCell = null;
            //    _isNeedToLoadStudentViewModel = false;
            //}
            dgvStudent.DataSource = null;

            scoreStudentHandler.Dispose();
        }

        

        private void dgvNewAcademyYearAllLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            using (StudenPresentDetailHandler studenPresentDetailHandler=new StudenPresentDetailHandler())
            {
                _daylist= studenPresentDetailHandler.GetDaysListViewModel(dgvNewAcademyYearAllLessons).ToList();
                DayOfWeek dayOfWeek= _daylist.First().dateTime.DayOfWeek;
                string dayOfWeekString;
                switch (dayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        dayOfWeekString = "یکشنبه";
                        break;
                    case DayOfWeek.Monday:
                        dayOfWeekString = "دوشنبه";
                        break;
                    case DayOfWeek.Tuesday:
                        dayOfWeekString = "سه شنبه";
                        break;
                    case DayOfWeek.Wednesday:
                        dayOfWeekString = "چهارشنبه";
                        break;
                    case DayOfWeek.Thursday:
                        dayOfWeekString = "پنج شنبه";
                        break;
                    case DayOfWeek.Friday:
                        dayOfWeekString = "جمعه";
                        break;
                    default:
                        dayOfWeekString = "شنبه";
                        break;
                }
                cmbxDateList.DisplayMember = "persianDate";
                cmbxDateList.ValueMember = "dateTime";
                lblDayOfWeek.Text = dayOfWeekString ;
                cmbxDateList.DataSource = _daylist;
                dgvStudent.DataSource = null;
                
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (ScoreOfStudentsForLessonsHandler scoreStudentHandler = new ScoreOfStudentsForLessonsHandler())
            {
                dgvNewAcademyYearAllLessons.DataSource = scoreStudentHandler.FilterDgvAll(teacherMenoForDgvAllLessonsViewModels, txtSearch);
            }
        }

        private void cmbxDateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (StudenPresentDetailHandler studentPresentDetailHandler = new StudenPresentDetailHandler())
            {
                studentPresentDetailViewModels = studentPresentDetailHandler.GetStudentPresentDetailViewModel(dgvNewAcademyYearAllLessons,cmbxDateList);
                dgvStudent.DataSource = studentPresentDetailViewModels;
                dgvStudent.CurrentCell = null;
            }
        }

        private void btnUpdateScores_Click(object sender, EventArgs e)
        {
            using (StudenPresentDetailHandler studentPresentDetailHandler = new StudenPresentDetailHandler())
            {
                studentPresentDetailHandler.SyncTheStudentDgvWithDataBase(dgvStudent, cmbxDateList);
                ReloadFormAndData();
            }
        }
    }
}
