using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
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
using ValidationComponents;

namespace SchoolManagment.App
{
    public partial class FormTeacherCanTeachLessons : Form
    {
        public FormTeacherCanTeachLessons()
        {
            InitializeComponent();
            dgvTeacher.AutoGenerateColumns = false;
            dgvTeacher.MultiSelect = false;
            dgvLesson.AutoGenerateColumns = false;
            dgvLesson.MultiSelect = false;
        }
        private void FormTeacherCanTeachLessons_Load(object sender, EventArgs e)
        {
            ReloadDataAndForms();
        }
        
        private void btnAddToSelectedList_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result = 0;
            if (BaseValidator.IsFormValid(this.components))
            {

                if (dgvLesson.SelectedCells.Count > 0)
                {
                    TeacherCanTeachLesson teacherCanTeachLesson = new TeacherCanTeachLesson()
                    {
                        FkLessonId = Convert.ToInt32(dgvLesson.CurrentRow.Cells["PKLessonId"].Value.ToString()),
                        FkTeacherId = Convert.ToInt32(lblSelectedTeacherId.Text)
                    };

                }
                else
                {
                    attemMessage = "لطفا یک درس را انتخاب نمائید.";

                    RtlMessageBox.Show(attemMessage, "عدم انتخاب درس", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        
        private void ReloadDataAndForms()
        {
            IEnumerable<Teacher> teachers;
            IEnumerable<LessonViewModel> lessonViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                teachers = db.TeacherRepository.Get();
                dgvTeacher.DataSource = teachers.ToList();
                lessonViewModels = db.LessonRepository.FillViewModel();
                dgvLesson.DataSource = lessonViewModels.ToList();

            }
        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTeacher.SelectedCells.Count > 0)
            {
                lblSelectedTeacherId.Text = dgvTeacher.CurrentRow.Cells["TeacherId"].Value.ToString();
                txtSelectedTeacherName.Text = dgvTeacher.CurrentRow.Cells["TeacherName"].Value.ToString();
                txtSelectedTeacehrEducation.Text = dgvTeacher.CurrentRow.Cells["TeacherEducation"].Value.ToString();
                loadLessonsOfTeacher();
            }
        }

        private void loadLessonsOfTeacher()
        {
            IEnumerable<TeacherCanTeachLessonViewModel> teacherCanTeachLessonViewModels;
            if (lblSelectedTeacherId.Text!=string.Empty)
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                   teacherCanTeachLessonViewModels= db.TeacherRepository.FillLessonsThatTeacherCanTeach(Convert.ToInt32(lblSelectedTeacherId.Text)).ToList();
                    lVSelectedLesson.Items.AddRange(teacherCanTeachLessonViewModels.ToArray())
                }
            }
        }
    }
}
