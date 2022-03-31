﻿namespace SchoolManagment.App
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mnStManagmentInfo = new System.Windows.Forms.MenuStrip();
            this.tlstManagMentInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersonalManage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGradeInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUnderGradeInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcademyYearInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFileldsInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLessonInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudentInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTeacherInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClassroomInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStManagmentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 447);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(852, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mnStManagmentInfo
            // 
            this.mnStManagmentInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnStManagmentInfo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnStManagmentInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstManagMentInfo});
            this.mnStManagmentInfo.Location = new System.Drawing.Point(0, 0);
            this.mnStManagmentInfo.Name = "mnStManagmentInfo";
            this.mnStManagmentInfo.Size = new System.Drawing.Size(852, 24);
            this.mnStManagmentInfo.TabIndex = 3;
            this.mnStManagmentInfo.Text = "مدیریت مدرسه";
            // 
            // tlstManagMentInfo
            // 
            this.tlstManagMentInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPersonalManage,
            this.btnGradeInformation,
            this.btnUnderGradeInformation,
            this.btnAcademyYearInformation,
            this.btnFileldsInformation,
            this.btnLessonInformation,
            this.btnStudentInformation,
            this.btnTeacherInfo,
            this.btnClassroomInformation});
            this.tlstManagMentInfo.Name = "tlstManagMentInfo";
            this.tlstManagMentInfo.Size = new System.Drawing.Size(99, 20);
            this.tlstManagMentInfo.Text = "مدیریت اطلاعات";
            // 
            // btnPersonalManage
            // 
            this.btnPersonalManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPersonalManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPersonalManage.Name = "btnPersonalManage";
            this.btnPersonalManage.ShowShortcutKeys = false;
            this.btnPersonalManage.Size = new System.Drawing.Size(180, 22);
            this.btnPersonalManage.Text = "پرسنل";
            this.btnPersonalManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonalManage.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnPersonalManage.ToolTipText = "منوی مدیریت پرسنل، اضافه،حذف و ویرایش اطلاعات پرسنل";
            // 
            // btnGradeInformation
            // 
            this.btnGradeInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGradeInformation.Name = "btnGradeInformation";
            this.btnGradeInformation.Size = new System.Drawing.Size(180, 22);
            this.btnGradeInformation.Text = "مقطع";
            this.btnGradeInformation.ToolTipText = "مدیریت مقاطع تحصیلی اصلی(دبیرستان،راهنمایی،ابتدایی) اعم از حذف و اضافه و ویرایش ";
            this.btnGradeInformation.Click += new System.EventHandler(this.btnGradeInformation_Click);
            // 
            // btnUnderGradeInformation
            // 
            this.btnUnderGradeInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUnderGradeInformation.Name = "btnUnderGradeInformation";
            this.btnUnderGradeInformation.Size = new System.Drawing.Size(180, 22);
            this.btnUnderGradeInformation.Text = "زیرمقطع";
            this.btnUnderGradeInformation.ToolTipText = "مدیریت اطلاعات زیر مقطع ها(پایه های هر مقطع) اعم از حذف و اضافه و ویرایش آنها";
            this.btnUnderGradeInformation.Click += new System.EventHandler(this.btnUnderGradeInformation_Click);
            // 
            // btnAcademyYearInformation
            // 
            this.btnAcademyYearInformation.Name = "btnAcademyYearInformation";
            this.btnAcademyYearInformation.Size = new System.Drawing.Size(180, 22);
            this.btnAcademyYearInformation.Text = "سال تحصیلی";
            this.btnAcademyYearInformation.ToolTipText = "مدیریت سال های تحصیلی،حذف، اضافه و ویرایش آنها";
            this.btnAcademyYearInformation.Click += new System.EventHandler(this.btnAcademyYearInformation_Click);
            // 
            // btnFileldsInformation
            // 
            this.btnFileldsInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFileldsInformation.Name = "btnFileldsInformation";
            this.btnFileldsInformation.Size = new System.Drawing.Size(180, 22);
            this.btnFileldsInformation.Text = "رشته های تحصیلی";
            this.btnFileldsInformation.ToolTipText = "مدیریت اطلاعات مربوط به رشته های تحصیلی موجود در هر زیرمقطع، حذف و اضافه و ویرایش" +
    " آن";
            this.btnFileldsInformation.Click += new System.EventHandler(this.btnFileldsInformation_Click);
            // 
            // btnLessonInformation
            // 
            this.btnLessonInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLessonInformation.Name = "btnLessonInformation";
            this.btnLessonInformation.Size = new System.Drawing.Size(180, 22);
            this.btnLessonInformation.Text = "درس";
            this.btnLessonInformation.ToolTipText = "مدیریت اطلاعات مربوط به درس های هر رشته و مقاطع-حذف ، اضافه و ویرایش";
            this.btnLessonInformation.Click += new System.EventHandler(this.btnLessonInformation_Click);
            // 
            // btnStudentInformation
            // 
            this.btnStudentInformation.Name = "btnStudentInformation";
            this.btnStudentInformation.Size = new System.Drawing.Size(180, 22);
            this.btnStudentInformation.Text = "دانش آموز";
            this.btnStudentInformation.ToolTipText = "مدیریت اطلاعات مربوط به دانش آموزان ،حذف و اضافه و ویرایش";
            // 
            // btnTeacherInfo
            // 
            this.btnTeacherInfo.Name = "btnTeacherInfo";
            this.btnTeacherInfo.Size = new System.Drawing.Size(180, 22);
            this.btnTeacherInfo.Text = "معلم";
            this.btnTeacherInfo.ToolTipText = "مدیریت اطلاعات مربوط به معلمان-حذف و اضافه و ویرایش آن";
            // 
            // btnClassroomInformation
            // 
            this.btnClassroomInformation.Name = "btnClassroomInformation";
            this.btnClassroomInformation.Size = new System.Drawing.Size(180, 22);
            this.btnClassroomInformation.Text = "کلاس";
            this.btnClassroomInformation.ToolTipText = "مدیریت اطلاعات مربوط به کلاس های مدرسه ،حذف ، اضافه و ویرایش";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 511);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnStManagmentInfo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت مدرسه";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnStManagmentInfo.ResumeLayout(false);
            this.mnStManagmentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mnStManagmentInfo;
        private System.Windows.Forms.ToolStripMenuItem tlstManagMentInfo;
        private System.Windows.Forms.ToolStripMenuItem btnPersonalManage;
        private System.Windows.Forms.ToolStripMenuItem btnGradeInformation;
        private System.Windows.Forms.ToolStripMenuItem btnUnderGradeInformation;
        private System.Windows.Forms.ToolStripMenuItem btnAcademyYearInformation;
        private System.Windows.Forms.ToolStripMenuItem btnFileldsInformation;
        private System.Windows.Forms.ToolStripMenuItem btnLessonInformation;
        private System.Windows.Forms.ToolStripMenuItem btnStudentInformation;
        private System.Windows.Forms.ToolStripMenuItem btnTeacherInfo;
        private System.Windows.Forms.ToolStripMenuItem btnClassroomInformation;
    }
}

