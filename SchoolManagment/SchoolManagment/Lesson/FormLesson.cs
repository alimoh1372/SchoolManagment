using SchoolManagment.DataLayer;
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
using SchoolManagment.ViewModel;
using ValidationComponents;

namespace SchoolManagment.App
{
    public partial class FormLesson : Form
    {
        public FormLesson()
        {
            InitializeComponent();
            dgvLessons.AutoGenerateColumns = false;
        }

        private void FormLesson_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void btnAddNewLesson_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string attemMessage;
                int result = 0;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    Lesson lesson = new Lesson()
                    {
                        LessonName = txtLessonName.Text,
                        LessonUnits = Convert.ToInt32(txtLessonUnits.Value),
                        FkFileldId = Convert.ToInt32(txtFkFileldId.SelectedValue)
                    };
                    attemMessage = "آیا از افزودن درسی  با مشخصات زیر مطمئن هستید؟" + "\n" +
                   "نام درس:" + lesson.LessonName + "\n" +
                   "تعداد واحد:" + lesson.LessonUnits + "\n" +
                    "رشته ی مربوط به این درس :" + txtFkFileldId.Text + "\n";
                    if (RtlMessageBox.Show(attemMessage, "افزودن درس جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.LessonRepository.Insert(lesson);
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadFormAndData();
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

        private void btnDeleteSelectedLesson_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result;
            if (dgvLessons.CurrentRow.Cells.Count > 0 && dgvLessons.CurrentRow.Cells["LessonName"].Value.ToString() == txtLessonName.Text && BaseValidator.IsFormValid(this.components))
            {

                attemMessage = "آیا از حذف درس با مشخصات زیر مطمئن هستید؟" + "\n" +
                       "نام درس :" + dgvLessons.CurrentRow.Cells["LessonName"].Value.ToString() + "\n" +
                       "تعداد واحد :" + dgvLessons.CurrentRow.Cells["LessonUnits"].Value.ToString() + "\n" +
                       "نام رشته :" + dgvLessons.CurrentRow.Cells["FkFileldIdString"].Value.ToString();
                if (RtlMessageBox.Show(attemMessage, "حذف درس", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        db.LessonRepository.Delete(Convert.ToInt32(dgvLessons.CurrentRow.Cells["PKLessonId"].Value));
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadFormAndData();
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
                attemMessage = "لطفا یک درس از لیست (جهت حذف) انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب درس", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnUpdateSelectedLesson_Click(object sender, EventArgs e)
        {
            string attemMessage;
            string oldLeName;
            string oldLeUnitString;
            string oldLeFlString;
            int result;
            if (dgvLessons.CurrentRow.Cells.Count > 0 && BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    Lesson lesson = db.LessonRepository.GetById(Convert.ToInt32(dgvLessons.CurrentRow.Cells["PKLessonId"].Value));
                   oldLeName = lesson.LessonName;
                    oldLeUnitString = lesson.LessonUnits.ToString();
                    oldLeFlString = dgvLessons.CurrentRow.Cells["FkFileldIdString"].Value.ToString();
                    attemMessage = "آیا از ثبت تغییرات ذیر مطمئن هستید؟" + "\n" +
                      oldLeName + "==>" + txtLessonName.Text + "\n" +
                      oldLeUnitString.ToString() + "==>" + txtLessonUnits.Value + "\n" +
                      oldLeFlString + "==>" + txtFkFileldId.Text + "\n";
                    if (RtlMessageBox.Show(attemMessage, "ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lesson.LessonName = txtLessonName.Text;
                        lesson.LessonUnits = Convert.ToInt32(txtLessonUnits.Value);
                        lesson.FkFileldId = Convert.ToInt32(txtFkFileldId.SelectedValue.ToString());
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadFormAndData();

                        }
                        else
                        {
                            attemMessage = "خطا در هنگام ثبت ویرایش در پایگاه داده،لطفا مجددا تلاش نمائید.یا با ادمین خود تماس حاصل فرمائید." +
                                "با تشکر ";
                            RtlMessageBox.Show(attemMessage, "خطا در ثبت  پایگاه داده", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }












        private void ReloadFormAndData()
        {
            txtLessonName.Text = string.Empty;
            txtLessonUnits.Value = 0;
            txtFkFileldId.DataSource = null;
            txtFkFileldId.DisplayMember = "FieldName";
            txtFkFileldId.ValueMember = "PkFieldId";
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                IEnumerable<LessonViewModel> lessonViewModels = db.LessonRepository.FillViewModel();
                IEnumerable<Field> fields = db.FieldRepository.Get();
                dgvLessons.DataSource = lessonViewModels.ToList();
                txtFkFileldId.DataSource = fields.ToList();
            }
            txtFkFileldId.SelectedIndex = 0;
        }

        private void dgvLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLessons.SelectedCells.Count > 0)
            {
                txtLessonName.Text = dgvLessons.CurrentRow.Cells["LessonName"].Value.ToString();
                txtLessonUnits.Value = Convert.ToInt32(dgvLessons.CurrentRow.Cells["LessonUnits"].Value.ToString());
                txtFkFileldId.SelectedValue = Convert.ToInt32(dgvLessons.CurrentRow.Cells["FkFileldId"].Value.ToString());
            }

        }

    }
}
