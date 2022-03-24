using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using ValidationComponents;

namespace SchoolManagment.App
{
    public partial class GradeForm : Form
    {
        public GradeForm()
        {
            InitializeComponent();
        }
        //Load the Data to the Form
        private void GradeForm_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }
        //Adding new Grade
        private void btnAddNewGrade_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                int result = 0;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {

                    Grade grade = new Grade()
                    {
                        GradeName = txtGradeName.Text,
                        FkGradePrequiestis = db.GradeRepository.GetIdByName(txtPrereustisGrade.Text)
                    };
                    string AddingAttemp = $"آیا از اضافه نمودن مقطع {grade.GradeName} با پیش نیاز {txtPrereustisGrade.Text} مطمئن هستید؟";
                    if (RtlMessageBox.Show(AddingAttemp, "اضافه نمودن مقطع تحصیلی جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        db.GradeRepository.Insert(grade);
                        result = db.Save();
                    }


                }
                if (result <= 0)
                {
                    RtlMessageBox.Show("عملیات افزودن ناموفق بود.لطفا مجددا امتحان نمایئد یا با ادمین خود تماس بگیرید.", " خطای دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    ReloadFormAndData();
                }

            }

        }

        //Delete Selected Row Of Grade
        private void btnDeleteSelectedGrade_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (dgvGrades.CurrentRow != null)
                {
                    int result = 0;
                    string deletingAttemp = String.Format("آیا از حذف مقطع {0} مطمئن هستید?", txtGradeName.Text);
                    if (RtlMessageBox.Show(deletingAttemp, "حذف مقطع تحصیلی", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                        {
                            db.GradeRepository.Delete(Convert.ToInt32(dgvGrades.CurrentRow.Cells["PkGradeId"].Value));
                            result = db.Save();
                        }
                        if (result <= 0)
                        {
                            RtlMessageBox.Show("عملیات حذف ناموفق بود.لطفا مجددا امتحان نمایئد یا با ادمین خود تماس بگیرید.", " خطای دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ReloadFormAndData();
                        }
                    }

                }
            }
        }

        //Update Selected Grade and Submit Changes
        private void btnUpdateSelectedGrade_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string oldGradeName;
                string oldGradePrereuqust;

                if (dgvGrades.CurrentRow != null)
                {
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        Grade grade = db.GradeRepository.GetById(Convert.ToInt32(dgvGrades.CurrentRow.Cells["PkGradeId"].Value));

                        
                        if (grade != null)
                        {
                            int result;
                            oldGradeName = grade.GradeName;
                            oldGradePrereuqust = db.GradeRepository.GetNameById(grade.FkGradePrequiestis);
                            string UpdateAttempString = "آیا از ثبت تغییرات زیر مطمئن هستید؟" + "\n" + "نام مقطع قبلی:" + "\"" + oldGradeName + "\"" + "نام مقطع جدید:" + "\"" + txtGradeName.Text + "\"" +
                                "\n" + "پیشنیاز قبلی:" + "\"" + oldGradePrereuqust + "\"" + "پیشنیاز جدید :" + "\"" + txtPrereustisGrade.Text + "\"";
                            if (RtlMessageBox.Show(UpdateAttempString, "تغییر اطلاعات مقطع تحصیلی", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                grade.GradeName = txtGradeName.Text;
                                grade.FkGradePrequiestis = db.GradeRepository.GetIdByName(txtPrereustisGrade.Text);
                                db.GradeRepository.Update(grade);
                                result = db.Save();

                                if (result <= 0)
                                {
                                    RtlMessageBox.Show("عملیات ثبت تغییرات ناموفق بود.لطفا مجددا امتحان نمایئد یا با ادمین خود تماس بگیرید.", " خطای دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    ReloadFormAndData();
                                }
                            }
                        }
                    }
                }
            }
        }
        //Asign the item to its controls
        private void dgvGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrades.CurrentRow != null)
            {
                txtGradeName.Text = dgvGrades.CurrentRow.Cells["GradeName"].Value.ToString();
                txtPrereustisGrade.SelectedIndex = txtPrereustisGrade.FindStringExact(dgvGrades.CurrentRow.Cells["FkGradePrequiestisString"].Value.ToString());
            }
        }
        //Load the data for GridView And Combobox of Grade Form
        private void ReloadFormAndData()
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                dgvGrades.AutoGenerateColumns = false;
                txtGradeName.Text = string.Empty;
                IEnumerable<GradeGridViewModel> gradeGridViewModels = db.GradeRepository.Get().Select(g => new GradeGridViewModel { PkGradeId = g.PkGradeId, FkGradePrequiestisString = db.GradeRepository.GetNameById(Convert.ToInt32(g.FkGradePrequiestis)), FkGradePrequiestis = Convert.ToInt32(g.FkGradePrequiestis), GradeName = g.GradeName }).ToList();
                dgvGrades.DataSource = gradeGridViewModels;
                txtPrereustisGrade.Items.Clear();
                GradeGridViewModel gradeViModel = new GradeGridViewModel()
                {
                    PkGradeId = 0,
                    GradeName = "بدون پیشنیاز"
                };
                txtPrereustisGrade.DisplayMember = "GradeName";
                txtPrereustisGrade.ValueMember = "PkGradeId";
                txtPrereustisGrade.Items.Add(gradeViModel);
                txtPrereustisGrade.Items.AddRange(gradeGridViewModels.ToArray());
                txtPrereustisGrade.SelectedIndex = txtPrereustisGrade.Items.IndexOf(gradeViModel);
            }
        }




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }


    }
}
