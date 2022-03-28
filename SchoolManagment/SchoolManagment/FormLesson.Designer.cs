﻿namespace SchoolManagment.App
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSelectedLesson = new System.Windows.Forms.Button();
            this.btnDeleteSelectedLesson = new System.Windows.Forms.Button();
            this.btnAddNewLesson = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFkFileldId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLessonUnits = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.PKLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLessonUnits)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
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
            // 
            // btnUpdateSelectedLesson
            // 
            this.btnUpdateSelectedLesson.Location = new System.Drawing.Point(180, 350);
            this.btnUpdateSelectedLesson.Name = "btnUpdateSelectedLesson";
            this.btnUpdateSelectedLesson.Size = new System.Drawing.Size(171, 53);
            this.btnUpdateSelectedLesson.TabIndex = 3;
            this.btnUpdateSelectedLesson.Text = "ثبت ویرایش انجام شده روی یک درس";
            this.btnUpdateSelectedLesson.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedLesson
            // 
            this.btnDeleteSelectedLesson.Location = new System.Drawing.Point(6, 291);
            this.btnDeleteSelectedLesson.Name = "btnDeleteSelectedLesson";
            this.btnDeleteSelectedLesson.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedLesson.TabIndex = 2;
            this.btnDeleteSelectedLesson.Text = "حذف درس انتخاب شده";
            this.btnDeleteSelectedLesson.UseVisualStyleBackColor = true;
            // 
            // btnAddNewLesson
            // 
            this.btnAddNewLesson.Location = new System.Drawing.Point(180, 291);
            this.btnAddNewLesson.Name = "btnAddNewLesson";
            this.btnAddNewLesson.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewLesson.TabIndex = 1;
            this.btnAddNewLesson.Text = "افزودن درس جدید";
            this.btnAddNewLesson.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "تعداد واحد :";
            // 
            // txtLessonUnits
            // 
            this.txtLessonUnits.Location = new System.Drawing.Point(198, 107);
            this.txtLessonUnits.Name = "txtLessonUnits";
            this.txtLessonUnits.Size = new System.Drawing.Size(120, 21);
            this.txtLessonUnits.TabIndex = 6;
            this.txtLessonUnits.ThousandsSeparator = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLessons);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 450);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست درس های ثبت شده :";
            // 
            // dgvLessons
            // 
            this.dgvLessons.AllowUserToAddRows = false;
            this.dgvLessons.AllowUserToDeleteRows = false;
            this.dgvLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PKLessonId,
            this.LessonName,
            this.LessonUnits,
            this.FkFileldId,
            this.FkFileldIdString});
            this.dgvLessons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLessons.Location = new System.Drawing.Point(3, 17);
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.ReadOnly = true;
            this.dgvLessons.Size = new System.Drawing.Size(407, 430);
            this.dgvLessons.TabIndex = 0;
            // 
            // PKLessonId
            // 
            this.PKLessonId.HeaderText = "کد درس";
            this.PKLessonId.Name = "PKLessonId";
            this.PKLessonId.ReadOnly = true;
            this.PKLessonId.Visible = false;
            // 
            // LessonName
            // 
            this.LessonName.HeaderText = "نام درس";
            this.LessonName.Name = "LessonName";
            this.LessonName.ReadOnly = true;
            // 
            // LessonUnits
            // 
            this.LessonUnits.HeaderText = "تعداد واحد درس";
            this.LessonUnits.Name = "LessonUnits";
            this.LessonUnits.ReadOnly = true;
            // 
            // FkFileldId
            // 
            this.FkFileldId.HeaderText = "کد رشته ی درس";
            this.FkFileldId.Name = "FkFileldId";
            this.FkFileldId.ReadOnly = true;
            this.FkFileldId.Visible = false;
            // 
            // FkFileldIdString
            // 
            this.FkFileldIdString.HeaderText = "رشته ی درس";
            this.FkFileldIdString.Name = "FkFileldIdString";
            this.FkFileldIdString.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvLessons;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldIdString;
    }
}