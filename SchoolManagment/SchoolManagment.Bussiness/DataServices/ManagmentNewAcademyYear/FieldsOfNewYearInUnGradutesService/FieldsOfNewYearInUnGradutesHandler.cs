using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment.Bussiness
{
    public class FieldsOfNewYearInUnGradutesHandler : IFieldsOfNewYearInUnGradutesHandler
    {


        public int InsertFieldToUngraduteInNewYear(DataGridView academyDataGridView, DataGridView dgvSelectedUnGradeInNewYear, DataGridView dgvFields)
        {
            int result = -1;
            string attemMessage;
            if (dgvFields.CurrentCell != null && dgvFields.CurrentRow != null && dgvFields.SelectedCells.Count > 0)
            {
                int academyYearId = Convert.ToInt32(academyDataGridView.CurrentRow.Cells[0].Value.ToString());
                int unGradeId = Convert.ToInt32(dgvSelectedUnGradeInNewYear.CurrentRow.Cells[0].Value.ToString());
                int fieldId = Convert.ToInt32(dgvFields.CurrentRow.Cells[0].Value.ToString());
                int pkUnGradutesInNewYearId;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    pkUnGradutesInNewYearId = db.UnderGradutesInNewAcademyYearRepository.GetIdByAcademyAndUngradutes(academyYearId, unGradeId);
                    int pkFieldInUndergraduteInNewYear = GetIdByFieldIdAndUnGraduteInNewYearId(fieldId, pkUnGradutesInNewYearId);
                    if (pkFieldInUndergraduteInNewYear<=0)
                    {


                        attemMessage = "آیا از افزودن رشته " + dgvFields.CurrentRow.Cells[2].Value + "  به زیرمقطع " + dgvSelectedUnGradeInNewYear.CurrentRow.Cells[1].Value + " اطمینان دارید؟";
                        if (RtlMessageBox.Show(attemMessage, "افزودن رشته", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                                FieldsOfNewYearInUnGradute fieldsOfNewYearInUnGradute = new FieldsOfNewYearInUnGradute()
                                {
                                    FkFieldId = fieldId,
                                    FkUnGradutesInNewYearId = pkUnGradutesInNewYearId
                                };

                                db.FieldsOfNewYearInUnGradutesRepository.Insert(fieldsOfNewYearInUnGradute);
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
                        attemMessage = "عدم امکان افزودن رشته تکراری به زیر مقطع.";
                        RtlMessageBox.Show(attemMessage, "عدم امکان افزودن رشته تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                attemMessage = "عدم انتخاب یک رشته.از لیست بالا(برای نمایش لیست ها ابتدا سال تحصیلی سپس زیرمقطع و پس از آن رشته ی مورد نظر را انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب رشته" +
                    " ");
            }
            return result;
        }
        public int DeleteFieldFromUnGraduteInNewYear(DataGridView academyDataGridView, DataGridView dgvSelectedUnGradeInNewYear, DataGridView dgvSelectedFields)
        {
            int result = -1;
            string attemMessage;
            if (dgvSelectedFields.CurrentCell != null && dgvSelectedFields.CurrentRow != null && dgvSelectedFields.SelectedCells.Count > 0)
            {
                int academyYearId = Convert.ToInt32(academyDataGridView.CurrentRow.Cells[0].Value.ToString());
                int unGradeId = Convert.ToInt32(dgvSelectedUnGradeInNewYear.CurrentRow.Cells[0].Value.ToString());
                int fieldId = Convert.ToInt32(dgvSelectedFields.CurrentRow.Cells[0].Value.ToString());
                int pkUnGradutesInNewYearId;
                int pkFielInUn;
                using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
                {
                    attemMessage = "آیا از حذف رشته " + dgvSelectedFields.CurrentRow.Cells[2].Value + "  از زیرمقطع " + dgvSelectedUnGradeInNewYear.CurrentRow.Cells[1].Value + " اطمینان دارید؟";
                    if (RtlMessageBox.Show(attemMessage, "افزودن رشته", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pkUnGradutesInNewYearId = db.UnderGradutesInNewAcademyYearRepository.GetIdByAcademyAndUngradutes(academyYearId, unGradeId);

                        pkFielInUn = db.FieldsOfNewYearInUnGradutesRepository.GetIdByFieldIdAndUnGradutesInNewYearId(fieldId, pkUnGradutesInNewYearId);
                        db.FieldsOfNewYearInUnGradutesRepository.Delete(pkFielInUn);
                        result = db.Save();
                        if (result <= 0)
                        {
                            attemMessage = "خطا در ثبت عملیات در پایگاه داده.لطفا مجددا تلاش فرمائید یا با ادمین خود تماس حاصل فرمایئد.با تشکر";
                            RtlMessageBox.Show(attemMessage, "خطای پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                
            }
            else
            {
                attemMessage = "عدم انتخاب یک رشته.از لیست پایین(برای نمایش لیست ها ابتدا سال تحصیلی سپس زیرمقطع و پس از آن رشته ی مورد نظر  را انتخاب نمائید.";
                RtlMessageBox.Show(attemMessage, "عدم انتخاب رشته", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }
        public int GetIdByFieldIdAndUnGraduteInNewYearId(int fieldId, int unGruduteInNewYear)
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                return db.FieldsOfNewYearInUnGradutesRepository.GetIdByFieldIdAndUnGradutesInNewYearId(fieldId, unGruduteInNewYear);
            }
        }
        public void Dispose()
        {

        }


    }
}
