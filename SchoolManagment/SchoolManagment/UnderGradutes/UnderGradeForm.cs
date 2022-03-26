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
using SchoolManagment.DataLayer;
using SchoolManagment.ViewModel;
using ValidationComponents;

namespace SchoolManagment.App
{
    public partial class UnderGradeForm : Form
    {
        public UnderGradeForm()
        {
            InitializeComponent();
        }

        private void UnderGradeForm_Load(object sender, EventArgs e)
        {
            ReloadFromAndData();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadFromAndData();
        }
        private void ReloadFromAndData()
        {
            IEnumerable<UnderGradutesViewModel> underGradutesViewModels;
            IEnumerable<Grade> grades;
            txtFkGradeId.Items.Clear();
            txtUnGradutePrequestis.Items.Clear();
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                IEnumerable<UnderGradute> underGradutes = db.UnderGraduteRepository.Get();
                dgvUnderGradutes.AutoGenerateColumns = false;
                underGradutesViewModels = db.UnderGraduteRepository.Get().Select(un => new UnderGradutesViewModel()
                {
                    PkUnGraduteId = un.PkUnGraduteId,
                    FkGradeId = un.FkGradeId,
                    FkGradeIdString = db.GradeRepository.GetNameById(un.FkGradeId),
                    FkUnGradutePrequestis = un.FkUnGradutePrequestis.GetValueOrDefault(),
                    FkUnGradutePrequestisString = db.UnderGraduteRepository.GetNameById(un.FkUnGradutePrequestis.GetValueOrDefault()),
                    UnGraduteName = un.UnGraduteName
                });
                dgvUnderGradutes.DataSource = underGradutesViewModels.ToList();

                UnderGradutesViewModel underGrade = new UnderGradutesViewModel()
                {
                    FkGradeId = 0,
                    FkGradeIdString = "0",
                    FkUnGradutePrequestis = 0,
                    FkUnGradutePrequestisString = "0",
                    PkUnGraduteId = 0,
                    UnGraduteName = "بدون پیشنیاز"
                };
                txtUnGradutePrequestis.DisplayMember = "UnGraduteName";
                txtUnGradutePrequestis.ValueMember = "PkUnGraduteId";
                txtUnGradutePrequestis.Items.Add(underGrade);
                txtUnGradutePrequestis.Items.AddRange(underGradutesViewModels.ToArray());
                txtUnGradutePrequestis.SelectedIndex = txtUnGradutePrequestis.Items.IndexOf(underGrade);
                txtFkGradeId.DisplayMember = "GradeName";
                txtFkGradeId.ValueMember = "PkGradeId";
                grades = db.GradeRepository.Get();
                txtFkGradeId.Items.AddRange(grades.ToArray());
                txtFkGradeId.SelectedIndex = txtFkGradeId.Items.IndexOf(grades.First());

            }
            txtUnGraduteName.Text = string.Empty;
            txtUnGraduteName.Focus();
        }

        private void btnAddNewUnderGradute_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result;
            if (BaseValidator.IsFormValid(this.components))
            {
                if (txtFkGradeId.SelectedIndex != -1)
                {
                    if (txtUnGradutePrequestis.SelectedIndex != -1)
                    {
                        using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                        {
                            UnderGradute underGradute = new UnderGradute()
                            {
                                UnGraduteName = txtUnGraduteName.Text,
                                FkUnGradutePrequestis = db.UnderGraduteRepository.GetIdByName(txtUnGradutePrequestis.Text),
                                FkGradeId = db.GradeRepository.GetIdByName(txtFkGradeId.Text)
                            };
                            db.UnderGraduteRepository.Insert(underGradute);
                            attemMessage = "آیا از افزودن زیر مقطع با نام" + "\"" + underGradute.UnGraduteName + "\"" + "مطمئن هستید؟";
                            if (RtlMessageBox.Show(attemMessage, "افزودن فرد جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                result = db.Save();
                                if (result > 0)
                                {
                                    ReloadFromAndData();

                                }
                                else
                                {
                                    attemMessage = "خطا در هنگام افزودن زیرمقطع جدید در پایگاه داده،لطفا مجددا تلاش نمائید.یا با ادمین خود تماس حاصل فرمائید." +
                                        "با تشکر ";
                                    RtlMessageBox.Show(attemMessage, "خطا در ثبت  پایگاه داده", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                }
                            }

                        }
                    }
                    else
                    {
                        attemMessage = "لطفا مقدار پیشنیازاین مقطع را انتخاب نمائید.";
                        RtlMessageBox.Show(attemMessage, "پر کردن مقادیر الزامی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    attemMessage = "لطفا مقدار مقطع تحصیلی مربوط به این مقطع را انتخاب نمائید.";
                    RtlMessageBox.Show(attemMessage, "پر کردن مقادیر الزامی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnDeleteSelectedUnderGradute_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result;
            if (dgvUnderGradutes.SelectedCells.Count > 0 && txtUnGraduteName.Text != string.Empty)
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    attemMessage = "آیا از حذف زیر مقطع با نام" + "\"" + txtUnGraduteName.Text + "\"" + "مطمئن هستید؟";
                    if (RtlMessageBox.Show(attemMessage, "حذف زیرمقطع", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        db.UnderGraduteRepository.Delete(Convert.ToInt32(dgvUnderGradutes.CurrentRow.Cells["PkUnGraduteId"].Value));
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadFromAndData();
                        }
                        else
                        {
                            attemMessage = "خطا در هنگام حذف زیرمقطع در پایگاه داده،لطفا مجددا تلاش نمائید.یا با ادمین خود تماس حاصل فرمائید." +
                                                "با تشکر ";
                            RtlMessageBox.Show(attemMessage, "خطا در حذف از پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            else
            {
                attemMessage = "لطفا یک زیرمقطع را برای حذف شدن از لیست زیرمقطع ها انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب زیر مقطع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvUnderGradutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtUnGraduteName.Text = dgvUnderGradutes.CurrentRow.Cells["UnGraduteName"].Value.ToString();
            txtFkGradeId.Text = dgvUnderGradutes.CurrentRow.Cells["FkGradeId"].Value.ToString();
            txtUnGradutePrequestis.Text = dgvUnderGradutes.CurrentRow.Cells["FkUnGradutePrequestis"].Value.ToString();
        }

        private void btnUpdateSelectedUnderGrade_Click(object sender, EventArgs e)
        {
            string attemMessage;
            string oldUnGrName;
            string oldUnPre;
            string oldGrade;
            int result;
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    UnderGradute oldUnGradute = db.UnderGraduteRepository.GetById(Convert.ToInt32(dgvUnderGradutes.CurrentRow.Cells["PkUnGraduteId"].Value.ToString()));
                    oldGrade = dgvUnderGradutes.CurrentRow.Cells["FkGradeId"].Value.ToString();
                    oldUnPre = dgvUnderGradutes.CurrentRow.Cells["FkUnGradutePrequestis"].Value.ToString();
                    oldUnGrName = dgvUnderGradutes.CurrentRow.Cells["UnGraduteName"].Value.ToString();
                    attemMessage = "آیا از ثبت تغییرات ذیر مطمئن هستید؟" +"\n"+
                        oldUnGrName + "==>" + txtUnGraduteName.Text + "\n" +
                        oldGrade + "==>" + txtFkGradeId.Text + "\n" +
                        oldUnPre + "==>" + txtUnGradutePrequestis.Text + "\n";
                    if (RtlMessageBox.Show(attemMessage, "ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        oldUnGradute.UnGraduteName = txtUnGraduteName.Text;
                        oldUnGradute.FkGradeId = db.GradeRepository.GetIdByName(txtFkGradeId.Text);
                        oldUnGradute.FkUnGradutePrequestis = db.UnderGraduteRepository.GetIdByName(txtUnGradutePrequestis.Text);
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadFromAndData();

                        }
                        else
                        {
                            attemMessage = "خطا در هنگام ثبت ویرایش زیرمقطع  در پایگاه داده،لطفا مجددا تلاش نمائید.یا با ادمین خود تماس حاصل فرمائید." +
                                "با تشکر ";
                            RtlMessageBox.Show(attemMessage, "خطا در ثبت  پایگاه داده", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            else
            {
                attemMessage = "لطفا مقادیر لازم را پرنمائید...";
                RtlMessageBox.Show(attemMessage, "پر کردن مقادیر الزامی", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

