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

namespace SchoolManagment.App
{
    public partial class FormLesson : Form
    {
        public FormLesson()
        {
            InitializeComponent();
            dgvLessons.AutoGenerateColumns = false;
        }

        private void FormLesson_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }














        private void ReloadFormAndData()
        {
            txtLessonName.Text = string.Empty;
            txtLessonUnits.Text = string.Empty;
            txtFkFileldId.DataSource = null;
            txtFkFileldId.DisplayMember = "";
            txtFkFileldId.ValueMember = "";
            using (UnitOfWork db=new UnitOfWork(new SchoolManagmentEntities()))
            {
                
            }
        }
    }
}
