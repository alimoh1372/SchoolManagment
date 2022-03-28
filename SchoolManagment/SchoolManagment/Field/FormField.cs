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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadDataAndForm();
        }
        private void ReloadDataAndForm()
        {
            txtFieldName.Text = string.Empty;
            txtFKUnGraduteId.Items.Clear();
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
                txtFKUnGraduteId.Items.AddRange(underGradutesViewModels.ToArray());
                txtFKUnGraduteId.SelectedIndex = 0;
            }
        }

        private void dgvFields_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
