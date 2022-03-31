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
                    "رشته ی مربوط به این درس :" + txtFkFileldId.Text+ "\n";
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
