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

        private void ReloaldFormAndData()
        {
            txtSearch.Text = string.Empty;
            //DataGrid View dgvNewAcademyYearAllLessons data binding and reset
            using (ITeacherTeachLessonAccordingToCalenderHandler teacherLessonCalenderHandler=new TeacherTeachLessonAccordingToCalenderHandler())
            {
                dgvNewAcademyYearAllLessons.DataSource = teacherLessonCalenderHandler.FillTeacherLessonCalenderViewModel().ToList() ;
                 
            }
            

        }
    }
}
