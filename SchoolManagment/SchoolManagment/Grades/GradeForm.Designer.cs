namespace SchoolManagment.App
{
    partial class GradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.PkGradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkGradePrequiestisString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSelectedGrade = new System.Windows.Forms.Button();
            this.btnDeleteSelectedGrade = new System.Windows.Forms.Button();
            this.btnAddNewGrade = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrereustisGrade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGradeName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGrades);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست مقاطع ثبت شده";
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkGradeId,
            this.GradeName,
            this.FkGradePrequiestisString});
            this.dgvGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrades.Location = new System.Drawing.Point(3, 17);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.Size = new System.Drawing.Size(407, 406);
            this.dgvGrades.TabIndex = 0;
            this.dgvGrades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellClick);
            // 
            // PkGradeId
            // 
            this.PkGradeId.DataPropertyName = "PkGradeId";
            this.PkGradeId.HeaderText = "کد مقطع";
            this.PkGradeId.Name = "PkGradeId";
            this.PkGradeId.ReadOnly = true;
            this.PkGradeId.Visible = false;
            // 
            // GradeName
            // 
            this.GradeName.DataPropertyName = "GradeName";
            this.GradeName.HeaderText = "نام مقطع تحصیلی";
            this.GradeName.Name = "GradeName";
            this.GradeName.ReadOnly = true;
            // 
            // FkGradePrequiestisString
            // 
            this.FkGradePrequiestisString.DataPropertyName = "FkGradePrequiestisString";
            this.FkGradePrequiestisString.HeaderText = "پیش نیاز مقطع";
            this.FkGradePrequiestisString.Name = "FkGradePrequiestisString";
            this.FkGradePrequiestisString.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnUpdateSelectedGrade);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedGrade);
            this.groupBox2.Controls.Add(this.btnAddNewGrade);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(429, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات مقطع";
            // 
            // btnUpdateSelectedGrade
            // 
            this.btnUpdateSelectedGrade.Location = new System.Drawing.Point(180, 350);
            this.btnUpdateSelectedGrade.Name = "btnUpdateSelectedGrade";
            this.btnUpdateSelectedGrade.Size = new System.Drawing.Size(171, 53);
            this.btnUpdateSelectedGrade.TabIndex = 3;
            this.btnUpdateSelectedGrade.Text = "ثبت ویرایش انجام شده روی یک مقطع";
            this.btnUpdateSelectedGrade.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedGrade.Click += new System.EventHandler(this.btnUpdateSelectedGrade_Click);
            // 
            // btnDeleteSelectedGrade
            // 
            this.btnDeleteSelectedGrade.Location = new System.Drawing.Point(6, 291);
            this.btnDeleteSelectedGrade.Name = "btnDeleteSelectedGrade";
            this.btnDeleteSelectedGrade.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedGrade.TabIndex = 2;
            this.btnDeleteSelectedGrade.Text = "حذف مقطع انتخاب شده";
            this.btnDeleteSelectedGrade.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedGrade.Click += new System.EventHandler(this.btnDeleteSelectedGrade_Click);
            // 
            // btnAddNewGrade
            // 
            this.btnAddNewGrade.Location = new System.Drawing.Point(180, 291);
            this.btnAddNewGrade.Name = "btnAddNewGrade";
            this.btnAddNewGrade.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewGrade.TabIndex = 1;
            this.btnAddNewGrade.Text = "افزودن مقطع جدید";
            this.btnAddNewGrade.UseVisualStyleBackColor = true;
            this.btnAddNewGrade.Click += new System.EventHandler(this.btnAddNewGrade_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrereustisGrade);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtGradeName);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 265);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtPrereustisGrade
            // 
            this.txtPrereustisGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPrereustisGrade.FormattingEnabled = true;
            this.txtPrereustisGrade.Location = new System.Drawing.Point(47, 104);
            this.txtPrereustisGrade.Name = "txtPrereustisGrade";
            this.txtPrereustisGrade.Size = new System.Drawing.Size(271, 21);
            this.txtPrereustisGrade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "پیشنیاز مقطع :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام مقطع :";
            // 
            // txtGradeName
            // 
            this.txtGradeName.Location = new System.Drawing.Point(47, 42);
            this.txtGradeName.Name = "txtGradeName";
            this.txtGradeName.Size = new System.Drawing.Size(271, 21);
            this.txtGradeName.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 350);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 53);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "به روز رسانی صفحه و اطلاعات";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtGradeName;
            this.requiredFieldValidator1.ErrorMessage = "وارد کردن نام مقطع الزامی میباشد.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtPrereustisGrade;
            this.requiredFieldValidator2.ErrorMessage = "لطفا یک مقدار از لیست باز شونده انتخاب نمائید.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GradeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت اطلاعات مقاطع";
            this.Load += new System.EventHandler(this.GradeForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtPrereustisGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGradeName;
        private System.Windows.Forms.Button btnUpdateSelectedGrade;
        private System.Windows.Forms.Button btnDeleteSelectedGrade;
        private System.Windows.Forms.Button btnAddNewGrade;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkGradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkGradePrequiestisString;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.Button btnRefresh;
    }
}