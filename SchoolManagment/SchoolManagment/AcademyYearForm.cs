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
            }).ToList() ;
            txtEndDateText.Text = string.Empty;
            txtStartDateText.Text = string.Empty;
            txtDtEndDate.ClearDateTime();
            txtDtStartDate.ClearDateTime();
            txtNumberOfDaysOfYear.Text = string.Empty;
            
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
            if (txtEndDateText.Text !=string.Empty && txtStartDateText.Text !=string.Empty)
            {
                txtNumberOfDaysOfYear.Text = txtStartDateText.Text.TotalDaysBetweenTwoDate(txtEndDateText.Text).ToString();
            }
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

        private void btnAddNewAcademyYear_Click(object sender, EventArgs e)
        {
          
        }
    }
}
