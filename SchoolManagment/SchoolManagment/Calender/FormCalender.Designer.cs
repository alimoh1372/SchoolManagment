namespace SchoolManagment.App
{
    partial class FormCalender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalender));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypeDay = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDayAlternate = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimeAlternate = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCalender = new System.Windows.Forms.DataGridView();
            this.CalenderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkDayAlterNate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkDayAlterNateString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTimeAlterNateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTimeAlterNateIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddCallender = new System.Windows.Forms.Button();
            this.btnDeleteCalender = new System.Windows.Forms.Button();
            this.btnUpdateCalender = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCalenderName = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCalenderDescription = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalender)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTypeDay);
            this.groupBox1.Location = new System.Drawing.Point(514, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب نوع تناوب(هفتگی یا ماهانه)";
            // 
            // txtTypeDay
            // 
            this.txtTypeDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTypeDay.FormattingEnabled = true;
            this.txtTypeDay.Location = new System.Drawing.Point(6, 37);
            this.txtTypeDay.Name = "txtTypeDay";
            this.txtTypeDay.Size = new System.Drawing.Size(184, 21);
            this.txtTypeDay.TabIndex = 0;
            this.txtTypeDay.SelectedValueChanged += new System.EventHandler(this.txtTypeDay_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDayAlternate);
            this.groupBox2.Location = new System.Drawing.Point(263, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "انتخاب روز هفته(یا روز از ماه)";
            // 
            // txtDayAlternate
            // 
            this.txtDayAlternate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDayAlternate.FormattingEnabled = true;
            this.txtDayAlternate.Location = new System.Drawing.Point(6, 37);
            this.txtDayAlternate.Name = "txtDayAlternate";
            this.txtDayAlternate.Size = new System.Drawing.Size(184, 21);
            this.txtDayAlternate.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimeAlternate);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 87);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "انتخاب زمان";
            // 
            // txtTimeAlternate
            // 
            this.txtTimeAlternate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTimeAlternate.FormattingEnabled = true;
            this.txtTimeAlternate.Location = new System.Drawing.Point(6, 37);
            this.txtTimeAlternate.Name = "txtTimeAlternate";
            this.txtTimeAlternate.Size = new System.Drawing.Size(184, 21);
            this.txtTimeAlternate.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCalender);
            this.groupBox5.Location = new System.Drawing.Point(12, 151);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(747, 234);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "لیست تقویم های آموزشی ثبت شده";
            // 
            // dgvCalender
            // 
            this.dgvCalender.AllowUserToAddRows = false;
            this.dgvCalender.AllowUserToDeleteRows = false;
            this.dgvCalender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalender.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalenderId,
            this.CalenderName,
            this.CalenderDescription,
            this.FkDayAlterNate,
            this.FkDayAlterNateString,
            this.FkTimeAlterNateId,
            this.FkTimeAlterNateIdString});
            this.dgvCalender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalender.Location = new System.Drawing.Point(3, 17);
            this.dgvCalender.Name = "dgvCalender";
            this.dgvCalender.ReadOnly = true;
            this.dgvCalender.Size = new System.Drawing.Size(741, 214);
            this.dgvCalender.TabIndex = 3;
            this.dgvCalender.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalender_CellClick);
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
            // btnAddCallender
            // 
            this.btnAddCallender.Location = new System.Drawing.Point(532, 391);
            this.btnAddCallender.Name = "btnAddCallender";
            this.btnAddCallender.Size = new System.Drawing.Size(147, 52);
            this.btnAddCallender.TabIndex = 5;
            this.btnAddCallender.Text = "اضافه کردن تقویم";
            this.btnAddCallender.UseVisualStyleBackColor = true;
            this.btnAddCallender.Click += new System.EventHandler(this.btnAddCallender_Click);
            // 
            // btnDeleteCalender
            // 
            this.btnDeleteCalender.Location = new System.Drawing.Point(379, 391);
            this.btnDeleteCalender.Name = "btnDeleteCalender";
            this.btnDeleteCalender.Size = new System.Drawing.Size(147, 52);
            this.btnDeleteCalender.TabIndex = 6;
            this.btnDeleteCalender.Text = "حذف تقویم";
            this.btnDeleteCalender.UseVisualStyleBackColor = true;
            this.btnDeleteCalender.Click += new System.EventHandler(this.btnDeleteCalender_Click);
            // 
            // btnUpdateCalender
            // 
            this.btnUpdateCalender.Location = new System.Drawing.Point(226, 391);
            this.btnUpdateCalender.Name = "btnUpdateCalender";
            this.btnUpdateCalender.Size = new System.Drawing.Size(147, 52);
            this.btnUpdateCalender.TabIndex = 7;
            this.btnUpdateCalender.Text = "به روز رسانی تقویم انتخاب شده";
            this.btnUpdateCalender.UseVisualStyleBackColor = true;
            this.btnUpdateCalender.Click += new System.EventHandler(this.btnUpdateCalender_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCalenderName);
            this.groupBox4.Location = new System.Drawing.Point(392, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 39);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "نام تقویم";
            // 
            // txtCalenderName
            // 
            this.txtCalenderName.Location = new System.Drawing.Point(6, 12);
            this.txtCalenderName.Name = "txtCalenderName";
            this.txtCalenderName.Size = new System.Drawing.Size(306, 21);
            this.txtCalenderName.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtCalenderDescription);
            this.groupBox6.Location = new System.Drawing.Point(12, 106);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(374, 39);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "توضیحات تقویم";
            // 
            // txtCalenderDescription
            // 
            this.txtCalenderDescription.Location = new System.Drawing.Point(6, 12);
            this.txtCalenderDescription.Name = "txtCalenderDescription";
            this.txtCalenderDescription.Size = new System.Drawing.Size(281, 21);
            this.txtCalenderDescription.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(73, 391);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 52);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "به روز رسانی صفحه و اطلاعات";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtCalenderName;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام تقویم را وارد نمائید.این مورد الزامی میباشد.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // FormCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 458);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnUpdateCalender);
            this.Controls.Add(this.btnDeleteCalender);
            this.Controls.Add(this.btnAddCallender);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCalender";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت اطلاعات تقویم آموزشی";
            this.Load += new System.EventHandler(this.FormCalender_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalender)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtTypeDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txtDayAlternate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtTimeAlternate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvCalender;
        private System.Windows.Forms.Button btnAddCallender;
        private System.Windows.Forms.Button btnDeleteCalender;
        private System.Windows.Forms.Button btnUpdateCalender;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCalenderName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtCalenderDescription;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkDayAlterNate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkDayAlterNateString;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTimeAlterNateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTimeAlterNateIdString;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
    }
}