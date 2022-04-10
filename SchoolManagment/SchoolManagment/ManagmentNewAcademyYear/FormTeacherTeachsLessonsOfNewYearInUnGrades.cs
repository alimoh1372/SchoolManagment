using SchoolManagment.Bussiness;
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
using SchoolManagment.DataLayer.DatabaseModel;

namespace SchoolManagment.App
{
    public partial class FormTeacherTeachsLessonsOfNewYearInUnGrades : Form
    {
        private IEnumerable<ITeacherTeachsLessonsOfNewYearInUnGradesViewModel> _lessonVM;
        private IEnumerable<Teacher> _teachers;
        public FormTeacherTeachsLessonsOfNewYearInUnGrades()
        {
            InitializeComponent();
            dgvNewAcademyYearAllLessons.AutoGenerateColumns = false;
            dgvSelectedTeacher.AutoGenerateColumns = false;
            dgvTeacher.AutoGenerateColumns = false;
        }

        private void FormTeacherTeachsLessonsOfNewYearInUnGrades_Load(object sender, EventArgs e)
        {
            using (ITeacherTeachsLessonsOfNewYearInUnGradesHandler teacherTeachsLessonsOfNewYearInUnGradesHandler = new TeacherTeachsLessonsOfNewYearInUnGradesHandler())
            {
                _lessonVM = teacherTeachsLessonsOfNewYearInUnGradesHandler.FillTeacherTeachsLessonsOfNewYearInUnGradesViewModels();
                _teachers = teacherTeachsLessonsOfNewYearInUnGradesHandler.FillTeachers();
            }
            RealoadDataAndForm();
        }

        private void RealoadDataAndForm()
        {
            txtSearch.Text = string.Empty;
            //DatagridView dgvAcademyInAllLesson fill data
            dgvNewAcademyYearAllLessons.DataSource = _lessonVM;
            dgvNewAcademyYearAllLessons.CurrentCell = null;
            dgvNewAcademyYearAllLessons.MultiSelect = false;


            //DataGridview lesson clear Data
            dgvTeacher.DataSource = null;
            dgvTeacher.MultiSelect = false;
            dgvTeacher.CurrentCell = null;


            //DataGridView selectedLesson clear Data
            dgvSelectedTeacher.DataSource = null;
            dgvSelectedTeacher.MultiSelect = false;
            dgvSelectedTeacher.CurrentCell = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (TeacherTeachsLessonsOfNewYearInUnGradesHandler tchhandler = new TeacherTeachsLessonsOfNewYearInUnGradesHandler())
            {
                dgvNewAcademyYearAllLessons.DataSource = tchhandler.FillTeacherTeachsLessonsOfNewYearInUnGradesViewModels(_lessonVM, txtSearch);
                dgvNewAcademyYearAllLessons.MultiSelect = false;
                dgvNewAcademyYearAllLessons.CurrentCell = null;
            }
        }

        private void dgvNewAcademyYearAllLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (TeacherTeachsLessonsOfNewYearInUnGradesHandler tchHandler = new TeacherTeachsLessonsOfNewYearInUnGradesHandler())
            {


                IEnumerable<Teacher> _teachers;
                //fill Teachers DataGridView teacher

                _teachers = tchHandler.FillTeachers(dgvNewAcademyYearAllLessons);
                dgvTeacher.DataSource = _teachers.ToList();
                dgvTeacher.MultiSelect = false;
                dgvTeacher.CurrentCell = null;


                //fill selected teacher for lesson
                _teachers= tchHandler.FillSelectedTeacherGridview(dgvNewAcademyYearAllLessons);
                dgvSelectedTeacher.DataSource = _teachers;
                dgvSelectedTeacher.MultiSelect = false;
                dgvSelectedTeacher.CurrentCell = null;
            }
        }

        private void btnAddNewTeachre_Click(object sender, EventArgs e)
        {
            int result = -1;
            using (TeacherTeachsLessonsOfNewYearInUnGradesHandler tchHandler=new TeacherTeachsLessonsOfNewYearInUnGradesHandler())
            {
               result= tchHandler.InsertIntoTeacherTeachsLesson(dgvNewAcademyYearAllLessons, dgvTeacher);
                if (result>0)
                {
                    RealoadDataAndForm();
                }
            }
        }

        private void btnDeleteSelectedTeacher_Click(object sender, EventArgs e)
        {
            int result = -1;
            using (TeacherTeachsLessonsOfNewYearInUnGradesHandler tchHandler = new TeacherTeachsLessonsOfNewYearInUnGradesHandler())
            {
                result = tchHandler.DeleteTeacherFromTeacherList(dgvNewAcademyYearAllLessons, dgvSelectedTeacher);
                if (result > 0)
                {
                    RealoadDataAndForm();
                }
            }
        }
    }
}
