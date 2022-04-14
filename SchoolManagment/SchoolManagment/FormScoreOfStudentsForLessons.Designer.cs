namespace SchoolManagment.App
{
    partial class FormScoreOfStudentsForLessons
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvNewAcademyYearAllLessons = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtSearchStudents = new System.Windows.Forms.TextBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnInsertDeleteSync = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvApsentStudent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkTeacherTeachLessonAccToCalInClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.AcademyYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGraduteIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkStudentFieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkStudentFieldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLastPassedUgraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLastPassedUgraduteIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreOfLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllLessons)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApsentStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1214, 818);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت نمرات دانش آموزان";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvNewAcademyYearAllLessons);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1208, 210);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب یک ردیف از جدول زیر جهت نمایش دانش آموزان و ثبت نمرات آنها";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1202, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جست و جو و فیلتر کردن در لیست نمایش داده شده برای درس ها(جست و جو بر اساس معلم،در" +
    "س،رشته،سال تحصیلی، تقویم وزیر مقطع میباشد)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(377, 20);
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
            this.AcademyYearName,
            this.FkUnGraduteId,
            this.FkUnGraduteIdString});
            this.dgvNewAcademyYearAllLessons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNewAcademyYearAllLessons.Location = new System.Drawing.Point(3, 71);
            this.dgvNewAcademyYearAllLessons.MultiSelect = false;
            this.dgvNewAcademyYearAllLessons.Name = "dgvNewAcademyYearAllLessons";
            this.dgvNewAcademyYearAllLessons.ReadOnly = true;
            this.dgvNewAcademyYearAllLessons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewAcademyYearAllLessons.Size = new System.Drawing.Size(1202, 136);
            this.dgvNewAcademyYearAllLessons.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.dgvStudent);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1208, 293);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "لیست دانش آموزان کلاس انتخاب شده-(لطفا دانش آموزانی که غیبت دارند را تیک بزنید)";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtSearchStudents);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(3, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1202, 54);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "جست و جوی دانش آموزان(بر اساس نام دانش آموز نام دانش آموز، کد ملی دانش آموز،رشته " +
    " دانش آموز آخرین مقطع فعلی دانش آموز)";
            // 
            // txtSearchStudents
            // 
            this.txtSearchStudents.Location = new System.Drawing.Point(377, 20);
            this.txtSearchStudents.Name = "txtSearchStudents";
            this.txtSearchStudents.Size = new System.Drawing.Size(524, 21);
            this.txtSearchStudents.TabIndex = 1;
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
            this.FkLastPassedUgraduteIdString,
            this.ScoreOfLesson});
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudent.Location = new System.Drawing.Point(3, 77);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(1202, 213);
            this.dgvStudent.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnInsertDeleteSync);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 520);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1208, 86);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // btnInsertDeleteSync
            // 
            this.btnInsertDeleteSync.Location = new System.Drawing.Point(512, 20);
            this.btnInsertDeleteSync.Name = "btnInsertDeleteSync";
            this.btnInsertDeleteSync.Size = new System.Drawing.Size(171, 53);
            this.btnInsertDeleteSync.TabIndex = 10;
            this.btnInsertDeleteSync.Text = "ثبت تغییرات انجام شده";
            this.btnInsertDeleteSync.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvApsentStudent);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 606);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1208, 209);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "لیست دانش آموزان غایب";
            // 
            // dgvApsentStudent
            // 
            this.dgvApsentStudent.AllowUserToAddRows = false;
            this.dgvApsentStudent.AllowUserToDeleteRows = false;
            this.dgvApsentStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApsentStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApsentStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvApsentStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApsentStudent.Location = new System.Drawing.Point(3, 17);
            this.dgvApsentStudent.Name = "dgvApsentStudent";
            this.dgvApsentStudent.ReadOnly = true;
            this.dgvApsentStudent.Size = new System.Drawing.Size(1202, 189);
            this.dgvApsentStudent.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "کد دانش آموز";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "checkboxSelectStudent";
            this.dataGridViewCheckBoxColumn1.FillWeight = 30F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "انتخاب";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            this.dataGridViewTextBoxColumn2.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn2.HeaderText = "نام دانش آموز";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StudentNationCode";
            this.dataGridViewTextBoxColumn3.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn3.HeaderText = "کد ملی دانش آموز";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FkStudentFieldId";
            this.dataGridViewTextBoxColumn4.HeaderText = "کد رشته دانش آموز";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FkStudentFieldIdString";
            this.dataGridViewTextBoxColumn5.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn5.HeaderText = "رشته دانش آموز";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FkLastPassedUgraduteId";
            this.dataGridViewTextBoxColumn6.HeaderText = "کد آخرین زیرمقطع گذرانده شده";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FkLastPassedUgraduteIdString";
            this.dataGridViewTextBoxColumn7.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn7.HeaderText = "آخرین زیرمقطع گدرانده شده";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            // FkLessonIdString
            // 
            this.FkLessonIdString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FkLessonIdString.DataPropertyName = "FkLessonIdString";
            this.FkLessonIdString.HeaderText = "درس";
            this.FkLessonIdString.Name = "FkLessonIdString";
            this.FkLessonIdString.ReadOnly = true;
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
            // AcademyYearName
            // 
            this.AcademyYearName.DataPropertyName = "AcademyYearString";
            this.AcademyYearName.HeaderText = "سال تحصیلی";
            this.AcademyYearName.Name = "AcademyYearName";
            this.AcademyYearName.ReadOnly = true;
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
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.FillWeight = 30F;
            this.StudentId.HeaderText = "کد دانش آموز";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.FillWeight = 93.27411F;
            this.StudentName.HeaderText = "نام دانش آموز";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentNationCode
            // 
            this.StudentNationCode.DataPropertyName = "StudentNationCode";
            this.StudentNationCode.FillWeight = 93.27411F;
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
            this.FkStudentFieldIdString.FillWeight = 93.27411F;
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
            this.FkLastPassedUgraduteIdString.FillWeight = 93.27411F;
            this.FkLastPassedUgraduteIdString.HeaderText = "آخرین زیرمقطع گدرانده شده";
            this.FkLastPassedUgraduteIdString.Name = "FkLastPassedUgraduteIdString";
            this.FkLastPassedUgraduteIdString.ReadOnly = true;
            // 
            // ScoreOfLesson
            // 
            this.ScoreOfLesson.DataPropertyName = "ScoreOfLesson";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "بدون نمره";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ScoreOfLesson.DefaultCellStyle = dataGridViewCellStyle1;
            this.ScoreOfLesson.HeaderText = "نمره دانش آموز";
            this.ScoreOfLesson.Name = "ScoreOfLesson";
            // 
            // FormScoreOfStudentsForLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 818);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormScoreOfStudentsForLessons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت نمره دانش آموزان";
            this.Load += new System.EventHandler(this.FormScoreOfStudentsForLessons_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllLessons)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApsentStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvNewAcademyYearAllLessons;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtSearchStudents;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnInsertDeleteSync;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvApsentStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkTeacherTeachLessonAccToCalInClassId;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGraduteIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkStudentFieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkStudentFieldIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLastPassedUgraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLastPassedUgraduteIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreOfLesson;
    }
}