namespace SchoolManagment.App
{
    partial class FormTeacherCanTeachLessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherCanTeachLessons));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTeacherSearchInAllColumn = new System.Windows.Forms.TextBox();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectedTeacehrEducation = new System.Windows.Forms.TextBox();
            this.lblSelectedTeacherId = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lVSelectedLesson = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedTeacherName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtFilterLessons = new System.Windows.Forms.TextBox();
            this.dgvLesson = new System.Windows.Forms.DataGridView();
            this.PKLessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkFileldIdString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToSelectedList = new System.Windows.Forms.Button();
            this.DeleteFromSelectedLesson = new System.Windows.Forms.Button();
            this.PKLessonId1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lessonString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvTeacher);
            this.groupBox1.Location = new System.Drawing.Point(436, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 275);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب معلم";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTeacherSearchInAllColumn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جست و جو";
            // 
            // txtTeacherSearchInAllColumn
            // 
            this.txtTeacherSearchInAllColumn.Location = new System.Drawing.Point(50, 20);
            this.txtTeacherSearchInAllColumn.Name = "txtTeacherSearchInAllColumn";
            this.txtTeacherSearchInAllColumn.Size = new System.Drawing.Size(275, 21);
            this.txtTeacherSearchInAllColumn.TabIndex = 0;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherId,
            this.TeacherName,
            this.TeacherEducation});
            this.dgvTeacher.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTeacher.Location = new System.Drawing.Point(3, 94);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.Size = new System.Drawing.Size(358, 178);
            this.dgvTeacher.TabIndex = 0;
            this.dgvTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacher_CellClick);
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "TeacherId";
            this.TeacherId.HeaderText = "کد معلم";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.HeaderText = "نام معلم";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // TeacherEducation
            // 
            this.TeacherEducation.DataPropertyName = "TeacherEducation";
            this.TeacherEducation.HeaderText = "تحصیلات معلم";
            this.TeacherEducation.Name = "TeacherEducation";
            this.TeacherEducation.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtSelectedTeacehrEducation);
            this.groupBox3.Controls.Add(this.lblSelectedTeacherId);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSelectedTeacherName);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 257);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "دروس قابل تدریس برای معلم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "تحصیلات :";
            // 
            // txtSelectedTeacehrEducation
            // 
            this.txtSelectedTeacehrEducation.Location = new System.Drawing.Point(424, 124);
            this.txtSelectedTeacehrEducation.Name = "txtSelectedTeacehrEducation";
            this.txtSelectedTeacehrEducation.ReadOnly = true;
            this.txtSelectedTeacehrEducation.Size = new System.Drawing.Size(298, 21);
            this.txtSelectedTeacehrEducation.TabIndex = 4;
            // 
            // lblSelectedTeacherId
            // 
            this.lblSelectedTeacherId.AutoSize = true;
            this.lblSelectedTeacherId.Location = new System.Drawing.Point(609, 17);
            this.lblSelectedTeacherId.Name = "lblSelectedTeacherId";
            this.lblSelectedTeacherId.Size = new System.Drawing.Size(35, 13);
            this.lblSelectedTeacherId.TabIndex = 3;
            this.lblSelectedTeacherId.Text = "label2";
            this.lblSelectedTeacherId.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lVSelectedLesson);
            this.groupBox5.Location = new System.Drawing.Point(0, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(418, 234);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "لیست درس های انتخاب شده";
            // 
            // lVSelectedLesson
            // 
            this.lVSelectedLesson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PKLessonId1,
            this.lessonString});
            this.lVSelectedLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVSelectedLesson.HideSelection = false;
            this.lVSelectedLesson.Location = new System.Drawing.Point(3, 17);
            this.lVSelectedLesson.Name = "lVSelectedLesson";
            this.lVSelectedLesson.Size = new System.Drawing.Size(412, 214);
            this.lVSelectedLesson.TabIndex = 0;
            this.lVSelectedLesson.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام معلم :";
            // 
            // txtSelectedTeacherName
            // 
            this.txtSelectedTeacherName.Location = new System.Drawing.Point(424, 42);
            this.txtSelectedTeacherName.Name = "txtSelectedTeacherName";
            this.txtSelectedTeacherName.ReadOnly = true;
            this.txtSelectedTeacherName.Size = new System.Drawing.Size(298, 21);
            this.txtSelectedTeacherName.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.dgvLesson);
            this.groupBox4.Location = new System.Drawing.Point(3, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 236);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "لیست درس ها";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtFilterLessons);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(421, 62);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "جست و جو";
            // 
            // txtFilterLessons
            // 
            this.txtFilterLessons.Location = new System.Drawing.Point(50, 20);
            this.txtFilterLessons.Name = "txtFilterLessons";
            this.txtFilterLessons.Size = new System.Drawing.Size(275, 21);
            this.txtFilterLessons.TabIndex = 0;
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
            this.dgvLesson.Location = new System.Drawing.Point(3, 84);
            this.dgvLesson.Name = "dgvLesson";
            this.dgvLesson.ReadOnly = true;
            this.dgvLesson.Size = new System.Drawing.Size(421, 152);
            this.dgvLesson.TabIndex = 1;
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
            // btnAddToSelectedList
            // 
            this.btnAddToSelectedList.Location = new System.Drawing.Point(287, 242);
            this.btnAddToSelectedList.Name = "btnAddToSelectedList";
            this.btnAddToSelectedList.Size = new System.Drawing.Size(75, 36);
            this.btnAddToSelectedList.TabIndex = 10;
            this.btnAddToSelectedList.Text = "افزودن درس";
            this.btnAddToSelectedList.UseVisualStyleBackColor = true;
            this.btnAddToSelectedList.Click += new System.EventHandler(this.btnAddToSelectedList_Click);
            // 
            // DeleteFromSelectedLesson
            // 
            this.DeleteFromSelectedLesson.Location = new System.Drawing.Point(71, 242);
            this.DeleteFromSelectedLesson.Name = "DeleteFromSelectedLesson";
            this.DeleteFromSelectedLesson.Size = new System.Drawing.Size(75, 36);
            this.DeleteFromSelectedLesson.TabIndex = 11;
            this.DeleteFromSelectedLesson.Text = "حذف درس ";
            this.DeleteFromSelectedLesson.UseVisualStyleBackColor = true;
            // 
            // PKLessonId1
            // 
            this.PKLessonId1.Text = "کد درس";
            // 
            // lessonString
            // 
            this.lessonString.Text = "نام درس";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtSelectedTeacherName;
            this.requiredFieldValidator1.ErrorMessage = "لطفا یک معلم از لیست معلم ها انتخاب شود.این مورد الزامی میباشد.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // FormTeacherCanTeachLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.DeleteFromSelectedLesson);
            this.Controls.Add(this.btnAddToSelectedList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTeacherCanTeachLessons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعیین درس های قابل تدریس توسط معلم";
            this.Load += new System.EventHandler(this.FormTeacherCanTeachLessons_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTeacherSearchInAllColumn;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherEducation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectedTeacehrEducation;
        private System.Windows.Forms.Label lblSelectedTeacherId;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSelectedTeacherName;
        private System.Windows.Forms.Button btnAddToSelectedList;
        private System.Windows.Forms.Button DeleteFromSelectedLesson;
        private System.Windows.Forms.ListView lVSelectedLesson;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtFilterLessons;
        private System.Windows.Forms.DataGridView dgvLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKLessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkFileldIdString;
        private System.Windows.Forms.ColumnHeader PKLessonId1;
        private System.Windows.Forms.ColumnHeader lessonString;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
    }
}