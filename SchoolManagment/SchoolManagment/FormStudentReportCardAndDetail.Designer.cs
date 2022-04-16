namespace SchoolManagment.App
{
    partial class FormStudentReportCardAndDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkStudentFieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkStudentFieldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLastPassedUgraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLastPassedUgraduteIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvNewAcademyYearAllLessons = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtStudentSearch = new System.Windows.Forms.TextBox();
            this.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkTeacherTeachLessonAccToCalInClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademyYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLessonIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkClassIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKTeacherTeachLessonAccordingToCalender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkCalenderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkCalenderIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherTeachLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTeacherIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkLessonOfFieldOfNewYearInUnGradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkFieldsOfNewYearInUnGradutesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFieldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkUnderGraduteInAcademyYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademyYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGraduteIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLesson = new System.Windows.Forms.DataGridView();
            this.PKLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreOfLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPassedLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAverageOfYearlessons = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllLessons)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 798);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کارنامه دانش آموز";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.dgvStudent);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1174, 228);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب دانش آموز";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1174, 205);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "انتخاب سال تحصیلی";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAverageOfYearlessons);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dgvLesson);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 450);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1174, 345);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "کارنامه و جزئیات نمرات";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.StudentNationCode,
            this.FkStudentFieldId,
            this.FkStudentFieldIdString,
            this.FkLastPassedUgraduteId,
            this.FkLastPassedUgraduteIdString});
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudent.Location = new System.Drawing.Point(3, 83);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(1168, 142);
            this.dgvStudent.TabIndex = 1;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "کد دانش آموز";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "نام دانش آموز";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentNationCode
            // 
            this.StudentNationCode.DataPropertyName = "StudentNationCode";
            this.StudentNationCode.HeaderText = "کد ملی دانش آموز";
            this.StudentNationCode.Name = "StudentNationCode";
            this.StudentNationCode.ReadOnly = true;
            // 
            // FkStudentFieldId
            // 
            this.FkStudentFieldId.DataPropertyName = "FkStudentFieldId";
            this.FkStudentFieldId.HeaderText = "کد رشته دانش آموز";
            this.FkStudentFieldId.Name = "FkStudentFieldId";
            this.FkStudentFieldId.ReadOnly = true;
            this.FkStudentFieldId.Visible = false;
            // 
            // FkStudentFieldIdString
            // 
            this.FkStudentFieldIdString.DataPropertyName = "FkStudentFieldIdString";
            this.FkStudentFieldIdString.HeaderText = "رشته دانش آموز";
            this.FkStudentFieldIdString.Name = "FkStudentFieldIdString";
            this.FkStudentFieldIdString.ReadOnly = true;
            // 
            // FkLastPassedUgraduteId
            // 
            this.FkLastPassedUgraduteId.DataPropertyName = "FkLastPassedUgraduteId";
            this.FkLastPassedUgraduteId.HeaderText = "کد آخرین زیرمقطع گذرانده شده";
            this.FkLastPassedUgraduteId.Name = "FkLastPassedUgraduteId";
            this.FkLastPassedUgraduteId.ReadOnly = true;
            this.FkLastPassedUgraduteId.Visible = false;
            // 
            // FkLastPassedUgraduteIdString
            // 
            this.FkLastPassedUgraduteIdString.DataPropertyName = "FkLastPassedUgraduteIdString";
            this.FkLastPassedUgraduteIdString.HeaderText = "آخرین زیرمقطع گدرانده شده";
            this.FkLastPassedUgraduteIdString.Name = "FkLastPassedUgraduteIdString";
            this.FkLastPassedUgraduteIdString.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.dgvNewAcademyYearAllLessons);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1168, 185);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "انتخاب یک ردیف از جدول زیر و سپس انتخاب یک تاریخ از لیست باز شونده پایین جدول جهت" +
    " نمایش لیست حضور غیاب دانش آموزان کلاس";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSearch);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1162, 50);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "جست و جو و فیلتر کردن در لیست نمایش داده شده برای درس ها(جست و جو بر اساس معلم،در" +
    "س،رشته،سال تحصیلی، تقویم وزیر مقطع میباشد)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(418, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(524, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvNewAcademyYearAllLessons
            // 
            this.dgvNewAcademyYearAllLessons.AllowUserToAddRows = false;
            this.dgvNewAcademyYearAllLessons.AllowUserToDeleteRows = false;
            this.dgvNewAcademyYearAllLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewAcademyYearAllLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewAcademyYearAllLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId,
            this.PkTeacherTeachLessonAccToCalInClassId,
            this.AcademyYearName,
            this.FkLessonIdString,
            this.FkLessonId,
            this.FkClassId,
            this.FkClassIdString,
            this.PKTeacherTeachLessonAccordingToCalender,
            this.FkCalenderId,
            this.FkCalenderIdString,
            this.TeacherTeachLessonId,
            this.FkTeacherId,
            this.FkTeacherIdString,
            this.PkLessonOfFieldOfNewYearInUnGradeId,
            this.PkFieldsOfNewYearInUnGradutesId,
            this.FkFieldId,
            this.FkFieldIdString,
            this.PkUnderGraduteInAcademyYearId,
            this.AcademyYearId,
            this.FkUnGraduteId,
            this.FkUnGraduteIdString});
            this.dgvNewAcademyYearAllLessons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNewAcademyYearAllLessons.Location = new System.Drawing.Point(3, 73);
            this.dgvNewAcademyYearAllLessons.MultiSelect = false;
            this.dgvNewAcademyYearAllLessons.Name = "dgvNewAcademyYearAllLessons";
            this.dgvNewAcademyYearAllLessons.ReadOnly = true;
            this.dgvNewAcademyYearAllLessons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewAcademyYearAllLessons.Size = new System.Drawing.Size(1162, 109);
            this.dgvNewAcademyYearAllLessons.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtStudentSearch);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(3, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1168, 60);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "جست و جوی دانش آموز(براسا نام، کد ملی و رشته و آخرین مقطع تحصیلی گذرانده شده)";
            // 
            // txtStudentSearch
            // 
            this.txtStudentSearch.Location = new System.Drawing.Point(421, 25);
            this.txtStudentSearch.Name = "txtStudentSearch";
            this.txtStudentSearch.Size = new System.Drawing.Size(524, 21);
            this.txtStudentSearch.TabIndex = 1;
            // 
            // PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId
            // 
            this.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId.DataPropertyName = "PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId";
            this.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId.HeaderText = "کد اصلی دانش آموز کلاس و درس و معلم";
            this.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId.Name = "PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId";
            this.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId.ReadOnly = true;
            this.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId.Visible = false;
            // 
            // PkTeacherTeachLessonAccToCalInClassId
            // 
            this.PkTeacherTeachLessonAccToCalInClassId.DataPropertyName = "PkTeacherTeachLessonAccToCalInClassId";
            this.PkTeacherTeachLessonAccToCalInClassId.HeaderText = "کد اصلی کلاس انتخاب شده برای تقویم";
            this.PkTeacherTeachLessonAccToCalInClassId.Name = "PkTeacherTeachLessonAccToCalInClassId";
            this.PkTeacherTeachLessonAccToCalInClassId.ReadOnly = true;
            this.PkTeacherTeachLessonAccToCalInClassId.Visible = false;
            // 
            // AcademyYearName
            // 
            this.AcademyYearName.DataPropertyName = "AcademyYearString";
            this.AcademyYearName.HeaderText = "سال تحصیلی";
            this.AcademyYearName.Name = "AcademyYearName";
            this.AcademyYearName.ReadOnly = true;
            // 
            // FkLessonIdString
            // 
            this.FkLessonIdString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FkLessonIdString.DataPropertyName = "FkLessonIdString";
            this.FkLessonIdString.HeaderText = "درس";
            this.FkLessonIdString.Name = "FkLessonIdString";
            this.FkLessonIdString.ReadOnly = true;
            this.FkLessonIdString.Visible = false;
            this.FkLessonIdString.Width = 54;
            // 
            // FkLessonId
            // 
            this.FkLessonId.DataPropertyName = "FkLessonId";
            this.FkLessonId.HeaderText = "کد درس";
            this.FkLessonId.Name = "FkLessonId";
            this.FkLessonId.ReadOnly = true;
            this.FkLessonId.Visible = false;
            // 
            // FkClassId
            // 
            this.FkClassId.DataPropertyName = "FkClassId";
            this.FkClassId.HeaderText = "کد کلاس";
            this.FkClassId.Name = "FkClassId";
            this.FkClassId.ReadOnly = true;
            this.FkClassId.Visible = false;
            // 
            // FkClassIdString
            // 
            this.FkClassIdString.DataPropertyName = "FkClassIdString";
            this.FkClassIdString.HeaderText = "کلاس";
            this.FkClassIdString.Name = "FkClassIdString";
            this.FkClassIdString.ReadOnly = true;
            this.FkClassIdString.Visible = false;
            // 
            // PKTeacherTeachLessonAccordingToCalender
            // 
            this.PKTeacherTeachLessonAccordingToCalender.DataPropertyName = "PKTeacherTeachLessonAccordingToCalender";
            this.PKTeacherTeachLessonAccordingToCalender.HeaderText = "کد اصلی کلاس برای تقویم طبق درس";
            this.PKTeacherTeachLessonAccordingToCalender.Name = "PKTeacherTeachLessonAccordingToCalender";
            this.PKTeacherTeachLessonAccordingToCalender.ReadOnly = true;
            this.PKTeacherTeachLessonAccordingToCalender.Visible = false;
            // 
            // FkCalenderId
            // 
            this.FkCalenderId.DataPropertyName = "FkCalenderId";
            this.FkCalenderId.HeaderText = "کد تقویم";
            this.FkCalenderId.Name = "FkCalenderId";
            this.FkCalenderId.ReadOnly = true;
            this.FkCalenderId.Visible = false;
            // 
            // FkCalenderIdString
            // 
            this.FkCalenderIdString.DataPropertyName = "FkCalenderIdString";
            this.FkCalenderIdString.HeaderText = "تقویم";
            this.FkCalenderIdString.Name = "FkCalenderIdString";
            this.FkCalenderIdString.ReadOnly = true;
            this.FkCalenderIdString.Visible = false;
            // 
            // TeacherTeachLessonId
            // 
            this.TeacherTeachLessonId.DataPropertyName = "TeacherTeachLessonId";
            this.TeacherTeachLessonId.HeaderText = "کد اصلی معلمی که درس را تدریس میکند";
            this.TeacherTeachLessonId.Name = "TeacherTeachLessonId";
            this.TeacherTeachLessonId.ReadOnly = true;
            this.TeacherTeachLessonId.Visible = false;
            // 
            // FkTeacherId
            // 
            this.FkTeacherId.DataPropertyName = "FkTeacherId";
            this.FkTeacherId.HeaderText = "کد معلم";
            this.FkTeacherId.Name = "FkTeacherId";
            this.FkTeacherId.ReadOnly = true;
            this.FkTeacherId.Visible = false;
            // 
            // FkTeacherIdString
            // 
            this.FkTeacherIdString.DataPropertyName = "FkTeacherIdString";
            this.FkTeacherIdString.HeaderText = "معلم";
            this.FkTeacherIdString.Name = "FkTeacherIdString";
            this.FkTeacherIdString.ReadOnly = true;
            this.FkTeacherIdString.Visible = false;
            // 
            // PkLessonOfFieldOfNewYearInUnGradeId
            // 
            this.PkLessonOfFieldOfNewYearInUnGradeId.DataPropertyName = "PkLessonOfFieldOfNewYearInUnGradeId";
            this.PkLessonOfFieldOfNewYearInUnGradeId.HeaderText = "کد اصلی درس رشته ی سال تحصیلی در زیر مقطع";
            this.PkLessonOfFieldOfNewYearInUnGradeId.Name = "PkLessonOfFieldOfNewYearInUnGradeId";
            this.PkLessonOfFieldOfNewYearInUnGradeId.ReadOnly = true;
            this.PkLessonOfFieldOfNewYearInUnGradeId.Visible = false;
            // 
            // PkFieldsOfNewYearInUnGradutesId
            // 
            this.PkFieldsOfNewYearInUnGradutesId.DataPropertyName = "PkFieldsOfNewYearInUnGradutesId";
            this.PkFieldsOfNewYearInUnGradutesId.HeaderText = "کد اصلی رشته ی سال تحصیلی جدید در زیرمقطع";
            this.PkFieldsOfNewYearInUnGradutesId.Name = "PkFieldsOfNewYearInUnGradutesId";
            this.PkFieldsOfNewYearInUnGradutesId.ReadOnly = true;
            this.PkFieldsOfNewYearInUnGradutesId.Visible = false;
            // 
            // FkFieldId
            // 
            this.FkFieldId.DataPropertyName = "FkFieldId";
            this.FkFieldId.HeaderText = "کد رشته";
            this.FkFieldId.Name = "FkFieldId";
            this.FkFieldId.ReadOnly = true;
            this.FkFieldId.Visible = false;
            // 
            // FkFieldIdString
            // 
            this.FkFieldIdString.DataPropertyName = "FkFieldIdString";
            this.FkFieldIdString.HeaderText = "رشته";
            this.FkFieldIdString.Name = "FkFieldIdString";
            this.FkFieldIdString.ReadOnly = true;
            // 
            // PkUnderGraduteInAcademyYearId
            // 
            this.PkUnderGraduteInAcademyYearId.DataPropertyName = "PkUnderGraduteInAcademyYearId";
            this.PkUnderGraduteInAcademyYearId.HeaderText = "کد اصلی زیرمقطع در سال تحصیلی جدید";
            this.PkUnderGraduteInAcademyYearId.Name = "PkUnderGraduteInAcademyYearId";
            this.PkUnderGraduteInAcademyYearId.ReadOnly = true;
            this.PkUnderGraduteInAcademyYearId.Visible = false;
            // 
            // AcademyYearId
            // 
            this.AcademyYearId.DataPropertyName = "AcademyYearId";
            this.AcademyYearId.HeaderText = "کد سال تحصیلی";
            this.AcademyYearId.Name = "AcademyYearId";
            this.AcademyYearId.ReadOnly = true;
            this.AcademyYearId.Visible = false;
            // 
            // FkUnGraduteId
            // 
            this.FkUnGraduteId.DataPropertyName = "FkUnGraduteId";
            this.FkUnGraduteId.HeaderText = "کد زیرمقطع";
            this.FkUnGraduteId.Name = "FkUnGraduteId";
            this.FkUnGraduteId.ReadOnly = true;
            this.FkUnGraduteId.Visible = false;
            // 
            // FkUnGraduteIdString
            // 
            this.FkUnGraduteIdString.DataPropertyName = "FkUnGraduteIdString";
            this.FkUnGraduteIdString.HeaderText = "زیرمقطع";
            this.FkUnGraduteIdString.Name = "FkUnGraduteIdString";
            this.FkUnGraduteIdString.ReadOnly = true;
            // 
            // dgvLesson
            // 
            this.dgvLesson.AllowUserToAddRows = false;
            this.dgvLesson.AllowUserToDeleteRows = false;
            this.dgvLesson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PKLessonId,
            this.LessonName,
            this.LessonUnits,
            this.FkFileldId,
            this.FkFileldIdString,
            this.ScoreOfLesson,
            this.IsPassedLesson});
            this.dgvLesson.Location = new System.Drawing.Point(3, 52);
            this.dgvLesson.Name = "dgvLesson";
            this.dgvLesson.ReadOnly = true;
            this.dgvLesson.Size = new System.Drawing.Size(1165, 284);
            this.dgvLesson.TabIndex = 1;
            // 
            // PKLessonId
            // 
            this.PKLessonId.DataPropertyName = "PKLessonId";
            this.PKLessonId.HeaderText = "کد درس";
            this.PKLessonId.Name = "PKLessonId";
            this.PKLessonId.ReadOnly = true;
            this.PKLessonId.Visible = false;
            // 
            // LessonName
            // 
            this.LessonName.DataPropertyName = "LessonName";
            this.LessonName.HeaderText = "نام درس";
            this.LessonName.Name = "LessonName";
            this.LessonName.ReadOnly = true;
            // 
            // LessonUnits
            // 
            this.LessonUnits.DataPropertyName = "LessonUnits";
            this.LessonUnits.HeaderText = "تعداد واحد درس";
            this.LessonUnits.Name = "LessonUnits";
            this.LessonUnits.ReadOnly = true;
            // 
            // FkFileldId
            // 
            this.FkFileldId.DataPropertyName = "FkFileldId";
            this.FkFileldId.HeaderText = "کد رشته ی درس";
            this.FkFileldId.Name = "FkFileldId";
            this.FkFileldId.ReadOnly = true;
            this.FkFileldId.Visible = false;
            // 
            // FkFileldIdString
            // 
            this.FkFileldIdString.DataPropertyName = "FkFileldIdString";
            this.FkFileldIdString.HeaderText = "رشته ی درس";
            this.FkFileldIdString.Name = "FkFileldIdString";
            this.FkFileldIdString.ReadOnly = true;
            // 
            // ScoreOfLesson
            // 
            this.ScoreOfLesson.HeaderText = "نمره درس";
            this.ScoreOfLesson.Name = "ScoreOfLesson";
            this.ScoreOfLesson.ReadOnly = true;
            // 
            // IsPassedLesson
            // 
            this.IsPassedLesson.HeaderText = "قبولی یا رد";
            this.IsPassedLesson.Name = "IsPassedLesson";
            this.IsPassedLesson.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1059, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "معدل دانش آموز :";
            // 
            // txtAverageOfYearlessons
            // 
            this.txtAverageOfYearlessons.Location = new System.Drawing.Point(891, 25);
            this.txtAverageOfYearlessons.Name = "txtAverageOfYearlessons";
            this.txtAverageOfYearlessons.ReadOnly = true;
            this.txtAverageOfYearlessons.Size = new System.Drawing.Size(100, 21);
            this.txtAverageOfYearlessons.TabIndex = 3;
            this.txtAverageOfYearlessons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormStudentReportCardAndDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 798);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStudentReportCardAndDetail";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مشاهده کارنامه دانش آموز";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllLessons)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkStudentFieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkStudentFieldIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLastPassedUgraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLastPassedUgraduteIdString;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvNewAcademyYearAllLessons;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtStudentSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkTeacherTeachLessonAccToCalInClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLessonIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkClassIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKTeacherTeachLessonAccordingToCalender;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkCalenderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkCalenderIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherTeachLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTeacherIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkLessonOfFieldOfNewYearInUnGradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkFieldsOfNewYearInUnGradutesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFieldIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkUnderGraduteInAcademyYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGraduteIdString;
        private System.Windows.Forms.DataGridView dgvLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreOfLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPassedLesson;
        private System.Windows.Forms.TextBox txtAverageOfYearlessons;
        private System.Windows.Forms.Label label1;
    }
}