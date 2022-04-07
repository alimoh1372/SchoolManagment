namespace SchoolManagment.App
{
    partial class FormLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLesson));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSelectedLesson = new System.Windows.Forms.Button();
            this.btnDeleteSelectedLesson = new System.Windows.Forms.Button();
            this.btnAddNewLesson = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLessonUnits = new System.Windows.Forms.NumericUpDown();
            this.txtFkFileldId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLesson = new System.Windows.Forms.DataGridView();
            this.PKLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLessonUnits)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(441, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 450);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات درس";
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
            // btnUpdateSelectedLesson
            // 
            this.btnUpdateSelectedLesson.Location = new System.Drawing.Point(180, 350);
            this.btnUpdateSelectedLesson.Name = "btnUpdateSelectedLesson";
            this.btnUpdateSelectedLesson.Size = new System.Drawing.Size(171, 53);
            this.btnUpdateSelectedLesson.TabIndex = 3;
            this.btnUpdateSelectedLesson.Text = "ثبت ویرایش انجام شده روی یک درس";
            this.btnUpdateSelectedLesson.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedLesson.Click += new System.EventHandler(this.btnUpdateSelectedLesson_Click);
            // 
            // btnDeleteSelectedLesson
            // 
            this.btnDeleteSelectedLesson.Location = new System.Drawing.Point(6, 291);
            this.btnDeleteSelectedLesson.Name = "btnDeleteSelectedLesson";
            this.btnDeleteSelectedLesson.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedLesson.TabIndex = 2;
            this.btnDeleteSelectedLesson.Text = "حذف درس انتخاب شده";
            this.btnDeleteSelectedLesson.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedLesson.Click += new System.EventHandler(this.btnDeleteSelectedLesson_Click);
            // 
            // btnAddNewLesson
            // 
            this.btnAddNewLesson.Location = new System.Drawing.Point(180, 291);
            this.btnAddNewLesson.Name = "btnAddNewLesson";
            this.btnAddNewLesson.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewLesson.TabIndex = 1;
            this.btnAddNewLesson.Text = "افزودن درس جدید";
            this.btnAddNewLesson.UseVisualStyleBackColor = true;
            this.btnAddNewLesson.Click += new System.EventHandler(this.btnAddNewLesson_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLessonUnits);
            this.groupBox3.Controls.Add(this.txtFkFileldId);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtLessonName);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 265);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtLessonUnits
            // 
            this.txtLessonUnits.Location = new System.Drawing.Point(198, 107);
            this.txtLessonUnits.Name = "txtLessonUnits";
            this.txtLessonUnits.Size = new System.Drawing.Size(120, 21);
            this.txtLessonUnits.TabIndex = 6;
            this.txtLessonUnits.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "تعداد واحد :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "رشته ای که این درس در آن ارائه میشود :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام درس :";
            // 
            // txtLessonName
            // 
            this.txtLessonName.Location = new System.Drawing.Point(47, 42);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(271, 21);
            this.txtLessonName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLesson);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 450);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست درس های ثبت شده :";
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
            this.dgvLesson.Size = new System.Drawing.Size(407, 430);
            this.dgvLesson.TabIndex = 0;
            this.dgvLesson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLessons_CellClick);
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
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtLessonName;
            this.requiredFieldValidator1.ErrorMessage = "این مورد الزامی میباشد لطفا آن را تکمیل فرمائید.با تشکر";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtFkFileldId;
            this.requiredFieldValidator3.ErrorMessage = "این مورد الزامی میباشد.لطفا یک مقدار از لیست باز شونده برای آن انتخاب نمائید.";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txtLessonUnits;
            this.rangeValidator1.ErrorMessage = "مقدار 1 الی 100 مورد قبول میباشد لطفا وارد نمائید.";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "100";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // FormLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLesson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت درس های قابل ارائه در رشته";
            this.Load += new System.EventHandler(this.FormLesson_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLessonUnits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateSelectedLesson;
        private System.Windows.Forms.Button btnDeleteSelectedLesson;
        private System.Windows.Forms.Button btnAddNewLesson;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtLessonUnits;
        private System.Windows.Forms.ComboBox txtFkFileldId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldIdString;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RangeValidator rangeValidator1;
    }
}