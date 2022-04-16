using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;


namespace SchoolManagment.Bussiness
{
    public class CalenderHandler : ICalenderHandler
    {
        private IEnumerable<Calender> _calenders;
        private IEnumerable<CalenderViewModel> _calenderViewModels;
        private int result = -1;


        public IEnumerable<Calender> GetCalenders()
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                _calenders = db.CalenderRepository.Get();
                return _calenders;
            }

        }
        public IEnumerable<Calender> GetCalendersWithIncludes()
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                _calenders = db.CalenderRepository.GetWithIncludes();
                return _calenders.ToList();
            }

        }
        public IEnumerable<CalenderViewModel> GetCalenderAndFillViewModel()
        {
            if (_calenders == null)
            {
                _calenders = GetCalendersWithIncludes();
                _calenderViewModels = _calenders.Select(c => new CalenderViewModel()
                {
                    CalenderId = c.CalenderId,
                    CalenderName = c.CalenderName,
                    CalenderDescription = c.CalenderDescription,
                    FkDayAlterNate = c.FkDayAlterNate,
                    FkDayAlterNateString = c.DayAlternate.DayAlternateDescription + " ها",
                    FkTimeAlterNateId = c.FkTimeAlterNateId,
                    FkTimeAlterNateIdString = "از ساعت" + c.TimeAlterNate.FromTime.ToString(@"hh\:mm") + "  تا ساعت " + c.TimeAlterNate.ToTime.ToString(@"hh\:mm")
                });

            }
            return _calenderViewModels;

        }

        public int InsertCalenderInfo(ComboBox txtDayAlternate, ComboBox txtTimeAlternate, TextBox txtCalenderName, TextBox txtCalenderDescription)
        {
            string attemMessage;

            Calender calender = new Calender();
            if (txtCalenderName.Text != string.Empty)
            {
                calender.CalenderName = txtCalenderName.Text;
                if (txtCalenderDescription.Text != string.Empty)
                {
                    calender.CalenderDescription = txtCalenderDescription.Text;
                }
                if (txtDayAlternate.SelectedIndex > -1)
                {
                    calender.FkDayAlterNate = Convert.ToByte(txtDayAlternate.SelectedValue.ToString());
                    if (txtTimeAlternate.SelectedIndex > -1)
                    {
                        calender.FkTimeAlterNateId = Convert.ToByte(txtTimeAlternate.SelectedValue.ToString());
                        attemMessage = "ایا از افزودن تقویم با مشخصات زیر مطمئن هستید؟" + "\n" +
                                             "نام تقویم :" + calender.CalenderName + "\n" +
                                             "توضیحات تقویم :" + calender.CalenderDescription + "\n" +
                                                "گردش روز :" + txtDayAlternate.Text + "\n" +
                                                "زمان  :" + txtTimeAlternate.Text + "\n";
                        if (RtlMessageBox.Show(attemMessage, "افزودن تقویم جدید", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                            {

                                if (!db.CalenderRepository.Get(c => c.FkDayAlterNate == calender.FkDayAlterNate && c.FkTimeAlterNateId == calender.FkTimeAlterNateId).Any())
                                {
                                    db.CalenderRepository.Insert(calender);
                                    result = db.Save();
                                    if (result <= 0)
                                    {
                                        attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                        RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                else
                                {
                                    result = 0;
                                    attemMessage = "تقویم از قبل در لیست تقویم ها موجود میباشد(تکراری)";
                                    RtlMessageBox.Show(attemMessage, "عدم امکان ثبت تقویم تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        attemMessage = "لطفا زمان را انتخاب نمایئد. .";
                        RtlMessageBox.Show(attemMessage, "عدم ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    attemMessage = "لطفا گردش روز(انتخاب روز هفته یا روز ماه)را انتخاب نمایئد. .";
                    RtlMessageBox.Show(attemMessage, "عدم ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                attemMessage = "لطفا نام تقویم وارد شود.";
                RtlMessageBox.Show(attemMessage, "عدم ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;

        }
        public int DeleteCalender(DataGridViewRow dataGridViewRow)
        {
            string attemMessage;

            attemMessage = "آیا از حذف تقویم با مشخصات زیر مطمئن هستید؟" + "\n" +
                       "نام تقویم:" + dataGridViewRow.Cells["CalenderName"].Value.ToString() + "\n" +
                        "توضیحات تقویم :" + dataGridViewRow.Cells["CalenderDescription"].Value.ToString() + "\n" +
                        "گردش روز :" + dataGridViewRow.Cells["FkDayAlterNateString"].Value.ToString() + "\n" +
                       "زمان :" + dataGridViewRow.Cells["FkTimeAlterNateIdString"].Value.ToString();
            if (RtlMessageBox.Show(attemMessage, "حذف تقویم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    db.CalenderRepository.Delete(Convert.ToInt32(dataGridViewRow.Cells["CalenderId"].Value.ToString()));
                    result = db.Save();
                    if (result <= 0)
                    {
                        attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                        RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return result;

        }
        public int UpdateCalender(DataGridViewRow dataGridViewRow, ComboBox txtDayAlternate, ComboBox txtTimeAlternate, TextBox ctxtCalenderName, TextBox txtCalenderDescription)
        {
            string attemMessage;
            string oldCalName;
            string oldCalDesc;
            string oldCalDayAlterNate;
            string oldCalTimeAlterNate;

            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                Calender calender = db.CalenderRepository.GetById(Convert.ToInt32(dataGridViewRow.Cells["CalenderId"].Value.ToString()));
                oldCalName = calender.CalenderName;
                oldCalDesc = calender.CalenderName;
                oldCalDayAlterNate = dataGridViewRow.Cells["FkDayAlterNateString"].Value.ToString();
                oldCalTimeAlterNate = dataGridViewRow.Cells["FkTimeAlterNateIdString"].Value.ToString();
                if (ctxtCalenderName.Text != string.Empty)
                {
                    calender.CalenderName = ctxtCalenderName.Text;
                    if (txtCalenderDescription.Text != string.Empty)
                    {
                        calender.CalenderDescription = txtCalenderDescription.Text;
                    }
                    if (txtDayAlternate.SelectedIndex > -1)
                    {
                        calender.FkDayAlterNate = Convert.ToByte(txtDayAlternate.SelectedValue.ToString());
                        if (txtTimeAlternate.SelectedIndex > -1)
                        {
                            calender.FkTimeAlterNateId = Convert.ToByte(txtTimeAlternate.SelectedValue.ToString());
                            attemMessage = "ایا از ثبت تغییرات تقویم به صورت زیر مطمئن هستید؟" + "\n" +
                                            oldCalName + "====>" + calender.CalenderName + "\n" +
                                           oldCalDesc + "====>" + calender.CalenderDescription + "\n" +
                                               oldCalDayAlterNate + "====>" + txtDayAlternate.Text + "\n" +
                                               oldCalTimeAlterNate + "====>" + txtTimeAlternate.Text + "\n";

                            if (RtlMessageBox.Show(attemMessage, "اطمینان از ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                db.CalenderRepository.Update(calender);
                                result = db.Save();
                                if (result < 0)
                                {
                                    attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                    RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        else
                        {
                            attemMessage = "لطفا زمان را انتخاب نمایئد. .";
                            RtlMessageBox.Show(attemMessage, "عدم ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        attemMessage = "لطفا گردش روز(انتخاب روز هفته یا روز ماه)را انتخاب نمایئد. .";
                        RtlMessageBox.Show(attemMessage, "عدم ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    attemMessage = "لطفا نام تقویم وارد شود.";
                    RtlMessageBox.Show(attemMessage, "عدم ورود اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result;

        }
        public List<DaysListForCalender> GenerateDayList(int calenderId,int academyYearId)
        {
            int dayAlterNate;
            DateTime startDateTime;
            DateTime endDateTime;
            DateTime _renderDate;
            Calender calenderEntity;
            List<DaysListForCalender> days=new List<DaysListForCalender>();
            DaysListForCalender daysListForCalenderEntity;
            DayOfWeek dayOfWeek;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                calenderEntity = db.CalenderRepository.GetById(calenderId);
                AcademyYear academyYear = db.AcademyYearRepository.GetById(academyYearId);
                startDateTime = academyYear.StartDate;
                endDateTime = academyYear.EndDate;
                _renderDate = startDateTime;
                if (calenderEntity.DayAlternate.FkTypeDay == 1)
                {
                    dayAlterNate = calenderEntity.DayAlternate.PkDayAlternateId - 1;
                    switch (dayAlterNate)
                    {
                        case 0:
                            dayOfWeek = DayOfWeek.Saturday;
                            break;
                        case 1:
                            dayOfWeek = DayOfWeek.Sunday;
                            break;
                        case 2:
                            dayOfWeek = DayOfWeek.Monday;
                            break;
                        case 3:
                            dayOfWeek = DayOfWeek.Tuesday;
                            break;
                        case 4:
                            dayOfWeek = DayOfWeek.Wednesday;
                            break;
                        case 5:
                            dayOfWeek = DayOfWeek.Thursday;
                            break;
                        default :
                            dayOfWeek = DayOfWeek.Friday;
                            break;
                    }
                    if (_renderDate.DayOfWeek == dayOfWeek)
                    {
                        daysListForCalenderEntity = new DaysListForCalender()
                        {
                            dateTime = _renderDate
                        };
                    }
                    else
                    {
                        while (_renderDate.DayOfWeek != dayOfWeek)
                        {
                            _renderDate = _renderDate.AddDays(1);
                        }
                        daysListForCalenderEntity = new DaysListForCalender()
                        {
                            dateTime = _renderDate
                        };
                    }
                    
                   
                    days.Add(daysListForCalenderEntity);
                    while (_renderDate <= endDateTime)
                    {
                        _renderDate = _renderDate.AddDays(7);
                        daysListForCalenderEntity = new DaysListForCalender()
                        {
                            dateTime = _renderDate
                        };
                        days.Add(daysListForCalenderEntity);
                    }
                }
                else
                {
                    dayAlterNate = calenderEntity.DayAlternate.PkDayAlternateId - 8;
                    if (_renderDate.Day == dayAlterNate)
                    {
                        daysListForCalenderEntity = new DaysListForCalender()
                        {
                            dateTime = _renderDate
                        };
                    }
                    else
                    {
                        while (_renderDate.Day != dayAlterNate)
                        {
                            _renderDate = _renderDate.AddDays(1);
                        }
                        daysListForCalenderEntity = new DaysListForCalender()
                        {
                            dateTime = _renderDate
                        };
                    }
                    
                     
                    days.Add(daysListForCalenderEntity);
                    while (_renderDate <= endDateTime)
                    {
                        _renderDate = _renderDate.AddDays(dayAlterNate);
                        if (_renderDate <= endDateTime)
                        {
                            daysListForCalenderEntity = new DaysListForCalender()
                            {
                                dateTime = _renderDate
                            };
                            days.Add(daysListForCalenderEntity);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return days;
        }
        public void Dispose()
        {
            if (_calenders != null)
            {
                _calenders = null;
            }
            if (_calenderViewModels != null)
            {
                _calenderViewModels = null;
            }
        }


    }
}
