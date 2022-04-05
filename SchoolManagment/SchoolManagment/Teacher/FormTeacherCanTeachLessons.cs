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
using SchoolManagment.Utility;

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
            dgvSelectedLessons.AutoGenerateColumns = false;
            dgvSelectedLessons.MultiSelect = false;
            dgvSelectedLessons.CurrentCell = null;
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

                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        int lessonId = Convert.ToInt32(dgvLesson.CurrentRow.Cells["PKLessonId"].Value.ToString());
                        int teacherId = Convert.ToInt32(lblSelectedTeacherId.Text);
                        if (!db.TeacherCanTeachLessonRepository.Insert(lessonId, teacherId))
                        {
                            attemMessage = "برای این معلم قبلا این درس انتخاب شده است ";
                            RtlMessageBox.Show(attemMessage, "درس تکراری برای معلم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            result = db.Save();
                            if (result > 0)
                            {
                                ReloadLessonsOfTeacher();
                            }
                            else
                            {
                                attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                    }

                }
                else
                {
                    attemMessage = "لطفا یک درس را انتخاب نمائید.";

                    RtlMessageBox.Show(attemMessage, "عدم انتخاب درس", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void DeleteFromSelectedLesson_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result = 0;
            if (BaseValidator.IsFormValid(this.components))
            {
                if (dgvSelectedLessons.CurrentCell != null)
                {

                    if (lblSelectedTeacherId.Text != string.Empty)
                    {


                        using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                        {
                            int lessonId = Convert.ToInt32(dgvSelectedLessons.CurrentRow.Cells["PKLessonId1"].Value.ToString());
                            int teacherId = Convert.ToInt32(lblSelectedTeacherId.Text);
                            int pKTeacherCanTeachLesson = db.TeacherCanTeachLessonRepository.GetIdByLessonIdAndTeacherId(lessonId, teacherId);
                            if (pKTeacherCanTeachLesson > 0)
                            {
                                db.TeacherCanTeachLessonRepository.Delete(pKTeacherCanTeachLesson);
                                result = db.Save();
                                if (result > 0)
                                {
                                    ReloadLessonsOfTeacher();
                                }
                                else
                                {
                                    attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                    RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                attemMessage = "خطا در پردازش اطلاعات لطفا با ادمین خود تماس حاصل فرمائید.";

                                RtlMessageBox.Show(attemMessage, "خطا در پردازش", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        attemMessage = "لطفا یک معلم از لیست معلم ها انتخاب نمائید.جهت حذف درس قابل تدریس ایشان...";

                        RtlMessageBox.Show(attemMessage, "عدم انتخاب معلم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    attemMessage = "لطفا یک درس را از لیست پایین (دروس انتخاب شده برای معلم) انتخاب نمائید.";

                    RtlMessageBox.Show(attemMessage, "عدم انتخاب درس", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ReloadDataAndForms()
        {
            txtFilterLessons.Text = string.Empty;
            txtSelectedTeacehrEducation.Text = string.Empty;
            txtSelectedTeacherName.Text = string.Empty;
            txtTeacherFilter.Text = string.Empty;
            dgvSelectedLessons.DataSource = null;
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
                ReloadLessonsOfTeacher();
            }
        }

        private void ReloadLessonsOfTeacher()
        {

            if (lblSelectedTeacherId.Text != string.Empty)
            {
                IEnumerable<LessonViewModel> lessonViewModels;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    lessonViewModels = db.TeacherRepository.FillLessonsOfTeacherThatCantTeach(Convert.ToInt32(lblSelectedTeacherId.Text));
                    dgvSelectedLessons.DataSource = lessonViewModels.ToList();
                    dgvSelectedLessons.CurrentCell = null;

                    //lVSelectedLesson.Items.AddRange(teacherCanTeachLessonViewModels.ToArray());
                }
            }
        }



        private void txtFilterLessons_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<LessonViewModel> lessonViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
               lessonViewModels= db.LessonRepository.FillViewModel()
                    .Where(
                    vm => vm.LessonName.ToLower().Contains(txtFilterLessons.Text) ||
                    vm.LessonUnits.ToString().Contains(txtFilterLessons.Text) ||
                    vm.FkFileldIdString.ToLower().Contains(txtFilterLessons.Text)
                     );
                dgvLesson.DataSource = lessonViewModels.ToList();
            }

            
        }

        private void txtTeacherFilter_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Teacher> teachers;
            using (UnitOfWork db=new UnitOfWork(new SchoolManagmentEntities()))
            {
                teachers = db.TeacherRepository.Get(t => t.TeacherName.ToLower().Contains(txtTeacherFilter.Text) || t.TeacherEducation.ToLower().Contains(txtTeacherFilter.Text));
                dgvTeacher.DataSource = teachers.ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadDataAndForms();
        }
    }
}
