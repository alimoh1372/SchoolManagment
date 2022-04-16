using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public class StudenPresentDetailHandler : IStudenPresentDetailHandler
    {
        public IList<DaysListForCalender> GetDaysListViewModel(DataGridView dgvNewAcademyYearAllLessons)
        {
            IList<DaysListForCalender> daysListForCalenders;
            int calenderId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkCalenderId"].Value);
            int academyYearId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["AcademyYearId"].Value);
            using (CalenderHandler calenderHandler = new CalenderHandler())
            {
                daysListForCalenders = calenderHandler.GenerateDayList(calenderId, academyYearId);
            }
            return daysListForCalenders;
        }
        public bool IsExistedStudentInStudentPresentDetailTable(int PkStudentPresents, DateTime presentDetailDate)
        {
            bool isExisted = false;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {

                isExisted = db.StudenPresentDetailRepository.Get(st => st.FkStudentPresents == PkStudentPresents && st.DataOfDay == presentDetailDate).Any();
            }
            return isExisted;
        }
        public IEnumerable<IStudenPresentDetailViewModel> GetStudentPresentDetailViewModel(DataGridView dgvNewAcademyYearAllLessons, ComboBox cmbxDateList)
        {
            IEnumerable<IStudenPresentDetailViewModel> studentPresentViewModels = null;
            var a = cmbxDateList.SelectedValue;
            DateTime presentsDetailDate = Convert.ToDateTime(a);
            int pkTeacherTeachLessonAccToCalInClassId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["PkTeacherTeachLessonAccToCalInClassId"].Value);
            int fkLastPassedUgraduteId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkUnGraduteId"].Value);
            string fkLastPassedUgraduteIdString = dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkUnGraduteIdString"].Value.ToString();
            int fkStudentFieldId = Convert.ToInt32(dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkFieldId"].Value);
            string fkStudentFieldIdString = dgvNewAcademyYearAllLessons.CurrentRow.Cells["FkFieldIdString"].Value.ToString();
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                studentPresentViewModels = db.StudentPresentsRepository.Get(sc => sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.FkTeacherTeachLessonAccToCalenderInClass == pkTeacherTeachLessonAccToCalInClassId)
                    .Select(sc => new StudenPresentDetailViewModel()
                    {
                        checkboxSelectStudent = !IsExistedStudentInStudentPresentDetailTable(sc.PkStudentPresents, presentsDetailDate),
                        PkStudentPresents = sc.PkStudentPresents,
                        FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId = sc.FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId,
                        StudentId = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.FkStudentId,
                        StudentName = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.Student.StudentName,
                        StudentNationCode = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.Student.StudentNationCode,
                        FkLastPassedUgraduteId = (int?)fkLastPassedUgraduteId,
                        FkLastPassedUgraduteIdString = fkLastPassedUgraduteIdString,
                        FkStudentFieldId = fkStudentFieldId,
                        FkStudentFieldIdString = fkStudentFieldIdString
                    }
                    ).ToList();
                //studentPresentViewModels = db.StudenPresentDetailRepository.Get(sc => sc.StudentPresent./*== pkTeacherTeachLessonAccToCalInClassId*/)
                //      .Select(sc => new ScoreStudentViewModel()
                //      {
                //          checkboxSelectStudent = true,
                //          PkScoreOfStudentsForLessons = sc.PkScoreOfStudentsForLessons,
                //          ScoreOfLesson = sc.ScoreOfLesson,
                //          StudentId = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.FkStudentId,
                //          StudentName = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.Student.StudentName,
                //          StudentNationCode = sc.StudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClass.Student.StudentNationCode,
                //          FkLastPassedUgraduteId = (int?)fkLastPassedUgraduteId,
                //          FkLastPassedUgraduteIdString = fkLastPassedUgraduteIdString,
                //          FkStudentFieldId = fkStudentFieldId,
                //          FkStudentFieldIdString = fkStudentFieldIdString
                //      }).ToList();
            }
            return studentPresentViewModels;
        }

        public bool SyncTheStudentDgvWithDataBase(DataGridView dgvStudent, ComboBox cmbxDateList)
        {
            bool result = false;
            int numberOfChangeDb = -1;
            int resultNumberChange = -1;
            string attempMessage;
            int PkStudentPresents;
            DateTime studentPresentDetailDate = Convert.ToDateTime(cmbxDateList.SelectedValue);

            UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities());
            StudenPresentDetail studentPresentDetailEntity;
            List<StudenPresentDetail> _needToInsertStudentDataBase = new List<StudenPresentDetail>();
            List<StudenPresentDetail> _needToDeleteStudentDataBase = new List<StudenPresentDetail>();
            if (dgvStudent.DataSource != null)
            {
                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    PkStudentPresents = Convert.ToInt32(row.Cells["PkStudentPresents"].Value);
                    bool isExistedStudentInStudentPresentDetailInDataBase = IsExistedStudentInStudentPresentDetailTable(PkStudentPresents, studentPresentDetailDate);
                    bool isInDgvStudentchecked = Convert.ToBoolean(row.Cells["checkboxSelectStudent"].Value);
                    if (isExistedStudentInStudentPresentDetailInDataBase == false && isInDgvStudentchecked == false)
                    {
                        //Insert Into StudentPresentDetail
                        studentPresentDetailEntity = new StudenPresentDetail()
                        {
                            FkStudentPresents = PkStudentPresents,
                            DataOfDay = studentPresentDetailDate
                        };
                        _needToInsertStudentDataBase.Add(studentPresentDetailEntity);
                    }
                    else if (isExistedStudentInStudentPresentDetailInDataBase == true && isInDgvStudentchecked == true)
                    {
                        //Delete From StudentPresentDetail
                        studentPresentDetailEntity = db.StudenPresentDetailRepository.Get(st => st.FkStudentPresents == PkStudentPresents && st.DataOfDay == studentPresentDetailDate).First();
                        _needToDeleteStudentDataBase.Add(studentPresentDetailEntity);
                    }
                    //else
                    ///*isExistedStudentInStudentPresentDetailInDataBase == false && isInDgvStudentchecked == true*/
                    ///*isExistedStudentInStudentPresentDetailInDataBase == false && isInDgvStudentchecked == false*/
                    //{

                    //}
                }
            }
            else
            {
                attempMessage = "جهت ثبت تغییرات در لیست حضور غیاب لطفا یک درس از لیست درس ها و تاریخ مورد نظر از لیست بازشونده انتخاب گردد. ";
                RtlMessageBox.Show(attempMessage, " عدم انتخاب کلاس درس و تاریخ");
            }
            resultNumberChange = _needToDeleteStudentDataBase.Count + _needToInsertStudentDataBase.Count;
            if (resultNumberChange>0)
            {
                attempMessage = "آیا از ثبت تغییرات به تعداد " + resultNumberChange+ " مطمئن هستید؟";
                if (RtlMessageBox.Show(attempMessage, "اطمینان از ثبت تغییرات حضور غیاب", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //delete From studentPresentDetail 
                    foreach (StudenPresentDetail studenPresentDetail in _needToDeleteStudentDataBase)
                    {
                        db.StudenPresentDetailRepository.Delete(studenPresentDetail);
                    }
                    //Insert Into StudentPresentDetail Table
                    foreach (StudenPresentDetail studenPresentDetail in _needToInsertStudentDataBase)
                    {
                        db.StudenPresentDetailRepository.Insert(studenPresentDetail);
                    }
                }
                numberOfChangeDb = db.Save();
                if (numberOfChangeDb == resultNumberChange)
                {
                    result = true;
                }
                else
                {
                    attempMessage = "مشکلی در ثبت تغییرات در دیتابیس رخ داده است.لطفا بعدا متحان کنید یا با ادمین خود تماس بگیرید.";
                    RtlMessageBox.Show(attempMessage, "خطا در دیتابیس");
                }
                db.Dispose();
            }
            else
            {
                attempMessage = "تغییری در لیست حضور غیاب وجود ندارد لطفا پس از اطمینان مجددا امتحان نمائید.";
                RtlMessageBox.Show(attempMessage, " عدم تغییر در لیست");
            }
            
            return result;
        }
        public void Dispose()
        {

        }
    }
}
