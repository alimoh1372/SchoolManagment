namespace SchoolManagment.App
{
    partial class FormTeacherTeachsLessonsOfNewYearInUnGrades
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
            this.btnAddNewTeachre = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedTeacher = new System.Windows.Forms.DataGridView();
            this.TeacherId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherEducation1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvNewAcademyYearAllLessons = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTeacher)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteSelectedTeacher);
            this.groupBox1.Controls.Add(this.btnAddNewTeachre);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 636);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب درس از لیست زیر و سپس انتخاب یک معلم از لیست معلمین نمایش داده شده";
            // 
            // btnDeleteSelectedTeacher
            // 
            this.btnDeleteSelectedTeacher.Location = new System.Drawing.Point(224, 416);
            this.btnDeleteSelectedTeacher.Name = "btnDeleteSelectedTeacher";
            this.btnDeleteSelectedTeacher.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedTeacher.TabIndex = 11;
            this.btnDeleteSelectedTeacher.Text = "حذف معلم از لیست معلمانی که این درس را تدریس میکنند";
            this.btnDeleteSelectedTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedTeacher.Click += new System.EventHandler(this.btnDeleteSelectedTeacher_Click);
            // 
            // btnAddNewTeachre
            // 
            this.btnAddNewTeachre.Location = new System.Drawing.Point(398, 416);
            this.btnAddNewTeachre.Name = "btnAddNewTeachre";
            this.btnAddNewTeachre.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewTeachre.TabIndex = 10;
            this.btnAddNewTeachre.Text = "تخصیص معلم (معلم ها)برای تدریس درس";
            this.btnAddNewTeachre.UseVisualStyleBackColor = true;
            this.btnAddNewTeachre.Click += new System.EventHandler(this.btnAddNewTeachre_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSelectedTeacher);
            this.groupBox5.Location = new System.Drawing.Point(3, 475);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(794, 151);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "معلم های انتخاب شده برای درس مورد نظر(درس باید از لیست دروس  جدول انتخاب درس انتخ" +
    "اب شود)";
            // 
            // dgvSelectedTeacher
            // 
            this.dgvSelectedTeacher.AllowUserToAddRows = false;
            this.dgvSelectedTeacher.AllowUserToDeleteRows = false;
            this.dgvSelectedTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherId1,
            this.TeacherName1,
            this.TeacherEducation1});
            this.dgvSelectedTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedTeacher.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedTeacher.Name = "dgvSelectedTeacher";
            this.dgvSelectedTeacher.ReadOnly = true;
            this.dgvSelectedTeacher.Size = new System.Drawing.Size(788, 131);
            this.dgvSelectedTeacher.TabIndex = 2;
            // 
            // TeacherId1
            // 
            this.TeacherId1.DataPropertyName = "TeacherId";
            this.TeacherId1.HeaderText = "کد معلم";
            this.TeacherId1.Name = "TeacherId1";
            this.TeacherId1.ReadOnly = true;
            this.TeacherId1.Visible = false;
            // 
            // TeacherName1
            // 
            this.TeacherName1.DataPropertyName = "TeacherName";
            this.TeacherName1.HeaderText = "نام معلم";
            this.TeacherName1.Name = "TeacherName1";
            this.TeacherName1.ReadOnly = true;
            // 
            // TeacherEducation1
            // 
            this.TeacherEducation1.DataPropertyName = "TeacherEducation";
            this.TeacherEducation1.HeaderText = "تحصیلات معلم";
            this.TeacherEducation1.Name = "TeacherEducation1";
            this.TeacherEducation1.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvTeacher);
            this.groupBox4.Location = new System.Drawing.Point(3, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 155);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "انتخاب معلم (تمام معلمانی که میتوانند این درس را تدریس کنند در لیست زیر نمایش داد" +
    "ه شده است)-برای نمایش لیست معلمان باید یک درس از لیست بالا انتخاب شود.";
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherId,
            this.TeacherName,
            this.TeacherEducation});
            this.dgvTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeacher.Location = new System.Drawing.Point(3, 17);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.Size = new System.Drawing.Size(788, 135);
            this.dgvTeacher.TabIndex = 1;
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "TeacherId";
            this.TeacherId.HeaderText = "کد معلم";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "نام معلم";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // TeacherEducation
            // 
            this.TeacherEducation.DataPropertyName = "TeacherEducation";
            this.TeacherEducation.HeaderText = "تحصیلات معلم";
            this.TeacherEducation.Name = "TeacherEducation";
            this.TeacherEducation.ReadOnly = true;
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
            this.groupBox2.Text = "انتخاب درس مورد نظر جهت تخصیص معلم به آن";
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
            this.groupBox3.Text = "جست و جو و فیلتر کردن در لیست نمایش داده شده (بر اساس نام درس،رشته،سال تحصیلی،زیر" +
    " مقطع ...)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(524, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvNewAcademyYearAllLessons
            // 
            this.dgvNewAcademyYearAllLessons.AllowUserToAddRows = false;
            this.dgvNewAcademyYearAllLessons.AllowUserToDeleteRows = false;
            this.dgvNewAcademyYearAllLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewAcademyYearAllLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewAcademyYearAllLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvNewAcademyYearAllLessons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewAcademyYearAllLessons_CellClick);
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
            // FormTeacherTeachsLessonsOfNewYearInUnGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTeacherTeachsLessonsOfNewYearInUnGrades";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "معلم برای رشته های قابل ارائه در سال جدید";
            this.Load += new System.EventHandler(this.FormTeacherTeachsLessonsOfNewYearInUnGrades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTeacher)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllLessons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteSelectedTeacher;
        private System.Windows.Forms.Button btnAddNewTeachre;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvNewAcademyYearAllLessons;
        private System.Windows.Forms.DataGridView dgvSelectedTeacher;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherEducation1;
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