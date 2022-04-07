using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
            dgvTeacher.AutoGenerateColumns = false;
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }

        private void btnAddNewTeacher_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string attemMessage;
                int result = 0;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    Teacher teacher = new Teacher()
                    {
                        TeacherName = txtTeacherName.Text,
                        TeacherEducation = txtTeacherEducation.Text
                    };
                    attemMessage = "آیا از افزودن معلمی  با مشخصات زیر مطمئن هستید؟" + "\n" +
                   "نام معلم :" + teacher.TeacherName + "\n" +
                   "تحصیلات معلم :" + teacher.TeacherEducation + "\n";
                    if (RtlMessageBox.Show(attemMessage, "افزودن معلم جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.TeacherRepository.Insert(teacher);
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadDataAndForm();
                        }
                        else
                        {
                            attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                            RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDeleteSelectedTeacher_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result;
            if (dgvTeacher.CurrentRow.Cells.Count > 0 && dgvTeacher.CurrentRow.Cells["TeacherName"].Value.ToString() == txtTeacherName.Text && BaseValidator.IsFormValid(this.components))
            {
                attemMessage = "آیا از حذف معلم با مشخصات زیر مطمئن هستید؟" + "\n" +
                       "نام معلم:" + dgvTeacher.CurrentRow.Cells["TeacherName"].Value.ToString() + "\n" +
                        "کد ملی دانش آموز:" + dgvTeacher.CurrentRow.Cells["TeacherEducation"].Value.ToString() + "\n";
                if (RtlMessageBox.Show(attemMessage, "حذف معلم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        db.TeacherRepository.Delete(Convert.ToInt32(dgvTeacher.CurrentRow.Cells["TeacherId"].Value));
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadDataAndForm();
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
                attemMessage = "لطفا یک معلم از لیست (جهت حذف) انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب معلم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnUpdateSelectedTeacher_Click(object sender, EventArgs e)
        {
            string attemMessage;
            string oldTeName;
            string oldTeEd;

            int result;
            if (dgvTeacher.CurrentRow.Cells.Count > 0 && BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    Teacher teacher = db.TeacherRepository.GetById(Convert.ToInt32(dgvTeacher.CurrentRow.Cells["TeacherId"].Value));
                    oldTeEd = teacher.TeacherName;
                    oldTeName = dgvTeacher.CurrentRow.Cells["TeacherEducation"].Value.ToString();

                    attemMessage = "آیا از ثبت تغییرات ذیر مطمئن هستید؟" + "\n" +
                      oldTeEd + "==>" + txtTeacherName.Text + "\n" +
                      oldTeName + "==>" + txtTeacherEducation.Text + "\n";
                    if (RtlMessageBox.Show(attemMessage, "ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        teacher.TeacherName = txtTeacherName.Text;
                        teacher.TeacherEducation = txtTeacherEducation.Text;
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadDataAndForm();

                        }
                        else
                        {
                            attemMessage = "خطا در هنگام ثبت ویرایش سال تحصیلی در پایگاه داده،لطفا مجددا تلاش نمائید.یا با ادمین خود تماس حاصل فرمائید." +
                                "با تشکر ";
                            RtlMessageBox.Show(attemMessage, "خطا در ثبت  پایگاه داده", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }
        private void ReloadDataAndForm()
        {
            txtTeacherName.ResetText();
            txtTeacherEducation.ResetText();
            IEnumerable<Teacher> teachers;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                teachers = db.TeacherRepository.Get().ToList();
                dgvTeacher.DataSource = teachers;
            }

        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTeacher.CurrentRow.Cells.Count > 0)
            {
                txtTeacherName.Text = dgvTeacher.CurrentRow.Cells["TeacherName"].Value.ToString();
                txtTeacherEducation.Text = dgvTeacher.CurrentRow.Cells["TeacherEducation"].Value.ToString();
            }
        }


    }
}
