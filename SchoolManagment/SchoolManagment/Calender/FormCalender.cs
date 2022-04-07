using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.Bussiness;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using ValidationComponents;

namespace SchoolManagment.App
{
    public partial class FormCalender : Form
    {
        private IEnumerable<TypeDay> typeDays;
        private IEnumerable<DayAlternate> _dayAlternates;
        private IEnumerable<TimeAlterNateViewModel> _timeAlterNateViewModels;
        private bool isSelectedChangeTypeDayRun = true;

        public FormCalender()
        {
            InitializeComponent();
            dgvCalender.AutoGenerateColumns = false;
            dgvCalender.MultiSelect = false;
        }

        private void FormCalender_Load(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }

        private void ReloadDataAndForm()
        {
            IEnumerable<CalenderViewModel> _calenderViewModel;
            if (txtTypeDay.DataSource == null)
            {
                txtTypeDay.ValueMember = "PkTypeOfdayId";
                txtTypeDay.DisplayMember = "TypeOfDayDescription";

                using (TypeDayHandler typeDayHandler = new TypeDayHandler())
                {
                    typeDays = typeDayHandler.GetTypeDays();
                    txtTypeDay.DataSource = typeDays.ToList();
                    txtTypeDay.SelectedIndex = 0;
                }
            }
            else
            {
                txtTypeDay.SelectedIndex = 0;
            }
            if (txtDayAlternate.DataSource == null)
            {

                txtDayAlternate.ValueMember = "PkDayAlternateId";
                txtDayAlternate.DisplayMember = "DayAlternateDescription";

                using (DayAlternateHandler dayAlternateHandler = new DayAlternateHandler())
                {

                    _dayAlternates = dayAlternateHandler.GetDayAlternates();
                    txtDayAlternate.DataSource = _dayAlternates.Where(da => da.FkTypeDay == Convert.ToInt32(txtTypeDay.SelectedValue.ToString())).ToList();
                }
                txtDayAlternate.SelectedIndex = 0;
            }
            else
            {
                using (DayAlternateHandler dayAlternateHandler = new DayAlternateHandler())
                {
                    txtDayAlternate.DataSource = _dayAlternates.Where(da => da.FkTypeDay == Convert.ToInt32(txtTypeDay.SelectedValue.ToString())).ToList();
                }
            }
            if (txtTimeAlternate.DataSource == null)
            {
                txtTimeAlternate.DisplayMember = "timeFromToTime";
                txtTimeAlternate.ValueMember = "PkTimeId";

                using (TimeAlterNateHandler timeAlterNateHandler = new TimeAlterNateHandler())
                {
                    if (_timeAlterNateViewModels == null)
                    {
                        _timeAlterNateViewModels = timeAlterNateHandler.GetAndFillViewModel();
                    }
                }
                txtTimeAlternate.DataSource = _timeAlterNateViewModels.ToList();
                txtTimeAlternate.SelectedIndex = 0;
            }

            using (CalenderHandler calenderHandler = new CalenderHandler())
            {
                _calenderViewModel = calenderHandler.GetCalenderAndFillViewModel();
            }
            dgvCalender.DataSource = _calenderViewModel.ToList();
            dgvCalender.CurrentCell = null;
        }


        private void txtTypeDay_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_dayAlternates != null && isSelectedChangeTypeDayRun)
            {
                txtDayAlternate.DataSource = _dayAlternates.Where(da => da.FkTypeDay == Convert.ToInt32(txtTypeDay.SelectedValue.ToString())).ToList();
            }

        }
        private void btnAddCallender_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                int result = 0;
                using (CalenderHandler calenderHandler = new CalenderHandler())
                {
                    result = calenderHandler.InsertCalenderInfo(txtDayAlternate, txtTimeAlternate, txtCalenderName, txtCalenderDescription);
                    if (result > 0)
                    {
                        ReloadDataAndForm();
                    }
                }
            }
        }

        private void btnDeleteCalender_Click(object sender, EventArgs e)
        {
            
            string attemMessage;
            if ( BaseValidator.IsFormValid(this.components) && dgvCalender.SelectedCells != null && dgvCalender.CurrentRow!=null && dgvCalender.CurrentRow.Cells["CalenderName"].Value.ToString()==txtCalenderName.Text )
            {
                int result = 0;
                using (CalenderHandler calenderHandler=new CalenderHandler())
                {
                    result = calenderHandler.DeleteCalender(dgvCalender.CurrentRow);
                    if (result>0)
                    {
                        ReloadDataAndForm();
                    }
                }
            }
            else
            {
                 attemMessage = "لطفا یک تقویم از لیست (جهت حذف) انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب تقویم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnUpdateCalender_Click(object sender, EventArgs e)
        {
            
            string attemMessage;
            if (dgvCalender.SelectedCells != null && dgvCalender.CurrentRow != null && BaseValidator.IsFormValid(this.components))
            {
                int result = 0;
                using (CalenderHandler calenderHandler=new CalenderHandler())
                {
                    result=calenderHandler.UpdateCalender(dgvCalender.CurrentRow, txtDayAlternate, txtTimeAlternate, txtCalenderName, txtCalenderDescription);
                    if (result>0)
                    {
                        ReloadDataAndForm();
                    }
                }
            }
            else
            {
                attemMessage = "لطفا یک تقویم از لیست (جهت حذف) انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب تقویم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCalender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCalender.CurrentCell != null)
            {
                int selectedDayAlterNateIndex = -1;
                List<DayAlternate> customDayAlternates;
                isSelectedChangeTypeDayRun = false;
                txtCalenderName.Text = dgvCalender.CurrentRow.Cells["CalenderName"].Value.ToString();
                txtCalenderDescription.Text = dgvCalender.CurrentRow.Cells["CalenderDescription"].Value.ToString();
                if (Convert.ToByte(dgvCalender.CurrentRow.Cells["FkDayAlterNate"].Value.ToString()) <= 7)
                {
                    txtTypeDay.SelectedIndex = 0;
                    //txtTypeDay.SelectedValue = typeDays.First(ty => ty.PkTypeOfdayId == 1).PkTypeOfdayId.ToString() ;
                    //txtTypeDay.SelectedText = typeDays.First(ty => ty.PkTypeOfdayId == 1).TypeOfDayDescription;

                    customDayAlternates = _dayAlternates.Where(da => da.FkTypeDay == Convert.ToInt32(txtTypeDay.SelectedValue.ToString())).ToList();
                    txtDayAlternate.DataSource = customDayAlternates;



                }
                else
                {
                    txtTypeDay.SelectedIndex = 1;
                    customDayAlternates = _dayAlternates.Where(da => da.FkTypeDay == Convert.ToInt32(txtTypeDay.SelectedValue.ToString())).ToList();
                    txtDayAlternate.DataSource = customDayAlternates;
                }
                selectedDayAlterNateIndex = customDayAlternates.FindIndex(t => t.PkDayAlternateId == Convert.ToByte(dgvCalender.CurrentRow.Cells["FkDayAlterNate"].Value.ToString()));
                txtDayAlternate.SelectedIndex = selectedDayAlterNateIndex;
                txtTimeAlternate.SelectedValue = dgvCalender.CurrentRow.Cells["FkTimeAlterNateId"].Value;

            }
            isSelectedChangeTypeDayRun = true;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }
    }
}
