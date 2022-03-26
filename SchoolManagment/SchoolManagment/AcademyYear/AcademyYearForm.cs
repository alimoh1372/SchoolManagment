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
using SchoolManagment.Utility;
using System.Globalization;
using BehComponents;
using ValidationComponents;

namespace SchoolManagment.App
{
    public partial class AcademyYearForm : Form
    {
        public AcademyYearForm()
        {
            InitializeComponent();
        }

        private void AcademyYearForm_Load(object sender, EventArgs e)
        {
            ReloadDataAndInformation();
        }

        private void btnAddNewAcademyYear_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result;
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    AcademyYear academyYear = new AcademyYear()
                    {
                        AcademyYearName = txtAcademyYearName.Text,
                        StartDate = txtStartDateText.Text.PersianStringShortDateToDateTime(),
                        EndDate = txtEndDateText.Text.PersianStringShortDateToDateTime(),
                        NumberOfDaysOfYear = Convert.ToInt32(txtNumberOfDaysOfYear.Text)
                    };
                    attemMessage = "آیا از افزودن سال تحصیلی با مشخصات زیر مطمئن هستید؟" + "\n" +
                       "نام سال تحصیلی:" + academyYear.AcademyYearName + "\n" +
                        "تاریخ شروع :" + academyYear.StartDate.DateTimeToPersianStringShortDate() + "\n" +
                        "تاریخ پایان :" + academyYear.EndDate.DateTimeToPersianStringShortDate() + "\n" + "و...؟";

                    if (RtlMessageBox.Show(attemMessage, "افزودن سال تحصیلی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.AcademyYearRepository.Insert(academyYear);
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadDataAndInformation();
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

        private void btnDeleteSelectedAcademyYear_Click(object sender, EventArgs e)
        {
            string attemMessage;
            int result;
            if (dgvAcademyYears.CurrentRow.Cells.Count > 0 && dgvAcademyYears.CurrentRow.Cells["AcademyYearName"].Value.ToString() == txtAcademyYearName.Text && BaseValidator.IsFormValid(this.components))
            {
                attemMessage = "آیا از حذف سال تحصیلی با مشخصات زیر مطمئن هستید؟" + "\n" +
                       "نام سال تحصیلی:" + dgvAcademyYears.CurrentRow.Cells["AcademyYearName"].Value.ToString();
                if (RtlMessageBox.Show(attemMessage, "افزودن سال تحصیلی", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        db.AcademyYearRepository.Delete(Convert.ToInt32(dgvAcademyYears.CurrentRow.Cells["AcademyYearId"].Value));
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadDataAndInformation();
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
                attemMessage = "لطفا یک سال تحصیلی از لیست (جهت حذف) انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب سال تحصیلی", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
        private void btnUpdateSelectedAcademyYear_Click(object sender, EventArgs e)
        {
            string attemMessage;
            string oldAcName;
            string oldAcStartDate;
            string oldacEndDate;
            int result;
            if (dgvAcademyYears.CurrentRow.Cells.Count > 0  && BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    AcademyYear oldAc = db.AcademyYearRepository.GetById(dgvAcademyYears.CurrentRow.Cells["AcademyYearId"].Value);
                    oldAcName = oldAc.AcademyYearName;
                    oldAcStartDate = oldAc.StartDate.DateTimeToPersianStringShortDate();
                    oldacEndDate = oldAc.EndDate.DateTimeToPersianStringShortDate();
                    attemMessage = "آیا از ثبت تغییرات ذیر مطمئن هستید؟" + "\n" +
                       oldAcName + "==>" + txtAcademyYearName.Text + "\n" +
                       oldAcStartDate + "==>" + txtStartDateText.Text + "\n" +
                       oldacEndDate + "==>" + txtEndDateText.Text + "\n";
                    if (RtlMessageBox.Show(attemMessage, "ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        oldAc.AcademyYearName = txtAcademyYearName.Text;
                        oldAc.StartDate = txtStartDateText.Text.PersianStringShortDateToDateTime();
                        oldAc.EndDate = txtEndDateText.Text.PersianStringShortDateToDateTime();
                        oldAc.NumberOfDaysOfYear =Convert.ToInt32( txtNumberOfDaysOfYear.Text);
                        result = db.Save();
                        if (result > 0)
                        {
                            ReloadDataAndInformation();

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
        private void ReloadDataAndInformation()
        {
            dgvAcademyYears.AutoGenerateColumns = false;
            IEnumerable<AcademyYear> academyYears;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                academyYears = db.AcademyYearRepository.Get();
            }
            dgvAcademyYears.DataSource = academyYears.Select(ac => new
            {
                ac.AcademyYearId,
                ac.AcademyYearName,
                ac.NumberOfDaysOfYear,
                StartDate = ac.StartDate.DateTimeToPersianStringShortDate(),
                EndDate = ac.EndDate.DateTimeToPersianStringShortDate()
            }).ToList();
            txtEndDateText.Text = string.Empty;
            txtStartDateText.Text = string.Empty;
            txtDtEndDate.ClearDateTime();
            txtDtStartDate.ClearDateTime();
            txtNumberOfDaysOfYear.Text = string.Empty;

        }









        private void txtEndDateText_TextChanged(object sender, EventArgs e)
        {
            if (txtEndDateText.Text != string.Empty && txtStartDateText.Text != string.Empty)
            {
                txtNumberOfDaysOfYear.Text = txtStartDateText.Text.TotalDaysBetweenTwoDate(txtEndDateText.Text).ToString();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadDataAndInformation();
        }
        private void dgvAcademyYears_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dt = dgvAcademyYears.CurrentRow.Cells["StartDate"].Value.ToString().PersianStringShortDateToDateTime();
            txtAcademyYearName.Text = dgvAcademyYears.CurrentRow.Cells["AcademyYearName"].Value.ToString();
            txtDtStartDate.SelectedDateInDateTime = dt;
            dt = dgvAcademyYears.CurrentRow.Cells["EndDate"].Value.ToString().PersianStringShortDateToDateTime();
            txtDtEndDate.SelectedDateInDateTime = dt;


        }

        private void txtDtStartDate_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            txtStartDateText.Text = txtDtStartDate.GetSelectedDateInDateTime().ToString("yyyy/MM/dd");
        }

        private void txtDtEndDate_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            txtEndDateText.Text = txtDtEndDate.GetSelectedDateInDateTime().ToString("yyyy/MM/dd");
        }

        private void txtStartDateText_TextChanged(object sender, EventArgs e)
        {
            if (txtEndDateText.Text != string.Empty && txtStartDateText.Text != string.Empty)
            {
                txtNumberOfDaysOfYear.Text = txtStartDateText.Text.TotalDaysBetweenTwoDate(txtEndDateText.Text).ToString();
            }
        }


    }
}
