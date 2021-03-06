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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region ManagementInfoMeno

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnGradeInformation_Click(object sender, EventArgs e)
        {
            GradeForm frmGrade = new GradeForm();
            frmGrade.ShowDialog();
        }
        private void btnUnderGradeInformation_Click(object sender, EventArgs e)
        {
            UnderGradeForm frmUnderGrade = new UnderGradeForm();
            frmUnderGrade.ShowDialog();
        }

        private void btnAcademyYearInformation_Click(object sender, EventArgs e)
        {
            AcademyYearForm frmAcademyYear = new AcademyYearForm();
            frmAcademyYear.ShowDialog();
            
        }

        private void btnFileldsInformation_Click(object sender, EventArgs e)
        {
            FormField formField = new FormField();
            formField.ShowDialog();
        }

        private void btnLessonInformation_Click(object sender, EventArgs e)
        {
            FormLesson frmLesson = new FormLesson();
            frmLesson.ShowDialog();
        }

        private void btnStudentInformation_Click(object sender, EventArgs e)
        {
            FormStudent frmStudent = new FormStudent();
            frmStudent.ShowDialog();
        }

        private void btnTeacherInfo_Click(object sender, EventArgs e)
        {
            FormTeacher frmTeacher = new FormTeacher();
            frmTeacher.ShowDialog();
        }

        private void btnClassroomInformation_Click(object sender, EventArgs e)
        {
            FormClass frmClass = new FormClass();
            frmClass.ShowDialog();
        }

        private void TeacherCanTeachLessons_Click(object sender, EventArgs e)
        {
            FormTeacherCanTeachLessons formTeacherCanTeachLessons = new FormTeacherCanTeachLessons();
            formTeacherCanTeachLessons.ShowDialog();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            FormCalender frmCalender = new FormCalender();
            frmCalender.ShowDialog();
        }
        #endregion

        #region ManagmentNewAcademyYearMeno
        private void btnUnderGradutesInNewAcademyYear_Click(object sender, EventArgs e)
        {
            FormUnderGradutesInNewAcademyYearRepository formUnderGradutesInNewAcademyYearRepository = new FormUnderGradutesInNewAcademyYearRepository();
            formUnderGradutesInNewAcademyYearRepository.ShowDialog();
        }

        private void btnFieldsOfNewYearInUnGradutes_Click(object sender, EventArgs e)
        {
            FormFieldsOfNewYearInUnGradutes formFieldsOfNewYearInUnGradutes = new FormFieldsOfNewYearInUnGradutes();
            formFieldsOfNewYearInUnGradutes.ShowDialog();

        }
        private void btnLessonsOfFileldsOfNewYearInUngrade_Click(object sender, EventArgs e)
        {
            FormLessonsOfFileldsOfNewYearInUngrade formLessonsOfFileldsOfNewYearInUngrade = new FormLessonsOfFileldsOfNewYearInUngrade();
            formLessonsOfFileldsOfNewYearInUngrade.ShowDialog();
        }
        private void btnTeacherTeachsLessonsOfNewYearInUnGrades_Click(object sender, EventArgs e)
        {
            FormTeacherTeachsLessonsOfNewYearInUnGrades frmTeacherTeachsLessonsOfNewYearInUnGrades = new FormTeacherTeachsLessonsOfNewYearInUnGrades();
            frmTeacherTeachsLessonsOfNewYearInUnGrades.ShowDialog();
        }

        #endregion

        private void btnTeacherTeachLessonAccordingToCalender_Click(object sender, EventArgs e)
        {
            FormTeacherTeachLessonAccordingToCalender formTeacherTeachLessonAccordingToCalender = new FormTeacherTeachLessonAccordingToCalender();
            formTeacherTeachLessonAccordingToCalender.ShowDialog();
        }

        private void btnSelectCalenderToLesson_Click(object sender, EventArgs e)
        {
            FormTeacherTeachLessonAccToCalenderInClass formTeacherTeachLessonAccToCalenderInClass = new FormTeacherTeachLessonAccToCalenderInClass() ;
            formTeacherTeachLessonAccToCalenderInClass.ShowDialog();
        }

        private void btnAssignStudentToClass_Click(object sender, EventArgs e)
        {
            FormStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass formStudenToClasses = new FormStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass();
            formStudenToClasses.ShowDialog();
        }

        private void btnSetScore_Click(object sender, EventArgs e)
        {
            FormScoreOfStudentsForLessons formScoreOfStudentsForLessons = new FormScoreOfStudentsForLessons();
            formScoreOfStudentsForLessons.ShowDialog();
        }

        private void btnPresentsOrNot_Click(object sender, EventArgs e)
        {
            FormStudenPresentDetail formStudenPresentDetail = new FormStudenPresentDetail();
            formStudenPresentDetail.ShowDialog();
        }

        private void btnReportCard_Click(object sender, EventArgs e)
        {
            FormStudentReportCardAndDetail formStudentReportCardAndDetail = new FormStudentReportCardAndDetail();
            formStudentReportCardAndDetail.ShowDialog();
        }
    }
}
