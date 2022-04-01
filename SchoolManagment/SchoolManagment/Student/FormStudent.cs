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
using SchoolManagment.ViewModel;
using ValidationComponents;
using SchoolManagment.Utility;

namespace SchoolManagment.App
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            dgvStudent.AutoGenerateColumns = false;
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            ReloadDataAndForm();

        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }

        private void ReloadDataAndForm()
        {

            txtStudentName.Text = string.Empty;
            txtStudentNationCode.Text = string.Empty;
            txtFkFileldId.DataSource = null;
            txtFkFileldId.DisplayMember = "FieldName";
            txtFkFileldId.ValueMember = "PkFieldId";

            IEnumerable<Field> fields;

            txtFkLastPassedUgraduteId.DataSource = null;
            txtFkLastPassedUgraduteId.ValueMember = "PkUnGraduteId";
            txtFkLastPassedUgraduteId.DisplayMember = "UnGraduteName";
            IEnumerable<IStudentViewModel> studentViewModels;

            IList<IUnderGradutesViewModel> underGradutesViewModels;
            UnderGradutesViewModel under = new UnderGradutesViewModel()
            {
                PkUnGraduteId = 0,
                UnGraduteName = "شروع به تحصیل"
            };

            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                studentViewModels = db.StudentRepository.FillStudentViewModel();
                dgvStudent.DataSource = studentViewModels.ToList();

                underGradutesViewModels = db.UnderGraduteRepository.FillUnderGradutesViewModel().ToList();
                underGradutesViewModels.Insert(0, under);
                txtFkLastPassedUgraduteId.DataSource =underGradutesViewModels ;
                txtFkLastPassedUgraduteId.SelectedValue = 0;

                fields = db.FieldRepository.Get();
                txtFkFileldId.DataSource = fields.ToList();
                txtFkFileldId.SelectedIndex = 0;
            }



        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudent.SelectedCells.Count > 0)
            {
                txtStudentName.Text = dgvStudent.CurrentRow.Cells["StudentName"].Value.ToString();
                txtStudentNationCode.Text = dgvStudent.CurrentRow.Cells["StudentNationCode"].Value.ToString();
                txtFkFileldId.SelectedValue = Convert.ToInt32(dgvStudent.CurrentRow.Cells["FkStudentFieldId"].Value.ToString());
                txtFkLastPassedUgraduteId.SelectedValue = Convert.ToInt32(dgvStudent.CurrentRow.Cells["FkLastPassedUgraduteId"].Value.ToString());
            }

        }

        private void btnAddNewLesson_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string attemMessage;
                int result = 0;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                   Student student = new Student()
                    {
                        StudentName = txtStudentName.Text,
                        StudentNationCode = txtStudentNationCode.Text.RemoveSpecialCharFromString('-'),
                        FkStudentFieldId =Convert.ToInt32(txtFkFileldId.SelectedValue.ToString()),
                        FkLastPassedUgraduteId = Convert.ToInt32(txtFkLastPassedUgraduteId.SelectedValue)
                    };
                    attemMessage = "آیا از افزودن دانش آموزی  با مشخصات زیر مطمئن هستید؟" + "\n" +
                   "نام دانش آموز:" + student.StudentName + "\n" +
                   "کد ملی :" +student.StudentNationCode + "\n" +
                   "رشته دانش آموز :" + txtFkFileldId.Text + "\n" +
                    "آخرین زیرمقطع گذرانده شده  :" + txtFkLastPassedUgraduteId.Text + "\n";
                    if (RtlMessageBox.Show(attemMessage, "افزودن دانش آموز جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.StudentRepository.Insert(student);
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
    }
}
