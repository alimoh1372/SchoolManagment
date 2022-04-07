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
    public partial class FormField : Form
    {
        public FormField()
        {
            InitializeComponent();

        }

        private void FormField_Load(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }
        private void btnAddNewField_Click(object sender, EventArgs e)
        {

            if (BaseValidator.IsFormValid(this.components))
            {
                string attemMessage;
                int result = 0;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    Field field = new Field()
                    {
                        FieldName = txtFieldName.Text,
                        FKUnGraduteId = Convert.ToInt32(txtFKUnGraduteId.SelectedValue)
                    };
                    attemMessage = "آیا از افزودن رشته تحصیلی با مشخصات زیر مطمئن هستید؟" + "\n" +
                   "نام رشته:" + field.FieldName + "\n" +
                    "نام زیر مقطع:" + txtFKUnGraduteId.Text + "\n";
                    if (RtlMessageBox.Show(attemMessage, "افزودن رشته جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.FieldRepository.Insert(field);
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
        private void btnDeleteSelectedField_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result;
            if (dgvFields.CurrentRow.Cells.Count > 0 && dgvFields.CurrentRow.Cells["FieldName"].Value.ToString() == txtFieldName.Text && BaseValidator.IsFormValid(this.components))
            {

                attemMessage = "آیا از حذف رشته با مشخصات زیر مطمئن هستید؟" + "\n" +
                       "نام سال تحصیلی:" + dgvFields.CurrentRow.Cells["FieldName"].Value.ToString() + "\n" +
                       "نام زیرمقطع :" + dgvFields.CurrentRow.Cells["FKUnGraduteIdString"].Value.ToString();
                if (RtlMessageBox.Show(attemMessage, "افزودن رشته", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        db.FieldRepository.Delete(Convert.ToInt32(dgvFields.CurrentRow.Cells["PkFieldId"].Value));
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
                attemMessage = "لطفا یک رشته از لیست (جهت حذف) انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب رشته", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnUpdateSelectedField_Click(object sender, EventArgs e)
        {
            string attemMessage;
            string oldFlName;
            string oldFlFkUngradeString;
            int result;
            if (dgvFields.CurrentRow.Cells.Count > 0 && BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    Field field = db.FieldRepository.GetById(Convert.ToInt32(dgvFields.CurrentRow.Cells["PkFieldId"].Value));
                    oldFlName = field.FieldName;
                    oldFlFkUngradeString = dgvFields.CurrentRow.Cells["FKUnGraduteIdString"].Value.ToString();
                    attemMessage = "آیا از ثبت تغییرات ذیر مطمئن هستید؟" + "\n" +
                      oldFlName + "==>" + txtFieldName.Text + "\n" +
                      oldFlFkUngradeString + "==>" + txtFKUnGraduteId.Text + "\n";
                    if (RtlMessageBox.Show(attemMessage, "ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        field.FieldName = txtFieldName.Text;
                        field.FKUnGraduteId = Convert.ToInt32(txtFKUnGraduteId.SelectedValue);
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
            txtFieldName.Text = string.Empty;
            txtFKUnGraduteId.DataSource = null;
            txtFKUnGraduteId.DisplayMember = "UnGraduteName";
            txtFKUnGraduteId.ValueMember = "PkUnGraduteId";
            dgvFields.AutoGenerateColumns = false;
            IEnumerable<IFieldViewModel> fieldViewModels;
            IEnumerable<IUnderGradutesViewModel> underGradutesViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                fieldViewModels = db.FieldRepository.FillFieldViewModel();
                underGradutesViewModels = db.UnderGraduteRepository.FillUnderGradutesViewModel();
                dgvFields.DataSource = fieldViewModels.ToList();
                txtFKUnGraduteId.DataSource = underGradutesViewModels.ToArray();
                txtFKUnGraduteId.SelectedIndex = 0;
            }
        }

        private void dgvFields_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFields.SelectedCells.Count > 0)
            {
                txtFieldName.Text = dgvFields.CurrentRow.Cells["FieldName"].Value.ToString();
                txtFKUnGraduteId.SelectedText = dgvFields.CurrentRow.Cells["FKUnGraduteIdString"].Value.ToString();
                //txtFKUnGraduteId.Text = dgvFields.CurrentRow.Cells["FKUnGraduteIdString"].Value.ToString();
                txtFKUnGraduteId.SelectedValue = Convert.ToInt32(dgvFields.CurrentRow.Cells["FKUnGraduteId"].Value.ToString());
            }

        }

    }
}
