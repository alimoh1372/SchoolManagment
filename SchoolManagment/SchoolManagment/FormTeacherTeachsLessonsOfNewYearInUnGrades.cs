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
    public partial class FormTeacherTeachsLessonsOfNewYearInUnGrades : Form
    {
        public FormTeacherTeachsLessonsOfNewYearInUnGrades()
        {
            InitializeComponent();
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
            dgvSelectedTeacher.AutoGenerateColumns = false;
            dgvTeacher.AutoGenerateColumns = false;
        }

        private void FormTeacherTeachsLessonsOfNewYearInUnGrades_Load(object sender, EventArgs e)
        {
            RealoadDataAndForm();
        }

        private void RealoadDataAndForm()
        {
            txtSearch.Text = string.Empty;
            //DatagridView dgvAcademyInAllLesson fill data




            //DataGridview lesson clear Data




            //DataGridView selectedLesson clear Data
        }
    }
}
