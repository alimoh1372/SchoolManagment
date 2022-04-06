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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypeDay = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDayAlternate = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimeAlternate = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedLessons = new System.Windows.Forms.DataGridView();
            this.CalenderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkDayAlterNate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkDayAlterNateString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTimeAlterNateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkTimeAlterNateIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedLessons)).BeginInit();
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
            this.groupBox5.Controls.Add(this.dgvSelectedLessons);
            this.groupBox5.Location = new System.Drawing.Point(12, 108);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(747, 234);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "لیست تقویم های آموزشی ثبت شده";
            // 
            // dgvSelectedLessons
            // 
            this.dgvSelectedLessons.AllowUserToAddRows = false;
            this.dgvSelectedLessons.AllowUserToDeleteRows = false;
            this.dgvSelectedLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CalenderId,
            this.CalenderName,
            this.FkDayAlterNate,
            this.FkDayAlterNateString,
            this.FkTimeAlterNateId,
            this.FkTimeAlterNateIdString});
            this.dgvSelectedLessons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedLessons.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedLessons.Name = "dgvSelectedLessons";
            this.dgvSelectedLessons.ReadOnly = true;
            this.dgvSelectedLessons.Size = new System.Drawing.Size(741, 214);
            this.dgvSelectedLessons.TabIndex = 3;
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
            this.FkDayAlterNateString.HeaderText = "نوع تناوب روز";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "اضافه کردن تقویم";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.button1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedLessons)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSelectedLessons;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkDayAlterNate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkDayAlterNateString;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTimeAlterNateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkTimeAlterNateIdString;
        private System.Windows.Forms.Button button1;
    }
}