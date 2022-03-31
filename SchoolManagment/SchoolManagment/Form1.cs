using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGradeInformation_Click(object sender, EventArgs e)
        {
            GradeForm frmGrade = new GradeForm();
            frmGrade.ShowDialog();
        }
        private void btnUnderGradeInformation_Click(object sender, EventArgs e)
        {
            UnderGradeForm frmUnderGrade = new UnderGradeForm();
            frmUnderGrade.ShowDialog();
        }

        private void btnAcademyYearInformation_Click(object sender, EventArgs e)
        {
            AcademyYearForm frmAcademyYear = new AcademyYearForm();
            frmAcademyYear.ShowDialog();
            
        }

        private void btnFileldsInformation_Click(object sender, EventArgs e)
        {
            FormField formField = new FormField();
            formField.ShowDialog();
        }

        private void btnLessonInformation_Click(object sender, EventArgs e)
        {
            FormLesson frmLesson = new FormLesson();
            frmLesson.ShowDialog();
        }
    }
}
