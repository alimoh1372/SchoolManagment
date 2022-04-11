using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.ViewModel;
using SchoolManagment.Bussiness;

namespace SchoolManagment.App
{
    public partial class FormTeacherTeachLessonAccordingToCalender : Form
    {
        private IEnumerable<ITeacherTeachLessonAccordingToCalenderViewModel> _teacherTeachLessonAccordingToCalenderViewModels;
        IEnumerable<CalenderViewModel> _calenderViewModels;
        public FormTeacherTeachLessonAccordingToCalender()
        {
            InitializeComponent();
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = true;
            dgvCalenders.AutoGenerateColumns = false;
            dgvSelectedCalenders.AutoGenerateColumns = false;
        }

        private void FormTeacherTeachLessonAccordingToCalender_Load(object sender, EventArgs e)
        {
            ReloaldFormAndData();
        }
        //Insert A new Calender To teacherlesson

        private void btnAddNewCalender_Click(object sender, EventArgs e)
        {
            int result = -1;
            using (TeacherTeachLessonAccordingToCalenderHandler teacherLessonCalenderHandler = new TeacherTeachLessonAccordingToCalenderHandler())
            {
                result = teacherLessonCalenderHandler.InsertTeacherLessonCalender(dgvNewAcademyYearAllLessons, dgvCalenders);
                if (result > 0)
                {
                    ReloaldFormAndData();
                }
            }
        }
        //Delete A selected Calender From teacehrLessonCalender 
        private void btnDeleteSelectedTeacher_Click(object sender, EventArgs e)
        {
            int result = -1;
            using (TeacherTeachLessonAccordingToCalenderHandler teacherLessonCalenderHandler = new TeacherTeachLessonAccordingToCalenderHandler())
            {
                result = teacherLessonCalenderHandler.DeleteFromTeacherLessonCalender(dgvNewAcademyYearAllLessons, dgvSelectedCalenders);
                if (result > 0)
                {
                    ReloaldFormAndData();
                }
            }
        }

        private void ReloaldFormAndData()
        {
            txtSearch.Text = string.Empty;
            //DataGrid View dgvNewAcademyYearAllLessons data binding and reset
            using (ITeacherTeachLessonAccordingToCalenderHandler teacherLessonCalenderHandler = new TeacherTeachLessonAccordingToCalenderHandler())
            {

                _teacherTeachLessonAccordingToCalenderViewModels = teacherLessonCalenderHandler.FillTeacherLessonCalenderViewModel().ToList();
                dgvNewAcademyYearAllLessons.DataSource = _teacherTeachLessonAccordingToCalenderViewModels;
                dgvNewAcademyYearAllLessons.CurrentCell = null;
            }
            //DataGridView dgvCalenders load Data
            using (CalenderHandler calenderHandler = new CalenderHandler())
            {
                _calenderViewModels = calenderHandler.GetCalenderAndFillViewModel();
                dgvCalenders.DataSource = _calenderViewModels.ToList();
                dgvCalenders.CurrentCell = null;
            }

            //DataGridView dgvSelectedCalender clear Data
            dgvSelectedCalenders.DataSource = null;
        }

        private void dgvNewAcademyYearAllLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ITeacherTeachLessonAccordingToCalenderHandler teacherLessonCalenderHandler = new TeacherTeachLessonAccordingToCalenderHandler())
            {
                dgvSelectedCalenders.DataSource = teacherLessonCalenderHandler.FillSelectedCalenderViewModel(dgvNewAcademyYearAllLessons, _calenderViewModels);
                dgvSelectedCalenders.CurrentCell = null;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (ITeacherTeachLessonAccordingToCalenderHandler teacherLessonCalenderHandler = new TeacherTeachLessonAccordingToCalenderHandler())
            {
                dgvNewAcademyYearAllLessons.DataSource = teacherLessonCalenderHandler.FilterSearch(_teacherTeachLessonAccordingToCalenderViewModels, txtSearch);
            }

        }


    }
}
