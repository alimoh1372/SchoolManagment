namespace SchoolManagment.App
{
    partial class AcademyYearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademyYearForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateSelectedAcademyYear = new System.Windows.Forms.Button();
            this.btnDeleteSelectedAcademyYear = new System.Windows.Forms.Button();
            this.btnAddNewAcademyYear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEndDateText = new System.Windows.Forms.TextBox();
            this.txtStartDateText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDtEndDate = new BehComponents.DateTimePickerX();
            this.txtDtStartDate = new BehComponents.DateTimePickerX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcademyYearName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAcademyYears = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfDaysOfYear = new System.Windows.Forms.TextBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.AcademyYearId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademyYearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDaysOfYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademyYears)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnUpdateSelectedAcademyYear);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedAcademyYear);
            this.groupBox2.Controls.Add(this.btnAddNewAcademyYear);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(537, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 450);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزئیات سال تحصیلی :";
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
            // btnUpdateSelectedAcademyYear
            // 
            this.btnUpdateSelectedAcademyYear.Location = new System.Drawing.Point(180, 350);
            this.btnUpdateSelectedAcademyYear.Name = "btnUpdateSelectedAcademyYear";
            this.btnUpdateSelectedAcademyYear.Size = new System.Drawing.Size(171, 53);
            this.btnUpdateSelectedAcademyYear.TabIndex = 3;
            this.btnUpdateSelectedAcademyYear.Text = "تبت ویرایش انجام شده روی یک سال تحصیلی";
            this.btnUpdateSelectedAcademyYear.UseVisualStyleBackColor = true;
            this.btnUpdateSelectedAcademyYear.Click += new System.EventHandler(this.btnUpdateSelectedAcademyYear_Click);
            // 
            // btnDeleteSelectedAcademyYear
            // 
            this.btnDeleteSelectedAcademyYear.Location = new System.Drawing.Point(6, 291);
            this.btnDeleteSelectedAcademyYear.Name = "btnDeleteSelectedAcademyYear";
            this.btnDeleteSelectedAcademyYear.Size = new System.Drawing.Size(171, 53);
            this.btnDeleteSelectedAcademyYear.TabIndex = 2;
            this.btnDeleteSelectedAcademyYear.Text = "حذف سال تحصیلی انتخاب شده";
            this.btnDeleteSelectedAcademyYear.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedAcademyYear.Click += new System.EventHandler(this.btnDeleteSelectedAcademyYear_Click);
            // 
            // btnAddNewAcademyYear
            // 
            this.btnAddNewAcademyYear.Location = new System.Drawing.Point(180, 291);
            this.btnAddNewAcademyYear.Name = "btnAddNewAcademyYear";
            this.btnAddNewAcademyYear.Size = new System.Drawing.Size(171, 53);
            this.btnAddNewAcademyYear.TabIndex = 1;
            this.btnAddNewAcademyYear.Text = "افزودن سال تحصیلی جدید";
            this.btnAddNewAcademyYear.UseVisualStyleBackColor = true;
            this.btnAddNewAcademyYear.Click += new System.EventHandler(this.btnAddNewAcademyYear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNumberOfDaysOfYear);
            this.groupBox3.Controls.Add(this.txtEndDateText);
            this.groupBox3.Controls.Add(this.txtStartDateText);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDtEndDate);
            this.groupBox3.Controls.Add(this.txtDtStartDate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtAcademyYearName);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 265);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtEndDateText
            // 
            this.txtEndDateText.Location = new System.Drawing.Point(47, 174);
            this.txtEndDateText.Name = "txtEndDateText";
            this.txtEndDateText.ReadOnly = true;
            this.txtEndDateText.Size = new System.Drawing.Size(136, 21);
            this.txtEndDateText.TabIndex = 8;
            this.txtEndDateText.TextChanged += new System.EventHandler(this.txtEndDateText_TextChanged);
            // 
            // txtStartDateText
            // 
            this.txtStartDateText.Location = new System.Drawing.Point(48, 107);
            this.txtStartDateText.Name = "txtStartDateText";
            this.txtStartDateText.ReadOnly = true;
            this.txtStartDateText.Size = new System.Drawing.Size(136, 21);
            this.txtStartDateText.TabIndex = 6;
            this.txtStartDateText.TextChanged += new System.EventHandler(this.txtStartDateText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاریخ شروع سال تحصیلی :";
            // 
            // txtDtEndDate
            // 
            this.txtDtEndDate.AnchorSize = new System.Drawing.Size(128, 21);
            this.txtDtEndDate.BackColor = System.Drawing.Color.White;
            this.txtDtEndDate.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.txtDtEndDate.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.txtDtEndDate.CalendarDayRectTickness = 2F;
            this.txtDtEndDate.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.txtDtEndDate.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDtEndDate.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.txtDtEndDate.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.txtDtEndDate.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.txtDtEndDate.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.txtDtEndDate.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.txtDtEndDate.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.txtDtEndDate.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.txtDtEndDate.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.txtDtEndDate.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtDtEndDate.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtDtEndDate.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.txtDtEndDate.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtDtEndDate.CalendarShowToday = true;
            this.txtDtEndDate.CalendarShowTodayRect = true;
            this.txtDtEndDate.CalendarShowToolTips = false;
            this.txtDtEndDate.CalendarShowTrailing = true;
            this.txtDtEndDate.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.txtDtEndDate.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtDtEndDate.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.txtDtEndDate.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtDtEndDate.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtDtEndDate.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.txtDtEndDate.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.txtDtEndDate.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDtEndDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.txtDtEndDate.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.txtDtEndDate.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDtEndDate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.txtDtEndDate.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.txtDtEndDate.CalendarTodayRectTickness = 2F;
            this.txtDtEndDate.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.txtDtEndDate.CalendarType = BehComponents.CalendarTypes.Persian;
            this.txtDtEndDate.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.txtDtEndDate.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDtEndDate.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.txtDtEndDate.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.txtDtEndDate.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.txtDtEndDate.ClearButtonBackColor = System.Drawing.Color.White;
            this.txtDtEndDate.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDtEndDate.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("txtDtEndDate.ClearButtonImage")));
            this.txtDtEndDate.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDtEndDate.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.txtDtEndDate.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.txtDtEndDate.ClearButtonText = "";
            this.txtDtEndDate.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDtEndDate.ClearButtonToolTip = "";
            this.txtDtEndDate.ClearButtonWidth = 17;
            this.txtDtEndDate.ClearDateTimeWhenDownDeleteKey = true;
            this.txtDtEndDate.CustomFormat = "";
            this.txtDtEndDate.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.txtDtEndDate.DropDownClosedWhenClickOnDays = false;
            this.txtDtEndDate.DropDownClosedWhenSelectedDateChanged = false;
            this.txtDtEndDate.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.txtDtEndDate.Format4Binding = "yyyy/MM/dd";
            this.txtDtEndDate.Location = new System.Drawing.Point(189, 174);
            this.txtDtEndDate.Name = "txtDtEndDate";
            this.txtDtEndDate.RightToLeftLayout = true;
            this.txtDtEndDate.ShowClearButton = false;
            this.txtDtEndDate.Size = new System.Drawing.Size(128, 21);
            this.txtDtEndDate.TabIndex = 7;
            this.txtDtEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtDtEndDate.TextWhenClearButtonClicked = "";
            this.txtDtEndDate.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.txtDtEndDate_SelectedDateChanged);
            // 
            // txtDtStartDate
            // 
            this.txtDtStartDate.AnchorSize = new System.Drawing.Size(128, 21);
            this.txtDtStartDate.BackColor = System.Drawing.Color.White;
            this.txtDtStartDate.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.txtDtStartDate.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.txtDtStartDate.CalendarDayRectTickness = 2F;
            this.txtDtStartDate.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.txtDtStartDate.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDtStartDate.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.txtDtStartDate.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.txtDtStartDate.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.txtDtStartDate.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.txtDtStartDate.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.txtDtStartDate.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.txtDtStartDate.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.txtDtStartDate.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.txtDtStartDate.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtDtStartDate.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtDtStartDate.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.txtDtStartDate.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.txtDtStartDate.CalendarShowToday = true;
            this.txtDtStartDate.CalendarShowTodayRect = true;
            this.txtDtStartDate.CalendarShowToolTips = false;
            this.txtDtStartDate.CalendarShowTrailing = true;
            this.txtDtStartDate.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.txtDtStartDate.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtDtStartDate.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.txtDtStartDate.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtDtStartDate.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.txtDtStartDate.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.txtDtStartDate.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.txtDtStartDate.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDtStartDate.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.txtDtStartDate.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.txtDtStartDate.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDtStartDate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.txtDtStartDate.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.txtDtStartDate.CalendarTodayRectTickness = 2F;
            this.txtDtStartDate.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.txtDtStartDate.CalendarType = BehComponents.CalendarTypes.Persian;
            this.txtDtStartDate.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.txtDtStartDate.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDtStartDate.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.txtDtStartDate.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.txtDtStartDate.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.txtDtStartDate.ClearButtonBackColor = System.Drawing.Color.White;
            this.txtDtStartDate.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDtStartDate.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("txtDtStartDate.ClearButtonImage")));
            this.txtDtStartDate.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDtStartDate.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.txtDtStartDate.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.txtDtStartDate.ClearButtonText = "";
            this.txtDtStartDate.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDtStartDate.ClearButtonToolTip = "";
            this.txtDtStartDate.ClearButtonWidth = 17;
            this.txtDtStartDate.ClearDateTimeWhenDownDeleteKey = true;
            this.txtDtStartDate.CustomFormat = "";
            this.txtDtStartDate.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.txtDtStartDate.DropDownClosedWhenClickOnDays = false;
            this.txtDtStartDate.DropDownClosedWhenSelectedDateChanged = false;
            this.txtDtStartDate.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.txtDtStartDate.Format4Binding = "yyyy/MM/dd";
            this.txtDtStartDate.Location = new System.Drawing.Point(190, 107);
            this.txtDtStartDate.Name = "txtDtStartDate";
            this.txtDtStartDate.RightToLeftLayout = true;
            this.txtDtStartDate.ShowClearButton = false;
            this.txtDtStartDate.Size = new System.Drawing.Size(128, 21);
            this.txtDtStartDate.TabIndex = 5;
            this.txtDtStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtDtStartDate.TextWhenClearButtonClicked = "";
            this.txtDtStartDate.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.txtDtStartDate_SelectedDateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تاریخ پایان سال تحصیلی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام سال تحصیلی :";
            // 
            // txtAcademyYearName
            // 
            this.txtAcademyYearName.Location = new System.Drawing.Point(48, 41);
            this.txtAcademyYearName.Name = "txtAcademyYearName";
            this.txtAcademyYearName.Size = new System.Drawing.Size(271, 21);
            this.txtAcademyYearName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAcademyYears);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 450);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست سال های تحصیلی ثبت شده";
            // 
            // dgvAcademyYears
            // 
            this.dgvAcademyYears.AllowUserToAddRows = false;
            this.dgvAcademyYears.AllowUserToDeleteRows = false;
            this.dgvAcademyYears.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcademyYears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademyYears.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AcademyYearId,
            this.AcademyYearName,
            this.StartDate,
            this.EndDate,
            this.NumberOfDaysOfYear});
            this.dgvAcademyYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAcademyYears.Location = new System.Drawing.Point(3, 17);
            this.dgvAcademyYears.Name = "dgvAcademyYears";
            this.dgvAcademyYears.ReadOnly = true;
            this.dgvAcademyYears.Size = new System.Drawing.Size(528, 430);
            this.dgvAcademyYears.TabIndex = 0;
            this.dgvAcademyYears.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcademyYears_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "تعداد روزهای سال تحصیلی :";
            // 
            // txtNumberOfDaysOfYear
            // 
            this.txtNumberOfDaysOfYear.Location = new System.Drawing.Point(46, 232);
            this.txtNumberOfDaysOfYear.Name = "txtNumberOfDaysOfYear";
            this.txtNumberOfDaysOfYear.ReadOnly = true;
            this.txtNumberOfDaysOfYear.Size = new System.Drawing.Size(271, 21);
            this.txtNumberOfDaysOfYear.TabIndex = 9;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtAcademyYearName;
            this.requiredFieldValidator1.ErrorMessage = "لطفا مقدار نام را وارد نمائید.این مورد الزامی میباشد.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtStartDateText;
            this.requiredFieldValidator2.ErrorMessage = "لطفا تاریخ شروع سال تحصیلی را از لیست بازشونده انتخاب نمایید.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtEndDateText;
            this.requiredFieldValidator3.ErrorMessage = "لطفا تاریخ پایان را از لیست باز شونده انتخاب نمائید.این مورد الزامی میباشد.";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txtNumberOfDaysOfYear;
            this.requiredFieldValidator4.ErrorMessage = "لطفا تاریخ شروع و پایان سال تحصیلی هر دومورد انتخاب گردد.";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // AcademyYearId
            // 
            this.AcademyYearId.DataPropertyName = "AcademyYearId";
            this.AcademyYearId.HeaderText = "کد سال تحصیلی";
            this.AcademyYearId.Name = "AcademyYearId";
            this.AcademyYearId.ReadOnly = true;
            this.AcademyYearId.Visible = false;
            // 
            // AcademyYearName
            // 
            this.AcademyYearName.DataPropertyName = "AcademyYearName";
            this.AcademyYearName.HeaderText = "نام سال تحصیلی";
            this.AcademyYearName.Name = "AcademyYearName";
            this.AcademyYearName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "تاریخ شروع سال تحصیلی";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "تاریخ پایان سال تحصیلی";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // NumberOfDaysOfYear
            // 
            this.NumberOfDaysOfYear.DataPropertyName = "NumberOfDaysOfYear";
            this.NumberOfDaysOfYear.HeaderText = "تعداد روزهای این سال تحصیلی";
            this.NumberOfDaysOfYear.Name = "NumberOfDaysOfYear";
            this.NumberOfDaysOfYear.ReadOnly = true;
            // 
            // AcademyYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AcademyYearForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت اطلاعات مربوط به سال تحصیلی جدید";
            this.Load += new System.EventHandler(this.AcademyYearForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademyYears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateSelectedAcademyYear;
        private System.Windows.Forms.Button btnDeleteSelectedAcademyYear;
        private System.Windows.Forms.Button btnAddNewAcademyYear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcademyYearName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndDateText;
        private System.Windows.Forms.TextBox txtStartDateText;
        private BehComponents.DateTimePickerX txtDtEndDate;
        private BehComponents.DateTimePickerX txtDtStartDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAcademyYears;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfDaysOfYear;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademyYearName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDaysOfYear;
    }
}