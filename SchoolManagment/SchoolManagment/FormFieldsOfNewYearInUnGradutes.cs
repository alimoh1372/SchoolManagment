using SchoolManagment.Bussiness;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.Utility;
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

namespace SchoolManagment.App
{
    public partial class FormFieldsOfNewYearInUnGradutes : Form
    {
        public FormFieldsOfNewYearInUnGradutes()
        {
            InitializeComponent();
            dgvAcademyYears.AutoGenerateColumns = false;
            dgvSelectedUnGradeInNewYear.AutoGenerateColumns = false;
            dgvSelectedFields.AutoGenerateColumns = false;
            dgvFields.AutoGenerateColumns = false;
        }
        private void btnAddNewFieldToUngradeInNewYear_Click(object sender, EventArgs e)
        {
            int result;
            using (FieldsOfNewYearInUnGradutesHandler fieldsOfNewYearInUnGradutesHandler = new FieldsOfNewYearInUnGradutesHandler())
            {
                result = fieldsOfNewYearInUnGradutesHandler.InsertFieldToUngraduteInNewYear(dgvAcademyYears, dgvSelectedUnGradeInNewYear, dgvFields);
                if (result > 0)
                {
                    ReloadFormAndData();
                }
            }
        }

        private void btnDeleteSelectedField_Click(object sender, EventArgs e)
        {
            int result=-1;
            using (FieldsOfNewYearInUnGradutesHandler fieldsOfNewYearInUnGradutesHandler = new FieldsOfNewYearInUnGradutesHandler())
            {
                result = fieldsOfNewYearInUnGradutesHandler.DeleteFieldFromUnGraduteInNewYear(dgvAcademyYears, dgvSelectedUnGradeInNewYear, dgvSelectedFields);
                if (result > 0)
                {
                    ReloadFormAndData();
                }
            }
        }
        private void FormFieldsOfNewYearInUnGradutes_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void ReloadFormAndData()
        {

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
            dgvAcademyYears.MultiSelect = false;
            dgvAcademyYears.CurrentCell = null;

            dgvSelectedUnGradeInNewYear.DataSource = null;

            dgvFields.DataSource = null;
            dgvFields.MultiSelect = false;
            dgvFields.CurrentCell = null;


            dgvSelectedUnGradeInNewYear.MultiSelect = false;
            dgvSelectedUnGradeInNewYear.CurrentCell = null;
            dgvSelectedFields.DataSource = null;
            dgvSelectedFields.MultiSelect = false;
            dgvSelectedFields.CurrentCell = null;
            dgvSelectedUnGradeInNewYear.DataSource = null;

        }

        private void dgvAcademyYears_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAcademyYears.CurrentCell != null)
            {
                IEnumerable<UnderGradutesViewModel> underGradutesViewModels;
                int academyYearId = Convert.ToInt32(dgvAcademyYears.CurrentRow.Cells["AcademyYearId"].Value.ToString());
                if (academyYearId != 0)
                {
                    using (UnderGradutesInNewAcademyYearHandler underGradutesInNewAcademyYearHandler = new UnderGradutesInNewAcademyYearHandler())
                    {
                        underGradutesViewModels = underGradutesInNewAcademyYearHandler.GetUnderGradutesViewModels(academyYearId);
                        dgvSelectedUnGradeInNewYear.DataSource = underGradutesViewModels;
                        dgvSelectedUnGradeInNewYear.CurrentCell = null;
                    }
                }

            }
        }

        private void dgvSelectedUnGradeInNewYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSelectedUnGradeInNewYear.CurrentCell != null && dgvSelectedUnGradeInNewYear.CurrentRow != null && dgvSelectedUnGradeInNewYear.SelectedCells.Count > 0)
            {
                int selectedUnderGradutesId = Convert.ToInt32(dgvSelectedUnGradeInNewYear.CurrentRow.Cells["PkUnGraduteId1"].Value.ToString());
                if (selectedUnderGradutesId > 0)
                {
                    IEnumerable<IFieldViewModel> fieldViewModels;
                    IEnumerable<IFieldViewModel> selectedFieldInUndergraduteInnewYear;
                    
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        fieldViewModels = db.FieldRepository.FillFieldViewModel();
                        fieldViewModels = fieldViewModels.Where(fi => fi.FKUnGraduteId == selectedUnderGradutesId);
                        dgvFields.DataSource = fieldViewModels.ToList();

                        
                        int academyYearId = Convert.ToInt32(dgvAcademyYears.CurrentRow.Cells[0].Value.ToString());
                        int underGradutesId = Convert.ToInt32(dgvSelectedUnGradeInNewYear.CurrentRow.Cells[0].Value.ToString());
                        int unGradutesinvewId = db.UnderGradutesInNewAcademyYearRepository.GetIdByAcademyAndUngradutes(academyYearId, underGradutesId);
                        IEnumerable<FieldsOfNewYearInUnGradute> fieldsOfNewYearInUnGradutes = db.FieldsOfNewYearInUnGradutesRepository.GetIncludeEntity(t => t.Field).Where(fiu => fiu.FkUnGradutesInNewYearId == unGradutesinvewId);
                        selectedFieldInUndergraduteInnewYear = fieldsOfNewYearInUnGradutes.Select(un => new FieldViewModel()
                        {
                            PkFieldId = un.Field.PkFieldId,
                            FieldName = un.Field.FieldName,
                            FKUnGraduteId = un.Field.FKUnGraduteId,
                            FKUnGraduteIdString = un.Field.UnderGradute.UnGraduteName + " " + un.Field.UnderGradute.Grade.GradeName
                        });

                        dgvSelectedFields.DataSource = selectedFieldInUndergraduteInnewYear.ToList();

                        dgvSelectedFields.MultiSelect = false;
                        dgvSelectedFields.CurrentCell = null;

                    }
                }
            }
        }

       
    }
}
