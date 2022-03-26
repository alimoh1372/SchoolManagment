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
            txtFKUnGraduteId.DisplayMember = "FKUnGraduteIdString";
            txtFKUnGraduteId.ValueMember = "FKUnGraduteId";
            dgvFields.AutoGenerateColumns = false;
            IEnumerable<IFieldViewModel> fieldViewModels;
            using (UnitOfWork db=new UnitOfWork(new SchoolManagmentEntities()))
            {
                fieldViewModels = db.FieldRepository.FillFieldViewModel();
                dgvFields.DataSource = fieldViewModels.ToList();
                txtFKUnGraduteId.Items.AddRange(fieldViewModels.ToArray());
                txtFKUnGraduteId.SelectedIndex=0;
            }
        }

        private void dgvFields_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
