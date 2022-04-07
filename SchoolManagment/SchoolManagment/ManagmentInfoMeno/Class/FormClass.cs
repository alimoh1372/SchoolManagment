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
    public partial class FormClass : Form
    {
        public FormClass()
        {
            InitializeComponent();
            dgvClass.AutoGenerateColumns = false;
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            int cp;
            cp = Convert.ToInt32(txtClassCapacity.Value);

            if (BaseValidator.IsFormValid(this.components))
            {
                string attemMessage;
                int result = 0;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    Class @class = new Class()
                    {
                        ClassName = txtClassName.Text,
                        ClassLocation = txtClassLocation.Text,
                        ClassCapacity = Convert.ToInt32(txtClassCapacity.Value)
                    };
                    attemMessage = "آیا از افزودن کلاسی  با مشخصات زیر مطمئن هستید؟" + "\n" +
                   "نام کلاس :" + @class.ClassName + "\n" +
                    "مکان کلاس :" + @class.ClassLocation + "\n" +
                   "ظرفیت کلاس :" + @class.ClassCapacity + "\n";
                    if (RtlMessageBox.Show(attemMessage, "افزودن کلاس جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.ClassRepository.Insert(@class);
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

        private void btnDeleteSelectedClass_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result;
            if (dgvClass.SelectedCells.Count > 0 && dgvClass.CurrentRow.Cells["ClassName"].Value.ToString() == txtClassName.Text && BaseValidator.IsFormValid(this.components))
            {

                attemMessage = "آیا از حذف کلاس با مشخصات زیر مطمئن هستید؟" + "\n" +
                       "نام کلاس:" + dgvClass.CurrentRow.Cells["ClassName"].Value.ToString() + "\n" +
                        "مکان کلاس :" + dgvClass.CurrentRow.Cells["ClassLocation"].Value.ToString() + "\n" +
                        "ظرفیت کلاس:" + dgvClass.CurrentRow.Cells["ClassCapacity"].Value.ToString() + "\n";
                if (RtlMessageBox.Show(attemMessage, "حذف کلاس", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        db.ClassRepository.Delete(Convert.ToInt32(dgvClass.CurrentRow.Cells["PkClassId"].Value));
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

        private void btnUpdateSelectedClass_Click(object sender, EventArgs e)
        {
            string attemMessage;
            string oldClName;
            string oldClLoc;
            string oldClCap;
            int result;
            if (dgvClass.SelectedCells.Count > 0 && BaseValidator.IsFormValid(this.components))
            {

                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    Class cls = db.ClassRepository.GetById(Convert.ToInt32(dgvClass.CurrentRow.Cells["PkClassId"].Value));
                    oldClName = cls.ClassName;
                    oldClLoc = dgvClass.CurrentRow.Cells["ClassLocation"].Value.ToString();
                    oldClCap = dgvClass.CurrentRow.Cells["ClassCapacity"].Value.ToString();

                    attemMessage = "آیا از ثبت تغییرات ذیر مطمئن هستید؟" + "\n" +
                      oldClName + "==>" + txtClassName.Text + "\n" +
                      oldClLoc + "==>" + txtClassLocation.Text + "\n" +
                      oldClCap + "==>" + txtClassCapacity.Value.ToString() + "\n";
                    if (RtlMessageBox.Show(attemMessage, "ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cls.ClassName = txtClassName.Text;
                        cls.ClassLocation = txtClassLocation.Text;
                        cls.ClassCapacity = Convert.ToInt32(txtClassCapacity.Value.ToString());
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
            txtClassName.ResetText();
            txtClassLocation.ResetText();
            txtClassCapacity.Value = 0;
            IEnumerable<Class> classes;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                classes = db.ClassRepository.Get().ToList();
                dgvClass.DataSource = classes;
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClass.SelectedCells.Count > 0)
            {
                txtClassName.Text = dgvClass.CurrentRow.Cells["ClassName"].Value.ToString();
                txtClassLocation.Text = dgvClass.CurrentRow.Cells["ClassLocation"].Value.ToString();
                txtClassCapacity.Value = Convert.ToInt32(dgvClass.CurrentRow.Cells["ClassCapacity"].Value.ToString());
            }
        }


    }
}
