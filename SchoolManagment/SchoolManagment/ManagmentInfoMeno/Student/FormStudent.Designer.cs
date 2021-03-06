namespace SchoolManagment.App
{
    partial class FormStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSelectedLesson = new System.Windows.Forms.Button();
            this.btnDeleteSelectedLesson = new System.Windows.Forms.Button();
            this.btnAddNewLesson = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFkLastPassedUgraduteId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentNationCode = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFkFileldId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkStudentFieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkStudentFieldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLastPassedUgraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkLastPassedUgraduteIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnUpdateSelectedLesson);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedLesson);
            this.groupBox2.Controls.Add(this.btnAddNewLesson);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(522, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 450);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات اطلاعات دانش آموز";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 369);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 53);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "به روز رسانی صفحه و اطلاعات";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdateSelectedLesson
            // 
            this.btnUpdateSelectedLesson.Location = new System.Drawing.Point(180, 369);
            this.btnUpdateSelectedLesson.Name = "btnUpdateSelectedLesson";
            this.btnUpdateSelectedLesson.Size = new System.Drawing.Size(171, 53);
            this.btnUpdateSelectedLesson.TabIndex = 3;
            this.btnUpdateSelectedLesson.Text = "ثبت ویرایش انجام شده روی اطلاعات دانش آموز";
            this.btnUpdateSelectedLesson.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedLesson.Click += new System.EventHandler(this.btnUpdateSelectedLesson_Click);
            // 
            // btnDeleteSelectedLesson
            // 
            this.btnDeleteSelectedLesson.Location = new System.Drawing.Point(6, 310);
            this.btnDeleteSelectedLesson.Name = "btnDeleteSelectedLesson";
            this.btnDeleteSelectedLesson.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedLesson.TabIndex = 2;
            this.btnDeleteSelectedLesson.Text = "حذف دانش آموز انتخاب شده";
            this.btnDeleteSelectedLesson.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedLesson.Click += new System.EventHandler(this.btnDeleteSelectedLesson_Click);
            // 
            // btnAddNewLesson
            // 
            this.btnAddNewLesson.Location = new System.Drawing.Point(180, 310);
            this.btnAddNewLesson.Name = "btnAddNewLesson";
            this.btnAddNewLesson.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewLesson.TabIndex = 1;
            this.btnAddNewLesson.Text = "افزودن دانش آموز جدید";
            this.btnAddNewLesson.UseVisualStyleBackColor = true;
            this.btnAddNewLesson.Click += new System.EventHandler(this.btnAddNewLesson_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFkLastPassedUgraduteId);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtStudentNationCode);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtFkFileldId);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtStudentName);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 284);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtFkLastPassedUgraduteId
            // 
            this.txtFkLastPassedUgraduteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFkLastPassedUgraduteId.FormattingEnabled = true;
            this.txtFkLastPassedUgraduteId.Location = new System.Drawing.Point(48, 238);
            this.txtFkLastPassedUgraduteId.Name = "txtFkLastPassedUgraduteId";
            this.txtFkLastPassedUgraduteId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFkLastPassedUgraduteId.Size = new System.Drawing.Size(271, 21);
            this.txtFkLastPassedUgraduteId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "آخرین مقطع تحصیلی که پاس شده است :";
            // 
            // txtStudentNationCode
            // 
            this.txtStudentNationCode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtStudentNationCode.Location = new System.Drawing.Point(48, 105);
            this.txtStudentNationCode.Mask = "000-00000-00";
            this.txtStudentNationCode.Name = "txtStudentNationCode";
            this.txtStudentNationCode.Size = new System.Drawing.Size(271, 21);
            this.txtStudentNationCode.TabIndex = 1;
            this.txtStudentNationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "شماره ملی :";
            // 
            // txtFkFileldId
            // 
            this.txtFkFileldId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFkFileldId.FormattingEnabled = true;
            this.txtFkFileldId.Location = new System.Drawing.Point(47, 172);
            this.txtFkFileldId.Name = "txtFkFileldId";
            this.txtFkFileldId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFkFileldId.Size = new System.Drawing.Size(271, 21);
            this.txtFkFileldId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "رشته ی دانش آموز :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام دانش آموز:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(48, 41);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(271, 21);
            this.txtStudentName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStudent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 450);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست دانش آموزان ثبت شده :";
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
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(3, 17);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(510, 430);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);

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
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtStudentName;
            this.requiredFieldValidator1.ErrorMessage = "این مورد الزامی میباشد.لطفا نام دانش آموز را وارد نمائید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtStudentNationCode;
            this.requiredFieldValidator2.ErrorMessage = "این مورد الزامی میباشد.لطفا کد ملی دانش آموز را وارد نمائید.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtFkFileldId;
            this.requiredFieldValidator3.ErrorMessage = "این مورد الزامی میباشد.لطفا از لیست بازشونده یک مقدار انتخاب شود.";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txtFkLastPassedUgraduteId;
            this.requiredFieldValidator4.ErrorMessage = "این مورد الزامی میباشد.لطفا یک مورد از لیست بازشونده انتخاب گردد.";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت اطلاعات دانش آموزان";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateSelectedLesson;
        private System.Windows.Forms.Button btnDeleteSelectedLesson;
        private System.Windows.Forms.Button btnAddNewLesson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtFkFileldId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.MaskedTextBox txtStudentNationCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtFkLastPassedUgraduteId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkStudentFieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkStudentFieldIdString;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLastPassedUgraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkLastPassedUgraduteIdString;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
    }
}