namespace SchoolManagment.App
{
    partial class UnderGradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnderGradeForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSelectedUnderGrade = new System.Windows.Forms.Button();
            this.btnDeleteSelectedUnderGradute = new System.Windows.Forms.Button();
            this.btnAddNewUnderGradute = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFkGradeId = new System.Windows.Forms.ComboBox();
            this.txtUnGradutePrequestis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnGraduteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUnderGradutes = new System.Windows.Forms.DataGridView();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.PkUnGraduteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnGraduteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkGradeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FkUnGradutePrequestis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderGradutes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnUpdateSelectedUnderGrade);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedUnderGradute);
            this.groupBox2.Controls.Add(this.btnAddNewUnderGradute);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(552, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 423);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات زیر مقطع :";
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
            // btnUpdateSelectedUnderGrade
            // 
            this.btnUpdateSelectedUnderGrade.Location = new System.Drawing.Point(180, 350);
            this.btnUpdateSelectedUnderGrade.Name = "btnUpdateSelectedUnderGrade";
            this.btnUpdateSelectedUnderGrade.Size = new System.Drawing.Size(171, 53);
            this.btnUpdateSelectedUnderGrade.TabIndex = 3;
            this.btnUpdateSelectedUnderGrade.Text = "ثبت ویرایش انجام شده روی یک زیرمقطع";
            this.btnUpdateSelectedUnderGrade.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedUnderGradute
            // 
            this.btnDeleteSelectedUnderGradute.Location = new System.Drawing.Point(6, 291);
            this.btnDeleteSelectedUnderGradute.Name = "btnDeleteSelectedUnderGradute";
            this.btnDeleteSelectedUnderGradute.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedUnderGradute.TabIndex = 2;
            this.btnDeleteSelectedUnderGradute.Text = "حذف زیر مقطع انتخاب شده";
            this.btnDeleteSelectedUnderGradute.UseVisualStyleBackColor = true;
            // 
            // btnAddNewUnderGradute
            // 
            this.btnAddNewUnderGradute.Location = new System.Drawing.Point(180, 291);
            this.btnAddNewUnderGradute.Name = "btnAddNewUnderGradute";
            this.btnAddNewUnderGradute.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewUnderGradute.TabIndex = 1;
            this.btnAddNewUnderGradute.Text = "افزودن زیر مقطع  جدید";
            this.btnAddNewUnderGradute.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFkGradeId);
            this.groupBox3.Controls.Add(this.txtUnGradutePrequestis);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtUnGraduteName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 265);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtFkGradeId
            // 
            this.txtFkGradeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFkGradeId.FormattingEnabled = true;
            this.txtFkGradeId.Location = new System.Drawing.Point(47, 116);
            this.txtFkGradeId.Name = "txtFkGradeId";
            this.txtFkGradeId.Size = new System.Drawing.Size(271, 21);
            this.txtFkGradeId.TabIndex = 5;
            // 
            // txtUnGradutePrequestis
            // 
            this.txtUnGradutePrequestis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnGradutePrequestis.FormattingEnabled = true;
            this.txtUnGradutePrequestis.Location = new System.Drawing.Point(47, 182);
            this.txtUnGradutePrequestis.Name = "txtUnGradutePrequestis";
            this.txtUnGradutePrequestis.Size = new System.Drawing.Size(271, 21);
            this.txtUnGradutePrequestis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام زیرمقطع :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "مقطع تحصیلی مربوط به این زیر مقطع :";
            // 
            // txtUnGraduteName
            // 
            this.txtUnGraduteName.Location = new System.Drawing.Point(47, 45);
            this.txtUnGraduteName.Name = "txtUnGraduteName";
            this.txtUnGraduteName.Size = new System.Drawing.Size(271, 21);
            this.txtUnGraduteName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "پیشنیاز زیرمقطع :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUnderGradutes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست زیرمقطع های ثبت شده";
            // 
            // dgvUnderGradutes
            // 
            this.dgvUnderGradutes.AllowUserToAddRows = false;
            this.dgvUnderGradutes.AllowUserToDeleteRows = false;
            this.dgvUnderGradutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderGradutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderGradutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PkUnGraduteId,
            this.UnGraduteName,
            this.FkGradeId,
            this.FkUnGradutePrequestis});
            this.dgvUnderGradutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnderGradutes.Location = new System.Drawing.Point(3, 17);
            this.dgvUnderGradutes.Name = "dgvUnderGradutes";
            this.dgvUnderGradutes.ReadOnly = true;
            this.dgvUnderGradutes.Size = new System.Drawing.Size(528, 406);
            this.dgvUnderGradutes.TabIndex = 0;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtUnGraduteName;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام زیر مقطع را انتخاب نمائید. این مورد الزامی است.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtUnGradutePrequestis;
            this.requiredFieldValidator2.ErrorMessage = "لطفا نام مقطع را انتخاب نمائید. این مورد الزامی میباشد.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtFkGradeId;
            this.requiredFieldValidator3.ErrorMessage = "لطفا نام مقطع تحصیلی را انتخاب نمائید.این مورد الزامی میباشد.";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // PkUnGraduteId
            // 
            this.PkUnGraduteId.DataPropertyName = "PkUnGraduteId";
            this.PkUnGraduteId.HeaderText = "کد مقطع";
            this.PkUnGraduteId.Name = "PkUnGraduteId";
            this.PkUnGraduteId.ReadOnly = true;
            this.PkUnGraduteId.Visible = false;
            // 
            // UnGraduteName
            // 
            this.UnGraduteName.DataPropertyName = "UnGraduteName";
            this.UnGraduteName.HeaderText = "نام زیرمقطع";
            this.UnGraduteName.Name = "UnGraduteName";
            this.UnGraduteName.ReadOnly = true;
            // 
            // FkGradeId
            // 
            this.FkGradeId.DataPropertyName = "FkGradeId";
            this.FkGradeId.HeaderText = "مقطع تحصیلی این زیر مقطع";
            this.FkGradeId.Name = "FkGradeId";
            this.FkGradeId.ReadOnly = true;
            // 
            // FkUnGradutePrequestis
            // 
            this.FkUnGradutePrequestis.DataPropertyName = "FkUnGradutePrequestis";
            this.FkUnGradutePrequestis.HeaderText = " پیشنیاز";
            this.FkUnGradutePrequestis.Name = "FkUnGradutePrequestis";
            this.FkUnGradutePrequestis.ReadOnly = true;
            // 
            // UnderGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnderGradeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت اطلاعات زیر مقطع ها";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderGradutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateSelectedUnderGrade;
        private System.Windows.Forms.Button btnDeleteSelectedUnderGradute;
        private System.Windows.Forms.Button btnAddNewUnderGradute;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtFkGradeId;
        private System.Windows.Forms.ComboBox txtUnGradutePrequestis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnGraduteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUnderGradutes;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkUnGraduteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnGraduteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkGradeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FkUnGradutePrequestis;
    }
}