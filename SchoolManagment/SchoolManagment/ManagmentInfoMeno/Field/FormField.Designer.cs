namespace SchoolManagment.App
{
    partial class FormField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormField));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSelectedField = new System.Windows.Forms.Button();
            this.btnDeleteSelectedField = new System.Windows.Forms.Button();
            this.btnAddNewField = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFKUnGraduteId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.PkFieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKUnGraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKUnGraduteIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnUpdateSelectedField);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedField);
            this.groupBox2.Controls.Add(this.btnAddNewField);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(419, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 450);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات رشته";
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
            // btnUpdateSelectedField
            // 
            this.btnUpdateSelectedField.Location = new System.Drawing.Point(180, 350);
            this.btnUpdateSelectedField.Name = "btnUpdateSelectedField";
            this.btnUpdateSelectedField.Size = new System.Drawing.Size(171, 53);
            this.btnUpdateSelectedField.TabIndex = 3;
            this.btnUpdateSelectedField.Text = "ثبت ویرایش انجام شده روی یک رشته";
            this.btnUpdateSelectedField.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedField.Click += new System.EventHandler(this.btnUpdateSelectedField_Click);
            // 
            // btnDeleteSelectedField
            // 
            this.btnDeleteSelectedField.Location = new System.Drawing.Point(6, 291);
            this.btnDeleteSelectedField.Name = "btnDeleteSelectedField";
            this.btnDeleteSelectedField.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedField.TabIndex = 2;
            this.btnDeleteSelectedField.Text = "حذف رشته انتخاب شده";
            this.btnDeleteSelectedField.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedField.Click += new System.EventHandler(this.btnDeleteSelectedField_Click);
            // 
            // btnAddNewField
            // 
            this.btnAddNewField.Location = new System.Drawing.Point(180, 291);
            this.btnAddNewField.Name = "btnAddNewField";
            this.btnAddNewField.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewField.TabIndex = 1;
            this.btnAddNewField.Text = "افزودن رشته جدید";
            this.btnAddNewField.UseVisualStyleBackColor = true;
            this.btnAddNewField.Click += new System.EventHandler(this.btnAddNewField_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFKUnGraduteId);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFieldName);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 265);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtFKUnGraduteId
            // 
            this.txtFKUnGraduteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFKUnGraduteId.FormattingEnabled = true;
            this.txtFKUnGraduteId.Location = new System.Drawing.Point(47, 104);
            this.txtFKUnGraduteId.Name = "txtFKUnGraduteId";
            this.txtFKUnGraduteId.Size = new System.Drawing.Size(271, 21);
            this.txtFKUnGraduteId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "زیر مقطع این رشته :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام رشته :";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(47, 42);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(271, 21);
            this.txtFieldName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFields);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 450);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست رشته های ثبت شده";
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
            this.dgvFields.Size = new System.Drawing.Size(407, 430);
            this.dgvFields.TabIndex = 0;
            this.dgvFields.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFields_CellClick);
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
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtFKUnGraduteId;
            this.requiredFieldValidator2.ErrorMessage = "لطفا یک مقدار از لیست باز شونده انتخاب نمائید.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtFieldName;
            this.requiredFieldValidator1.ErrorMessage = "وارد کردن نام رشته الزامی میباشد.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // FormField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormField";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت اطلاعات رشته ها";
            this.Load += new System.EventHandler(this.FormField_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateSelectedField;
        private System.Windows.Forms.Button btnDeleteSelectedField;
        private System.Windows.Forms.Button btnAddNewField;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtFKUnGraduteId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFieldName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkFieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKUnGraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKUnGraduteIdString;
    }
}