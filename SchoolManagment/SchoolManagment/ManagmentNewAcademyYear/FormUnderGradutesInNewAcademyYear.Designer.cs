namespace SchoolManagment.App
{
    partial class FormUnderGradutesInNewAcademyYearRepository
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
            this.dgvAcademyYears = new System.Windows.Forms.DataGridView();
            this.AcademyYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademyYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDaysOfYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUnderGradutes = new System.Windows.Forms.DataGridView();
            this.PkUnGraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnGraduteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkGradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGradutePrequestis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedUnGradeInNewYear = new System.Windows.Forms.DataGridView();
            this.PkUnGraduteId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnGraduteName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkGradeIdString1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGradutePrequestisString1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddUnGradeToNewYear = new System.Windows.Forms.Button();
            this.btnDeleteSelectedUnFromAcademyYear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademyYears)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderGradutes)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedUnGradeInNewYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAcademyYears);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب سال تحصیلی جدید که میخواهید زیر مقطع ها را به آن اضافه کنید";
            // 
            // dgvAcademyYears
            // 
            this.dgvAcademyYears.AllowUserToAddRows = false;
            this.dgvAcademyYears.AllowUserToDeleteRows = false;
            this.dgvAcademyYears.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcademyYears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademyYears.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AcademyYearId,
            this.AcademyYearName,
            this.StartDate,
            this.EndDate,
            this.NumberOfDaysOfYear});
            this.dgvAcademyYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAcademyYears.Location = new System.Drawing.Point(3, 17);
            this.dgvAcademyYears.Name = "dgvAcademyYears";
            this.dgvAcademyYears.ReadOnly = true;
            this.dgvAcademyYears.Size = new System.Drawing.Size(794, 130);
            this.dgvAcademyYears.TabIndex = 0;
            this.dgvAcademyYears.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcademyYears_CellClick);
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
            this.AcademyYearName.DataPropertyName = "AcademyYearName";
            this.AcademyYearName.HeaderText = "نام سال تحصیلی";
            this.AcademyYearName.Name = "AcademyYearName";
            this.AcademyYearName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "تاریخ شروع سال تحصیلی";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "تاریخ پایان سال تحصیلی";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // NumberOfDaysOfYear
            // 
            this.NumberOfDaysOfYear.DataPropertyName = "NumberOfDaysOfYear";
            this.NumberOfDaysOfYear.HeaderText = "تعداد روزهای این سال تحصیلی";
            this.NumberOfDaysOfYear.Name = "NumberOfDaysOfYear";
            this.NumberOfDaysOfYear.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUnderGradutes);
            this.groupBox2.Location = new System.Drawing.Point(2, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 146);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب زیرمقطعی که میخواهید به سال جدید اضافه شود";
            // 
            // dgvUnderGradutes
            // 
            this.dgvUnderGradutes.AllowUserToAddRows = false;
            this.dgvUnderGradutes.AllowUserToDeleteRows = false;
            this.dgvUnderGradutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderGradutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderGradutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkUnGraduteId,
            this.UnGraduteName,
            this.FkGradeId,
            this.FkUnGradutePrequestis});
            this.dgvUnderGradutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnderGradutes.Location = new System.Drawing.Point(3, 17);
            this.dgvUnderGradutes.Name = "dgvUnderGradutes";
            this.dgvUnderGradutes.ReadOnly = true;
            this.dgvUnderGradutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvUnderGradutes.Size = new System.Drawing.Size(788, 126);
            this.dgvUnderGradutes.TabIndex = 0;
            // 
            // PkUnGraduteId
            // 
            this.PkUnGraduteId.DataPropertyName = "PkUnGraduteId";
            this.PkUnGraduteId.HeaderText = "کد مقطع";
            this.PkUnGraduteId.Name = "PkUnGraduteId";
            this.PkUnGraduteId.ReadOnly = true;
            this.PkUnGraduteId.Visible = false;
            // 
            // UnGraduteName
            // 
            this.UnGraduteName.DataPropertyName = "UnGraduteName";
            this.UnGraduteName.HeaderText = "نام زیرمقطع";
            this.UnGraduteName.Name = "UnGraduteName";
            this.UnGraduteName.ReadOnly = true;
            // 
            // FkGradeId
            // 
            this.FkGradeId.DataPropertyName = "FkGradeIdString";
            this.FkGradeId.HeaderText = "مقطع تحصیلی این زیر مقطع";
            this.FkGradeId.Name = "FkGradeId";
            this.FkGradeId.ReadOnly = true;
            // 
            // FkUnGradutePrequestis
            // 
            this.FkUnGradutePrequestis.DataPropertyName = "FkUnGradutePrequestisString";
            this.FkUnGradutePrequestis.HeaderText = " پیشنیاز";
            this.FkUnGradutePrequestis.Name = "FkUnGradutePrequestis";
            this.FkUnGradutePrequestis.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSelectedUnGradeInNewYear);
            this.groupBox3.Location = new System.Drawing.Point(5, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 146);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "زیرمقطع های اضافه شده به سال تحصیلی جدید";
            // 
            // dgvSelectedUnGradeInNewYear
            // 
            this.dgvSelectedUnGradeInNewYear.AllowUserToAddRows = false;
            this.dgvSelectedUnGradeInNewYear.AllowUserToDeleteRows = false;
            this.dgvSelectedUnGradeInNewYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedUnGradeInNewYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedUnGradeInNewYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkUnGraduteId1,
            this.UnGraduteName1,
            this.FkGradeIdString1,
            this.FkUnGradutePrequestisString1});
            this.dgvSelectedUnGradeInNewYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedUnGradeInNewYear.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedUnGradeInNewYear.Name = "dgvSelectedUnGradeInNewYear";
            this.dgvSelectedUnGradeInNewYear.ReadOnly = true;
            this.dgvSelectedUnGradeInNewYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSelectedUnGradeInNewYear.Size = new System.Drawing.Size(788, 126);
            this.dgvSelectedUnGradeInNewYear.TabIndex = 0;
            // 
            // PkUnGraduteId1
            // 
            this.PkUnGraduteId1.DataPropertyName = "PkUnGraduteId";
            this.PkUnGraduteId1.HeaderText = "کد مقطع";
            this.PkUnGraduteId1.Name = "PkUnGraduteId1";
            this.PkUnGraduteId1.ReadOnly = true;
            this.PkUnGraduteId1.Visible = false;
            // 
            // UnGraduteName1
            // 
            this.UnGraduteName1.DataPropertyName = "UnGraduteName";
            this.UnGraduteName1.HeaderText = "نام زیرمقطع";
            this.UnGraduteName1.Name = "UnGraduteName1";
            this.UnGraduteName1.ReadOnly = true;
            // 
            // FkGradeIdString1
            // 
            this.FkGradeIdString1.DataPropertyName = "FkGradeIdString";
            this.FkGradeIdString1.HeaderText = "مقطع تحصیلی این زیر مقطع";
            this.FkGradeIdString1.Name = "FkGradeIdString1";
            this.FkGradeIdString1.ReadOnly = true;
            // 
            // FkUnGradutePrequestisString1
            // 
            this.FkUnGradutePrequestisString1.DataPropertyName = "FkUnGradutePrequestisString";
            this.FkUnGradutePrequestisString1.HeaderText = " پیشنیاز";
            this.FkUnGradutePrequestisString1.Name = "FkUnGradutePrequestisString1";
            this.FkUnGradutePrequestisString1.ReadOnly = true;
            // 
            // btnAddUnGradeToNewYear
            // 
            this.btnAddUnGradeToNewYear.Location = new System.Drawing.Point(584, 322);
            this.btnAddUnGradeToNewYear.Name = "btnAddUnGradeToNewYear";
            this.btnAddUnGradeToNewYear.Size = new System.Drawing.Size(178, 58);
            this.btnAddUnGradeToNewYear.TabIndex = 8;
            this.btnAddUnGradeToNewYear.Text = "افزودن";
            this.btnAddUnGradeToNewYear.UseVisualStyleBackColor = true;
            this.btnAddUnGradeToNewYear.Click += new System.EventHandler(this.btnAddUnGradeToNewYear_Click);
            // 
            // btnDeleteSelectedUnFromAcademyYear
            // 
            this.btnDeleteSelectedUnFromAcademyYear.Location = new System.Drawing.Point(62, 322);
            this.btnDeleteSelectedUnFromAcademyYear.Name = "btnDeleteSelectedUnFromAcademyYear";
            this.btnDeleteSelectedUnFromAcademyYear.Size = new System.Drawing.Size(178, 58);
            this.btnDeleteSelectedUnFromAcademyYear.TabIndex = 9;
            this.btnDeleteSelectedUnFromAcademyYear.Text = "حذف";
            this.btnDeleteSelectedUnFromAcademyYear.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedUnFromAcademyYear.Click += new System.EventHandler(this.btnDeleteSelectedUnFromAcademyYear_Click);
            // 
            // FormUnderGradutesInNewAcademyYearRepository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.btnDeleteSelectedUnFromAcademyYear);
            this.Controls.Add(this.btnAddUnGradeToNewYear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUnderGradutesInNewAcademyYearRepository";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "زیر مقطع های سال تحصیلی جدید";
            this.Load += new System.EventHandler(this.FormUnderGradutesInNewAcademyYearRepository_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademyYears)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderGradutes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedUnGradeInNewYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAcademyYears;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDaysOfYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUnderGradutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkUnGraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnGraduteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkGradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGradutePrequestis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSelectedUnGradeInNewYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkUnGraduteId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnGraduteName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkGradeIdString1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGradutePrequestisString1;
        private System.Windows.Forms.Button btnAddUnGradeToNewYear;
        private System.Windows.Forms.Button btnDeleteSelectedUnFromAcademyYear;
    }
}