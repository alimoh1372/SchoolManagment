using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public class LessonsOfFileldsOfNewYearInUngradeHandler : ILessonsOfFileldsOfNewYearInUngradeHandler
    {
        IEnumerable<FieldsOfNewYearInUnGradutesViewModel> fieldsOfNewYearInUnGradutesViewModels;
        IEnumerable<LessonViewModel> lessonViewModels;
        public virtual IEnumerable<FieldsOfNewYearInUnGradutesViewModel> FillFieldOfNewYearInUngradeViewModels(Expression<Func<FieldsOfNewYearInUnGradutesViewModel, bool>> where = null)
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                IEnumerable<FieldsOfNewYearInUnGradute> fieldsOfNewYearInUnGradutes = db.FieldsOfNewYearInUnGradutesRepository.GetIncludeEntities(fi => fi.Field, fi => fi.UnderGradutesInNewAcademyYear.UnderGradute, fi => fi.UnderGradutesInNewAcademyYear.AcademyYear).AsQueryable();

                if (where == null)
                {

                    fieldsOfNewYearInUnGradutesViewModels = fieldsOfNewYearInUnGradutes.Select(fi => new FieldsOfNewYearInUnGradutesViewModel()
                    {
                        AcademyYearId = fi.UnderGradutesInNewAcademyYear.FkAcademyYearId,
                        AcademyYearString = fi.UnderGradutesInNewAcademyYear.AcademyYear.AcademyYearName,
                        FkUnderGraduteInAcademyYearId = fi.UnderGradutesInNewAcademyYear.FkUnGraduteId,
                        FkUnderGraduteInAcademyYearIdString = fi.UnderGradutesInNewAcademyYear.UnderGradute.UnGraduteName + " " + fi.UnderGradutesInNewAcademyYear.UnderGradute.Grade.GradeName,
                        FkFieldsOfNewYearInUnGradutesId = fi.FkFieldId,
                        FkFieldsOfNewYearInUnGradutesIdString = fi.Field.FieldName
                    }).ToList();
                }
                else
                {
                    fieldsOfNewYearInUnGradutesViewModels = fieldsOfNewYearInUnGradutes
                        .Select(fi => new FieldsOfNewYearInUnGradutesViewModel()
                        {
                            AcademyYearId = fi.UnderGradutesInNewAcademyYear.FkAcademyYearId,
                            AcademyYearString = fi.UnderGradutesInNewAcademyYear.AcademyYear.AcademyYearName,
                            FkUnderGraduteInAcademyYearId = fi.UnderGradutesInNewAcademyYear.FkUnGraduteId,
                            FkUnderGraduteInAcademyYearIdString = fi.UnderGradutesInNewAcademyYear.UnderGradute.UnGraduteName + " " + fi.UnderGradutesInNewAcademyYear.UnderGradute.Grade.GradeName,
                            FkFieldsOfNewYearInUnGradutesId = fi.FkFieldId,
                            FkFieldsOfNewYearInUnGradutesIdString = fi.Field.FieldName
                        }).AsQueryable().Where(where).ToList();

                }
                return fieldsOfNewYearInUnGradutesViewModels;
            }

        }
        public IEnumerable<LessonViewModel> FillLessonViewModel(Expression<Func<LessonViewModel, bool>> where = null)
        {

            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                if (where == null)
                {
                    lessonViewModels = db.LessonRepository.FillViewModel().ToList();
                }
                else
                {
                    lessonViewModels = db.LessonRepository.FillViewModel().AsQueryable().Where(where).ToList();
                }
            }
            return lessonViewModels;
        }
        public void Dispose()
        {
            if (fieldsOfNewYearInUnGradutesViewModels != null)
            {
                fieldsOfNewYearInUnGradutesViewModels = null;
            }
            if (lessonViewModels != null)
            {
                lessonViewModels = null;
            }
        }

        public IEnumerable<LessonViewModel> FillSelectedLessonViewModel(DataGridView dgvNewAcademyYearAllField)
        {

            IEnumerable<LessonsOfFileldsOfNewYearInUngrade> lessonsOfFileldsOfNewYearInUngrades;
            IEnumerable<LessonViewModel> lessonViewModels;
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                int FkFieldOfNewYearInUnGraduteId = Convert.ToInt32(dgvNewAcademyYearAllField.CurrentRow.Cells[0].Value.ToString());
                lessonsOfFileldsOfNewYearInUngrades = db.LessonsOfFileldsOfNewYearInUngradeRepository.GetIncludeEntities(ls => ls.Lesson)
                      .Where(ls => ls.FkFieldOfNewYearInUnGraduteId == FkFieldOfNewYearInUnGraduteId);
                string FileldIdString = dgvNewAcademyYearAllField.CurrentRow.Cells[1].Value.ToString();
                lessonViewModels = lessonsOfFileldsOfNewYearInUngrades.Select(ls => new LessonViewModel()
                {
                    FkFileldId = ls.Lesson.FkFileldId,
                    FkFileldIdString = FileldIdString,
                    LessonName = ls.Lesson.LessonName,
                    LessonUnits=ls.Lesson.LessonUnits,
                    PKLessonId=ls.Lesson.PKLessonId
                });
                return lessonViewModels.ToList();
            }
        }
    }
}
