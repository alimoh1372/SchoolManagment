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
    public partial class FormTeacherTeachLessonAccToCalenderInClass : Form
    {
        private IEnumerable<ITeacherTeachLessonAccToCalenderInClassViewModel> _thisTeacherTeachLessonAccToCalenderInClassViewModels;
        public FormTeacherTeachLessonAccToCalenderInClass()
        {
            InitializeComponent();
        }

        private void FormTeacherTeachLessonAccToCalenderInClass_Load(object sender, EventArgs e)
        {
            ReloadFormAndData();
        }

        private void ReloadFormAndData()
        {
            txtSearch.Text = string.Empty;
            //Fill main datagridView
            using ()
            {

            }
            //Clear DataGridView dgvClass
            

            //Clear DataGridView dgvSelectedClasses

            
        }
    }
}
