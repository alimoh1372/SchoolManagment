namespace SchoolManagment.App
{
    partial class FormTeacherTeachLessonAccordingToCalender
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
            this.btnDeleteSelectedTeacher = new System.Windows.Forms.Button();
            this.btnAddNewCalender = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvNewAcademyYearAllLessons = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCalenders = new System.Windows.Forms.DataGridView();
            this.CalenderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkDayAlterNate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkDayAlterNateString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTimeAlterNateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTimeAlterNateIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSelectedCalenders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderDescription1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkDayAlterNate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkDayAlterNateString1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTimeAlterNateId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTimeAlterNateIdString1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherTeachLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTeacherIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkLessonOfFieldOfNewYearInUnGradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLessonIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkFieldsOfNewYearInUnGradutesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFieldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkUnderGraduteInAcademyYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademyYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademyYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGraduteIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllLessons)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalenders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCalenders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteSelectedTeacher);
            this.groupBox1.Controls.Add(this.btnAddNewCalender);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 644);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب درس از لیست زیر و سپس انتخاب یک تقویم از لیست تقویم های نمایش داده شده";
            // 
            // btnDeleteSelectedTeacher
            // 
            this.btnDeleteSelectedTeacher.Location = new System.Drawing.Point(224, 416);
            this.btnDeleteSelectedTeacher.Name = "btnDeleteSelectedTeacher";
            this.btnDeleteSelectedTeacher.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedTeacher.TabIndex = 11;
            this.btnDeleteSelectedTeacher.Text = "حذف تقویم های آموزشی انتخاب شده برای درس";
            this.btnDeleteSelectedTeacher.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCalender
            // 
            this.btnAddNewCalender.Location = new System.Drawing.Point(398, 416);
            this.btnAddNewCalender.Name = "btnAddNewCalender";
            this.btnAddNewCalender.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewCalender.TabIndex = 10;
            this.btnAddNewCalender.Text = "تخصیص تقویم جهت ارائه درس توسط معلم";
            this.btnAddNewCalender.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSelectedCalenders);
            this.groupBox5.Location = new System.Drawing.Point(3, 475);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(794, 151);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "معلم های انتخاب شده برای درس مورد نظر(درس باید از لیست دروس  جدول انتخاب درس انتخ" +
    "اب شود)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvNewAcademyYearAllLessons);
            this.groupBox2.Location = new System.Drawing.Point(0, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 232);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب درس مورد نظر جهت تخصیص تقویم آموزشی به آن(تعیین روزهای آموزش )";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 70);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جست و جو و فیلتر کردن در لیست نمایش داده شده برای درس ها(جست و جو بر اساس معلم،در" +
    "س،رشته،سال تحصیلی وزیر مقطع میباشد)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 33);
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
            this.TeacherTeachLessonId,
            this.FkTeacherId,
            this.FkTeacherIdString,
            this.PkLessonOfFieldOfNewYearInUnGradeId,
            this.FkLessonId,
            this.FkLessonIdString,
            this.PkFieldsOfNewYearInUnGradutesId,
            this.FkFieldId,
            this.FkFieldIdString,
            this.PkUnderGraduteInAcademyYearId,
            this.AcademyYearId,
            this.AcademyYearName,
            this.FkUnGraduteId,
            this.FkUnGraduteIdString});
            this.dgvNewAcademyYearAllLessons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNewAcademyYearAllLessons.Location = new System.Drawing.Point(3, 93);
            this.dgvNewAcademyYearAllLessons.Name = "dgvNewAcademyYearAllLessons";
            this.dgvNewAcademyYearAllLessons.ReadOnly = true;
            this.dgvNewAcademyYearAllLessons.Size = new System.Drawing.Size(794, 136);
            this.dgvNewAcademyYearAllLessons.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCalenders);
            this.groupBox4.Location = new System.Drawing.Point(3, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 155);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "انتخاب تقویم جهت ارائه درس انتخاب شده در آن زمان ها";
            // 
            // dgvCalenders
            // 
            this.dgvCalenders.AllowUserToAddRows = false;
            this.dgvCalenders.AllowUserToDeleteRows = false;
            this.dgvCalenders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalenders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalenderId,
            this.CalenderName,
            this.CalenderDescription,
            this.FkDayAlterNate,
            this.FkDayAlterNateString,
            this.FkTimeAlterNateId,
            this.FkTimeAlterNateIdString});
            this.dgvCalenders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalenders.Location = new System.Drawing.Point(3, 17);
            this.dgvCalenders.MultiSelect = false;
            this.dgvCalenders.Name = "dgvCalenders";
            this.dgvCalenders.ReadOnly = true;
            this.dgvCalenders.Size = new System.Drawing.Size(788, 135);
            this.dgvCalenders.TabIndex = 4;
            // 
            // CalenderId
            // 
            this.CalenderId.DataPropertyName = "CalenderId";
            this.CalenderId.HeaderText = "کد تقویم";
            this.CalenderId.Name = "CalenderId";
            this.CalenderId.ReadOnly = true;
            this.CalenderId.Visible = false;
            // 
            // CalenderName
            // 
            this.CalenderName.DataPropertyName = "CalenderName";
            this.CalenderName.HeaderText = "نام تقویم";
            this.CalenderName.Name = "CalenderName";
            this.CalenderName.ReadOnly = true;
            // 
            // CalenderDescription
            // 
            this.CalenderDescription.DataPropertyName = "CalenderDescription";
            this.CalenderDescription.HeaderText = "توضیحات";
            this.CalenderDescription.Name = "CalenderDescription";
            this.CalenderDescription.ReadOnly = true;
            // 
            // FkDayAlterNate
            // 
            this.FkDayAlterNate.DataPropertyName = "FkDayAlterNate";
            this.FkDayAlterNate.HeaderText = "کد تناوب روز";
            this.FkDayAlterNate.Name = "FkDayAlterNate";
            this.FkDayAlterNate.ReadOnly = true;
            this.FkDayAlterNate.Visible = false;
            // 
            // FkDayAlterNateString
            // 
            this.FkDayAlterNateString.DataPropertyName = "FkDayAlterNateString";
            this.FkDayAlterNateString.HeaderText = "گردش روز";
            this.FkDayAlterNateString.Name = "FkDayAlterNateString";
            this.FkDayAlterNateString.ReadOnly = true;
            // 
            // FkTimeAlterNateId
            // 
            this.FkTimeAlterNateId.DataPropertyName = "FkTimeAlterNateId";
            this.FkTimeAlterNateId.HeaderText = "کد زمان";
            this.FkTimeAlterNateId.Name = "FkTimeAlterNateId";
            this.FkTimeAlterNateId.ReadOnly = true;
            this.FkTimeAlterNateId.Visible = false;
            // 
            // FkTimeAlterNateIdString
            // 
            this.FkTimeAlterNateIdString.DataPropertyName = "FkTimeAlterNateIdString";
            this.FkTimeAlterNateIdString.HeaderText = "زمان";
            this.FkTimeAlterNateIdString.Name = "FkTimeAlterNateIdString";
            this.FkTimeAlterNateIdString.ReadOnly = true;
            // 
            // dgvSelectedCalenders
            // 
            this.dgvSelectedCalenders.AllowUserToAddRows = false;
            this.dgvSelectedCalenders.AllowUserToDeleteRows = false;
            this.dgvSelectedCalenders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedCalenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedCalenders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CalenderName1,
            this.CalenderDescription1,
            this.FkDayAlterNate1,
            this.FkDayAlterNateString1,
            this.FkTimeAlterNateId1,
            this.FkTimeAlterNateIdString1});
            this.dgvSelectedCalenders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedCalenders.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedCalenders.MultiSelect = false;
            this.dgvSelectedCalenders.Name = "dgvSelectedCalenders";
            this.dgvSelectedCalenders.ReadOnly = true;
            this.dgvSelectedCalenders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedCalenders.Size = new System.Drawing.Size(788, 131);
            this.dgvSelectedCalenders.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CalenderId";
            this.dataGridViewTextBoxColumn1.HeaderText = "کد تقویم";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // CalenderName1
            // 
            this.CalenderName1.DataPropertyName = "CalenderName";
            this.CalenderName1.HeaderText = "نام تقویم";
            this.CalenderName1.Name = "CalenderName1";
            this.CalenderName1.ReadOnly = true;
            // 
            // CalenderDescription1
            // 
            this.CalenderDescription1.DataPropertyName = "CalenderDescription";
            this.CalenderDescription1.HeaderText = "توضیحات";
            this.CalenderDescription1.Name = "CalenderDescription1";
            this.CalenderDescription1.ReadOnly = true;
            // 
            // FkDayAlterNate1
            // 
            this.FkDayAlterNate1.DataPropertyName = "FkDayAlterNate";
            this.FkDayAlterNate1.HeaderText = "کد تناوب روز";
            this.FkDayAlterNate1.Name = "FkDayAlterNate1";
            this.FkDayAlterNate1.ReadOnly = true;
            this.FkDayAlterNate1.Visible = false;
            // 
            // FkDayAlterNateString1
            // 
            this.FkDayAlterNateString1.DataPropertyName = "FkDayAlterNateString";
            this.FkDayAlterNateString1.HeaderText = "گردش روز";
            this.FkDayAlterNateString1.Name = "FkDayAlterNateString1";
            this.FkDayAlterNateString1.ReadOnly = true;
            // 
            // FkTimeAlterNateId1
            // 
            this.FkTimeAlterNateId1.DataPropertyName = "FkTimeAlterNateId";
            this.FkTimeAlterNateId1.HeaderText = "کد زمان";
            this.FkTimeAlterNateId1.Name = "FkTimeAlterNateId1";
            this.FkTimeAlterNateId1.ReadOnly = true;
            this.FkTimeAlterNateId1.Visible = false;
            // 
            // FkTimeAlterNateIdString1
            // 
            this.FkTimeAlterNateIdString1.DataPropertyName = "FkTimeAlterNateIdString";
            this.FkTimeAlterNateIdString1.HeaderText = "زمان";
            this.FkTimeAlterNateIdString1.Name = "FkTimeAlterNateIdString1";
            this.FkTimeAlterNateIdString1.ReadOnly = true;
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
            // FkLessonId
            // 
            this.FkLessonId.DataPropertyName = "FkLessonId";
            this.FkLessonId.HeaderText = "کد درس";
            this.FkLessonId.Name = "FkLessonId";
            this.FkLessonId.ReadOnly = true;
            this.FkLessonId.Visible = false;
            // 
            // FkLessonIdString
            // 
            this.FkLessonIdString.DataPropertyName = "FkLessonIdString";
            this.FkLessonIdString.HeaderText = "درس";
            this.FkLessonIdString.Name = "FkLessonIdString";
            this.FkLessonIdString.ReadOnly = true;
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
            // FormTeacherTeachLessonAccordingToCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTeacherTeachLessonAccordingToCalender";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب تقویم برای درس هایی که معلم برایشان انتخاب شده است";
            this.Load += new System.EventHandler(this.FormTeacherTeachLessonAccordingToCalender_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllLessons)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalenders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedCalenders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteSelectedTeacher;
        private System.Windows.Forms.Button btnAddNewCalender;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvNewAcademyYearAllLessons;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSelectedCalenders;
        private System.Windows.Forms.DataGridView dgvCalenders;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkDayAlterNate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkDayAlterNateString;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTimeAlterNateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTimeAlterNateIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderDescription1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkDayAlterNate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkDayAlterNateString1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTimeAlterNateId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTimeAlterNateIdString1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherTeachLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTeacherIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkLessonOfFieldOfNewYearInUnGradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLessonIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkFieldsOfNewYearInUnGradutesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFieldIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkUnderGraduteInAcademyYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGraduteIdString;
    }
}