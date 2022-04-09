namespace SchoolManagment.App
{
    partial class FormLessonsOfFileldsOfNewYearInUngrade
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
            this.btnDeleteSelectedLesson = new System.Windows.Forms.Button();
            this.btnAddNewLesson = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedLessons = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvLesson = new System.Windows.Forms.DataGridView();
            this.PKLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvNewAcademyYearAllField = new System.Windows.Forms.DataGridView();
            this.FkFieldsOfNewYearInUnGradutesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFieldsOfNewYearInUnGradutesIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademyYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademyYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnderGraduteInAcademyYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnderGraduteInAcademyYearIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedLessons)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllField)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteSelectedLesson);
            this.groupBox1.Controls.Add(this.btnAddNewLesson);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 626);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب یک رشته از لیست زیر و سپس انتخاب یک درس از لیست دروس نمایش داده شده ";
            // 
            // btnDeleteSelectedLesson
            // 
            this.btnDeleteSelectedLesson.Location = new System.Drawing.Point(224, 416);
            this.btnDeleteSelectedLesson.Name = "btnDeleteSelectedLesson";
            this.btnDeleteSelectedLesson.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedLesson.TabIndex = 11;
            this.btnDeleteSelectedLesson.Text = "حذف درس از لیست دروس انتخاب شده جهت ارائه";
            this.btnDeleteSelectedLesson.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedLesson.Click += new System.EventHandler(this.btnDeleteSelectedLesson_Click);
            // 
            // btnAddNewLesson
            // 
            this.btnAddNewLesson.Location = new System.Drawing.Point(398, 416);
            this.btnAddNewLesson.Name = "btnAddNewLesson";
            this.btnAddNewLesson.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewLesson.TabIndex = 10;
            this.btnAddNewLesson.Text = "افزودن درس به لیست دروس قابل ارائه در این رشته";
            this.btnAddNewLesson.UseVisualStyleBackColor = true;
            this.btnAddNewLesson.Click += new System.EventHandler(this.btnAddNewLesson_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSelectedLessons);
            this.groupBox5.Location = new System.Drawing.Point(3, 475);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(794, 151);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "درس های انتخاب شده برای رشته مورد نظر(رشته از لیست رشته ها باید انتخاب شود برای ن" +
    "مایش لیست دروس آن)";
            // 
            // dgvSelectedLessons
            // 
            this.dgvSelectedLessons.AllowUserToAddRows = false;
            this.dgvSelectedLessons.AllowUserToDeleteRows = false;
            this.dgvSelectedLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvSelectedLessons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedLessons.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedLessons.Name = "dgvSelectedLessons";
            this.dgvSelectedLessons.ReadOnly = true;
            this.dgvSelectedLessons.Size = new System.Drawing.Size(788, 131);
            this.dgvSelectedLessons.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PKLessonId";
            this.dataGridViewTextBoxColumn1.HeaderText = "کد درس";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LessonName";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام درس";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LessonUnits";
            this.dataGridViewTextBoxColumn3.HeaderText = "تعداد واحد درس";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FkFileldId";
            this.dataGridViewTextBoxColumn4.HeaderText = "کد رشته ی درس";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FkFileldIdString";
            this.dataGridViewTextBoxColumn5.HeaderText = "رشته ی درس";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvLesson);
            this.groupBox4.Location = new System.Drawing.Point(3, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 155);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "انتخاب درس های قابل ارائه در رشته مورد نظر(تمام درس های قابل ارائه)-برای نمایش لی" +
    "ست دروس باید از لیست بالا رشته انتخاب شود";
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
            this.FkFileldIdString});
            this.dgvLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLesson.Location = new System.Drawing.Point(3, 17);
            this.dgvLesson.Name = "dgvLesson";
            this.dgvLesson.ReadOnly = true;
            this.dgvLesson.Size = new System.Drawing.Size(788, 135);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgvNewAcademyYearAllField);
            this.groupBox2.Location = new System.Drawing.Point(0, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 232);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب رشته مورد نظر جهت افزودن درس";
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
            this.groupBox3.Text = "جست و جو و فیلتر کردن در لیست نمایش داده شده(براساس نام سال تحصیلی ،نام زیرمقطع و" +
    " نام رشته ...)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(524, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvNewAcademyYearAllField
            // 
            this.dgvNewAcademyYearAllField.AllowUserToAddRows = false;
            this.dgvNewAcademyYearAllField.AllowUserToDeleteRows = false;
            this.dgvNewAcademyYearAllField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewAcademyYearAllField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewAcademyYearAllField.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FkFieldsOfNewYearInUnGradutesId,
            this.FkFieldsOfNewYearInUnGradutesIdString,
            this.AcademyYearId,
            this.AcademyYearName,
            this.FkUnderGraduteInAcademyYearId,
            this.FkUnderGraduteInAcademyYearIdString});
            this.dgvNewAcademyYearAllField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNewAcademyYearAllField.Location = new System.Drawing.Point(3, 93);
            this.dgvNewAcademyYearAllField.Name = "dgvNewAcademyYearAllField";
            this.dgvNewAcademyYearAllField.ReadOnly = true;
            this.dgvNewAcademyYearAllField.Size = new System.Drawing.Size(794, 136);
            this.dgvNewAcademyYearAllField.TabIndex = 0;
            this.dgvNewAcademyYearAllField.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewAcademyYearAllField_CellClick);
            // 
            // FkFieldsOfNewYearInUnGradutesId
            // 
            this.FkFieldsOfNewYearInUnGradutesId.DataPropertyName = "FkFieldsOfNewYearInUnGradutesId";
            this.FkFieldsOfNewYearInUnGradutesId.HeaderText = "کد رشته";
            this.FkFieldsOfNewYearInUnGradutesId.Name = "FkFieldsOfNewYearInUnGradutesId";
            this.FkFieldsOfNewYearInUnGradutesId.ReadOnly = true;
            this.FkFieldsOfNewYearInUnGradutesId.Visible = false;
            // 
            // FkFieldsOfNewYearInUnGradutesIdString
            // 
            this.FkFieldsOfNewYearInUnGradutesIdString.DataPropertyName = "FkFieldsOfNewYearInUnGradutesIdString";
            this.FkFieldsOfNewYearInUnGradutesIdString.HeaderText = "رشته";
            this.FkFieldsOfNewYearInUnGradutesIdString.Name = "FkFieldsOfNewYearInUnGradutesIdString";
            this.FkFieldsOfNewYearInUnGradutesIdString.ReadOnly = true;
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
            // FkUnderGraduteInAcademyYearId
            // 
            this.FkUnderGraduteInAcademyYearId.DataPropertyName = "FkUnderGraduteInAcademyYearId";
            this.FkUnderGraduteInAcademyYearId.HeaderText = "کد زیرمقطع";
            this.FkUnderGraduteInAcademyYearId.Name = "FkUnderGraduteInAcademyYearId";
            this.FkUnderGraduteInAcademyYearId.ReadOnly = true;
            this.FkUnderGraduteInAcademyYearId.Visible = false;
            // 
            // FkUnderGraduteInAcademyYearIdString
            // 
            this.FkUnderGraduteInAcademyYearIdString.DataPropertyName = "FkUnderGraduteInAcademyYearIdString";
            this.FkUnderGraduteInAcademyYearIdString.HeaderText = "زیرمقطع";
            this.FkUnderGraduteInAcademyYearIdString.Name = "FkUnderGraduteInAcademyYearIdString";
            this.FkUnderGraduteInAcademyYearIdString.ReadOnly = true;
            // 
            // FormLessonsOfFileldsOfNewYearInUngrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLessonsOfFileldsOfNewYearInUngrade";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب دروس قابل ارائه برای رشته های افزوده شده به سال تحصیلی جدید";
            this.Load += new System.EventHandler(this.FormLessonsOfFileldsOfNewYearInUngrade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedLessons)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewAcademyYearAllField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvNewAcademyYearAllField;
        private System.Windows.Forms.DataGridView dgvSelectedLessons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dgvLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldIdString;
        private System.Windows.Forms.Button btnDeleteSelectedLesson;
        private System.Windows.Forms.Button btnAddNewLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFieldsOfNewYearInUnGradutesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFieldsOfNewYearInUnGradutesIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnderGraduteInAcademyYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnderGraduteInAcademyYearIdString;
    }
}