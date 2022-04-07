namespace SchoolManagment.App
{
    partial class FormClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClass));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSelectedClass = new System.Windows.Forms.Button();
            this.btnDeleteSelectedClass = new System.Windows.Forms.Button();
            this.btnAddNewClass = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtClassCapacity = new System.Windows.Forms.NumericUpDown();
            this.txtClassLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.PkClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassCapacity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnUpdateSelectedClass);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedClass);
            this.groupBox2.Controls.Add(this.btnAddNewClass);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(441, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 450);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات اطلاعات کلاس";
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
            // btnUpdateSelectedClass
            // 
            this.btnUpdateSelectedClass.Location = new System.Drawing.Point(180, 369);
            this.btnUpdateSelectedClass.Name = "btnUpdateSelectedClass";
            this.btnUpdateSelectedClass.Size = new System.Drawing.Size(171, 53);
            this.btnUpdateSelectedClass.TabIndex = 3;
            this.btnUpdateSelectedClass.Text = "ثبت ویرایش انجام شده روی اطلاعات کلاس";
            this.btnUpdateSelectedClass.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedClass.Click += new System.EventHandler(this.btnUpdateSelectedClass_Click);
            // 
            // btnDeleteSelectedClass
            // 
            this.btnDeleteSelectedClass.Location = new System.Drawing.Point(6, 310);
            this.btnDeleteSelectedClass.Name = "btnDeleteSelectedClass";
            this.btnDeleteSelectedClass.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedClass.TabIndex = 2;
            this.btnDeleteSelectedClass.Text = "حذف  کلاس انتخاب شده";
            this.btnDeleteSelectedClass.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedClass.Click += new System.EventHandler(this.btnDeleteSelectedClass_Click);
            // 
            // btnAddNewClass
            // 
            this.btnAddNewClass.Location = new System.Drawing.Point(180, 310);
            this.btnAddNewClass.Name = "btnAddNewClass";
            this.btnAddNewClass.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewClass.TabIndex = 1;
            this.btnAddNewClass.Text = "افزودن کلاس جدید";
            this.btnAddNewClass.UseVisualStyleBackColor = true;
            this.btnAddNewClass.Click += new System.EventHandler(this.btnAddNewClass_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtClassCapacity);
            this.groupBox3.Controls.Add(this.txtClassLocation);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtClassName);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 284);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtClassCapacity
            // 
            this.txtClassCapacity.Location = new System.Drawing.Point(48, 173);
            this.txtClassCapacity.Name = "txtClassCapacity";
            this.txtClassCapacity.Size = new System.Drawing.Size(271, 21);
            this.txtClassCapacity.TabIndex = 12;
            // 
            // txtClassLocation
            // 
            this.txtClassLocation.Location = new System.Drawing.Point(48, 105);
            this.txtClassLocation.Name = "txtClassLocation";
            this.txtClassLocation.Size = new System.Drawing.Size(271, 21);
            this.txtClassLocation.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ظرفیت کلاس :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "مکان کلاس :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کلاس :";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(48, 41);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(271, 21);
            this.txtClassName.TabIndex = 0;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtClassName;
            this.requiredFieldValidator1.ErrorMessage = "این مورد الزامی میباشد.لطفا نام کلاس را وارد نمائید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtClassLocation;
            this.requiredFieldValidator2.ErrorMessage = "این مورد الزامی میباشد.لطفا مکان کلاس را وارد نمائید.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClass);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 450);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست کلاس های ثبت شده :";
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkClassId,
            this.ClassName,
            this.ClassLocation,
            this.ClassCapacity});
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClass.Location = new System.Drawing.Point(3, 17);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.Size = new System.Drawing.Size(429, 430);
            this.dgvClass.TabIndex = 0;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // PkClassId
            // 
            this.PkClassId.DataPropertyName = "PkClassId";
            this.PkClassId.HeaderText = "کد کلاس";
            this.PkClassId.Name = "PkClassId";
            this.PkClassId.ReadOnly = true;
            this.PkClassId.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "نام کلاس";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // ClassLocation
            // 
            this.ClassLocation.DataPropertyName = "ClassLocation";
            this.ClassLocation.HeaderText = "مکان کلاس";
            this.ClassLocation.Name = "ClassLocation";
            this.ClassLocation.ReadOnly = true;
            // 
            // ClassCapacity
            // 
            this.ClassCapacity.DataPropertyName = "ClassCapacity";
            this.ClassCapacity.HeaderText = "ظرفیت کلاس";
            this.ClassCapacity.Name = "ClassCapacity";
            this.ClassCapacity.ReadOnly = true;
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txtClassCapacity;
            this.rangeValidator1.ErrorMessage = "این مورد الزامی میباشد.لطفا یک مقدار بین 1 تا 100 انتخاب نمائید.";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "100";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormClass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت کلاس ها";
            this.Load += new System.EventHandler(this.FormClass_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassCapacity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateSelectedClass;
        private System.Windows.Forms.Button btnDeleteSelectedClass;
        private System.Windows.Forms.Button btnAddNewClass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtClassCapacity;
        private System.Windows.Forms.TextBox txtClassLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassCapacity;
        private ValidationComponents.RangeValidator rangeValidator1;
    }
}