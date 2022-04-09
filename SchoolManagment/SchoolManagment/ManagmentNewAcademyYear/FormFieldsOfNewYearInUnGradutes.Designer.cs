namespace SchoolManagment.App
{
    partial class FormFieldsOfNewYearInUnGradutes
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.PkFieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKUnGraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKUnGraduteIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSelectedField = new System.Windows.Forms.Button();
            this.btnAddNewFieldToUngradeInNewYear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedFields = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGradutePrequestisString1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkGradeIdString1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnGraduteName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkUnGraduteId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSelectedUnGradeInNewYear = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademyYears)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedUnGradeInNewYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAcademyYears);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب سال تحصیلی مورد نظر جهت افزودن رشته به زیرمقطع های آن...";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSelectedUnGradeInNewYear);
            this.groupBox3.Location = new System.Drawing.Point(2, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 146);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "انتخاب زیر مقطع جهت اضافه نمودن رشته  به آن...(جهت نمایش زیرمقطع های سال تحصیلی ل" +
    "طفا یک سال تحصیلی از لیست بالا انتخاب نمائید.)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvFields);
            this.groupBox2.Location = new System.Drawing.Point(5, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تمام رشته های مربوط به این زیر مقطع";
            // 
            // dgvFields
            // 
            this.dgvFields.AllowUserToAddRows = false;
            this.dgvFields.AllowUserToDeleteRows = false;
            this.dgvFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkFieldId,
            this.FKUnGraduteId,
            this.FieldName,
            this.FKUnGraduteIdString});
            this.dgvFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFields.Location = new System.Drawing.Point(3, 17);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.ReadOnly = true;
            this.dgvFields.Size = new System.Drawing.Size(788, 119);
            this.dgvFields.TabIndex = 1;
            // 
            // PkFieldId
            // 
            this.PkFieldId.DataPropertyName = "PkFieldId";
            this.PkFieldId.HeaderText = "کد رشته";
            this.PkFieldId.Name = "PkFieldId";
            this.PkFieldId.ReadOnly = true;
            this.PkFieldId.Visible = false;
            // 
            // FKUnGraduteId
            // 
            this.FKUnGraduteId.DataPropertyName = "FKUnGraduteId";
            this.FKUnGraduteId.HeaderText = "کد زیرمقطع";
            this.FKUnGraduteId.Name = "FKUnGraduteId";
            this.FKUnGraduteId.ReadOnly = true;
            this.FKUnGraduteId.Visible = false;
            // 
            // FieldName
            // 
            this.FieldName.DataPropertyName = "FieldName";
            this.FieldName.HeaderText = "نام رشته";
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            // 
            // FKUnGraduteIdString
            // 
            this.FKUnGraduteIdString.DataPropertyName = "FKUnGraduteIdString";
            this.FKUnGraduteIdString.HeaderText = "زیر مقطع مربوط به این رشته";
            this.FKUnGraduteIdString.Name = "FKUnGraduteIdString";
            this.FKUnGraduteIdString.ReadOnly = true;
            // 
            // btnDeleteSelectedField
            // 
            this.btnDeleteSelectedField.Location = new System.Drawing.Point(222, 449);
            this.btnDeleteSelectedField.Name = "btnDeleteSelectedField";
            this.btnDeleteSelectedField.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedField.TabIndex = 11;
            this.btnDeleteSelectedField.Text = "حذف رشته از زیرمقطع سال جدید";
            this.btnDeleteSelectedField.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedField.Click += new System.EventHandler(this.btnDeleteSelectedField_Click);
            // 
            // btnAddNewFieldToUngradeInNewYear
            // 
            this.btnAddNewFieldToUngradeInNewYear.Location = new System.Drawing.Point(396, 449);
            this.btnAddNewFieldToUngradeInNewYear.Name = "btnAddNewFieldToUngradeInNewYear";
            this.btnAddNewFieldToUngradeInNewYear.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewFieldToUngradeInNewYear.TabIndex = 10;
            this.btnAddNewFieldToUngradeInNewYear.Text = "افزودن ر شته قابل ارائه به زیرمقطع در سال جدید";
            this.btnAddNewFieldToUngradeInNewYear.UseVisualStyleBackColor = true;
            this.btnAddNewFieldToUngradeInNewYear.Click += new System.EventHandler(this.btnAddNewFieldToUngradeInNewYear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSelectedFields);
            this.groupBox4.Location = new System.Drawing.Point(2, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(797, 139);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "رشته های افزوده شده به زیر مقطع در سال تحصیلی جدید";
            // 
            // dgvSelectedFields
            // 
            this.dgvSelectedFields.AllowUserToAddRows = false;
            this.dgvSelectedFields.AllowUserToDeleteRows = false;
            this.dgvSelectedFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvSelectedFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedFields.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedFields.Name = "dgvSelectedFields";
            this.dgvSelectedFields.ReadOnly = true;
            this.dgvSelectedFields.Size = new System.Drawing.Size(791, 119);
            this.dgvSelectedFields.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PkFieldId";
            this.dataGridViewTextBoxColumn1.HeaderText = "کد رشته";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FKUnGraduteId";
            this.dataGridViewTextBoxColumn2.HeaderText = "کد زیرمقطع";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FieldName";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام رشته";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FKUnGraduteIdString";
            this.dataGridViewTextBoxColumn4.HeaderText = "زیر مقطع مربوط به این رشته";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FkUnGradutePrequestisString1
            // 
            this.FkUnGradutePrequestisString1.DataPropertyName = "FkUnGradutePrequestisString";
            this.FkUnGradutePrequestisString1.HeaderText = " پیشنیاز";
            this.FkUnGradutePrequestisString1.Name = "FkUnGradutePrequestisString1";
            this.FkUnGradutePrequestisString1.ReadOnly = true;
            // 
            // FkGradeIdString1
            // 
            this.FkGradeIdString1.DataPropertyName = "FkGradeIdString";
            this.FkGradeIdString1.HeaderText = "مقطع تحصیلی این زیر مقطع";
            this.FkGradeIdString1.Name = "FkGradeIdString1";
            this.FkGradeIdString1.ReadOnly = true;
            // 
            // UnGraduteName1
            // 
            this.UnGraduteName1.DataPropertyName = "UnGraduteName";
            this.UnGraduteName1.HeaderText = "نام زیرمقطع";
            this.UnGraduteName1.Name = "UnGraduteName1";
            this.UnGraduteName1.ReadOnly = true;
            // 
            // PkUnGraduteId1
            // 
            this.PkUnGraduteId1.DataPropertyName = "PkUnGraduteId";
            this.PkUnGraduteId1.HeaderText = "کد مقطع";
            this.PkUnGraduteId1.Name = "PkUnGraduteId1";
            this.PkUnGraduteId1.ReadOnly = true;
            this.PkUnGraduteId1.Visible = false;
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
            this.dgvSelectedUnGradeInNewYear.Size = new System.Drawing.Size(794, 126);
            this.dgvSelectedUnGradeInNewYear.TabIndex = 0;
            this.dgvSelectedUnGradeInNewYear.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedUnGradeInNewYear_CellClick);
            // 
            // FormFieldsOfNewYearInUnGradutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 647);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnDeleteSelectedField);
            this.Controls.Add(this.btnAddNewFieldToUngradeInNewYear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFieldsOfNewYearInUnGradutes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت رشته های مربوط به یک زیر مقطع در سال تحصیلی جدید";
            this.Load += new System.EventHandler(this.FormFieldsOfNewYearInUnGradutes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademyYears)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFields)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkFieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKUnGraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKUnGraduteIdString;
        private System.Windows.Forms.Button btnDeleteSelectedField;
        private System.Windows.Forms.Button btnAddNewFieldToUngradeInNewYear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSelectedFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvSelectedUnGradeInNewYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkUnGraduteId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnGraduteName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkGradeIdString1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGradutePrequestisString1;
    }
}