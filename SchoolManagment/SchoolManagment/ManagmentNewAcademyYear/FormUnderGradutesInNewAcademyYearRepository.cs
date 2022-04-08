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
    public partial class FormUnderGradutesInNewAcademyYearRepository : Form
    {
        public FormUnderGradutesInNewAcademyYearRepository()
        {
            InitializeComponent();
            dgvAcademyYears.AutoGenerateColumns = false;
            
            dgvUnderGradutes.AutoGenerateColumns = false;
           
            dgvSelectedUnGradeInNewYear.AutoGenerateColumns = false;
            
        }

        private void FormUnderGradutesInNewAcademyYearRepository_Load(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }
        private void btnAddUnGradeToNewYear_Click(object sender, EventArgs e)
        {
            
            int result;
            using (UnderGradutesInNewAcademyYearHandler underGradutesInNewAcademyYearHandler=new UnderGradutesInNewAcademyYearHandler())
            {
               result= underGradutesInNewAcademyYearHandler.InsertUnGradeToAcademyYear(dgvAcademyYears, dgvUnderGradutes);
                if (result>0)
                {
                    ReloadDataAndForm();
                }
            }

        }
        private void btnDeleteSelectedUnFromAcademyYear_Click(object sender, EventArgs e)
        {
            int result;
            using (UnderGradutesInNewAcademyYearHandler underGradutesInNewAcademyYearHandler=new UnderGradutesInNewAcademyYearHandler())
            {
               result= underGradutesInNewAcademyYearHandler.DeleteUnGradeFromAcademyYear(dgvAcademyYears, dgvSelectedUnGradeInNewYear);
                if (result>0)
                {
                    ReloadDataAndForm();
                }
                
            }
        }
        private void ReloadDataAndForm()
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
            
            IEnumerable<UnderGradutesViewModel> underGradutesViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                IEnumerable<UnderGradute> underGradutes = db.UnderGraduteRepository.Get();
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
            }
            dgvAcademyYears.MultiSelect = false;
            dgvAcademyYears.CurrentCell = null;

            dgvUnderGradutes.MultiSelect = false;
            dgvUnderGradutes.CurrentCell = null;
            
            dgvSelectedUnGradeInNewYear.MultiSelect = false;
            dgvSelectedUnGradeInNewYear.CurrentCell = null;
           
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


    }
}
