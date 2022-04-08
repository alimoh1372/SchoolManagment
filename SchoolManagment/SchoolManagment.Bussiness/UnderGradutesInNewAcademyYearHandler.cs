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
    public class UnderGradutesInNewAcademyYearHandler : IUnderGradutesInNewAcademyYearHandler
    {
        private IEnumerable<UnderGradutesViewModel> underGradutesViewModels;
        private IEnumerable<UnderGradutesInNewAcademyYear> underGradutesInNewAcademyYears;
        public IEnumerable<UnderGradutesViewModel> GetUnderGradutesViewModels(int AcademyYearId)
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                underGradutesInNewAcademyYears = db.UnderGradutesInNewAcademyYearRepository.GetIncludeEntity(tac => tac.UnderGradute);
                underGradutesViewModels = underGradutesInNewAcademyYears.Where(tac => tac.FkAcademyYearId == AcademyYearId).Select(un => new UnderGradutesViewModel()
                {
                    PkUnGraduteId = un.UnderGradute.PkUnGraduteId,
                    FkGradeId = un.UnderGradute.FkGradeId,
                    FkGradeIdString = db.GradeRepository.GetNameById(un.UnderGradute.FkGradeId),
                    FkUnGradutePrequestis = un.UnderGradute.FkUnGradutePrequestis.GetValueOrDefault(),
                    FkUnGradutePrequestisString = db.UnderGraduteRepository.GetNameById(un.UnderGradute.FkUnGradutePrequestis.GetValueOrDefault()),
                    UnGraduteName = un.UnderGradute.UnGraduteName
                });
                return underGradutesViewModels.ToList();
                //underGradutesViewModels = db.UnderGraduteRepository.Get().Select(un => new UnderGradutesViewModel()
                //{
                //    PkUnGraduteId = un.PkUnGraduteId,
                //    FkGradeId = un.FkGradeId,
                //    FkGradeIdString = db.GradeRepository.GetNameById(un.FkGradeId),
                //    FkUnGradutePrequestis = un.FkUnGradutePrequestis.GetValueOrDefault(),
                //    FkUnGradutePrequestisString = db.UnderGraduteRepository.GetNameById(un.FkUnGradutePrequestis.GetValueOrDefault()),
                //    UnGraduteName = un.UnGraduteName
                //});
            }
        }
        public virtual int InsertUnGradeToAcademyYear(DataGridView AcademyDataGridView, DataGridView UnderGradutesDataGridView)
        {
            string attemMessage;
            int result = -1;
            if (AcademyDataGridView.CurrentCell != null && AcademyDataGridView.CurrentRow != null && AcademyDataGridView.SelectedCells.Count > 0)
            {
                if (UnderGradutesDataGridView.CurrentCell != null && UnderGradutesDataGridView.CurrentRow != null && UnderGradutesDataGridView.SelectedCells.Count > 0)
                {
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        int academyYearId = Convert.ToInt32(AcademyDataGridView.CurrentRow.Cells["AcademyYearId"].Value.ToString());
                        int unGraduteId = Convert.ToInt32(UnderGradutesDataGridView.CurrentRow.Cells["PkUnGraduteId"].Value.ToString());
                        if (!db.UnderGradutesInNewAcademyYearRepository.Get(una => una.FkAcademyYearId == academyYearId && una.FkUnGraduteId == unGraduteId).Any())
                        {


                            attemMessage = "آیا از افزودن زیر مقطع " + UnderGradutesDataGridView.CurrentRow.Cells[1].Value + "  به سال تحصیلی " + AcademyDataGridView.CurrentRow.Cells[1].Value + " اطمینان دارید؟";
                            if (RtlMessageBox.Show(attemMessage, "افزودن زیرمقطع", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                UnderGradutesInNewAcademyYear unGra = new UnderGradutesInNewAcademyYear()
                                {
                                    FkAcademyYearId = academyYearId,
                                    FkUnGraduteId = unGraduteId
                                };
                                db.UnderGradutesInNewAcademyYearRepository.Insert(unGra);
                                result = db.Save();
                                if (result <= 0)
                                {
                                    attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                    RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            attemMessage = "زیر مقطع مورد نظر در سال تحصیلی انتخاب شدده وجود دارد ثبت موارد تکراری امکان پذیر نیست. ";
                            RtlMessageBox.Show(attemMessage, "زیرمقطع تکراری در سال تحصیلی انتخاب شده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    attemMessage = "لطفا یک زیر مقطع جهت اضافه کردن انتخاب نمائید.";
                    RtlMessageBox.Show(attemMessage, "عدم انتخاب زیرمقطع", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                attemMessage = "لطفا یک سال تحصیلی جهت اضافه کردن انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب سال تحصیلی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }
        public int DeleteUnGradeFromAcademyYear(DataGridView AcademyDataGridView, DataGridView selectedUnGradutedDataGridView)
        {
            string attemMessage;
            int result = -1;
            if (AcademyDataGridView.CurrentCell != null && AcademyDataGridView.CurrentRow != null && AcademyDataGridView.SelectedCells.Count > 0)
            {
                if (selectedUnGradutedDataGridView.CurrentCell != null && selectedUnGradutedDataGridView.CurrentRow != null && selectedUnGradutedDataGridView.SelectedCells.Count > 0)
                {
                    using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                    {
                        int academyYearId = Convert.ToInt32(AcademyDataGridView.CurrentRow.Cells["AcademyYearId"].Value.ToString());
                        int unGraduteId = Convert.ToInt32(selectedUnGradutedDataGridView.CurrentRow.Cells["PkUnGraduteId1"].Value.ToString());
                        int PkUnderGradutesInNewAcademyYearId = db.UnderGradutesInNewAcademyYearRepository.GetIdByAcademyAndUngradutes(academyYearId, unGraduteId);
                        attemMessage = "آیا از حذف زیر مقطع " + selectedUnGradutedDataGridView.CurrentRow.Cells[1].Value + "  از سال تحصیلی " + AcademyDataGridView.CurrentRow.Cells[1].Value + " اطمینان دارید؟";
                        if (PkUnderGradutesInNewAcademyYearId>0 && RtlMessageBox.Show(attemMessage, "افزودن زیرمقطع", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.UnderGradutesInNewAcademyYearRepository.Delete(PkUnderGradutesInNewAcademyYearId);
                            result = db.Save();
                            if (result<=0)
                            {
                                attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                                RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    attemMessage = "لطفا یک زیر مقطع جهت حذف شدن از لیست پایین انتخاب نمائید.";
                    RtlMessageBox.Show(attemMessage, "عدم انتخاب زیرمقطع", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                attemMessage = "لطفا یک سال تحصیلی جهت اضافه کردن انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب سال تحصیلی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;

        }
        public void Dispose()
        {
            if (underGradutesViewModels != null)
            {
                underGradutesViewModels = null;
            }
            if (underGradutesInNewAcademyYears != null)
            {
                underGradutesInNewAcademyYears = null;
            }
        }


    }
}
