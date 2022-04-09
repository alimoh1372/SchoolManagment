using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public class LessonsOfFileldsOfNewYearInUngradeHandler : ILessonsOfFileldsOfNewYearInUngradeHandler
    {
        IEnumerable<FieldsOfNewYearInUnGradutesViewModel> fieldsOfNewYearInUnGradutesViewModels;
        
        public virtual IEnumerable<FieldsOfNewYearInUnGradutesViewModel> FillFieldOfNewYearInUngradeViewModels(Expression<Func<FieldsOfNewYearInUnGradutesViewModel, bool>> where = null)
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                IEnumerable<FieldsOfNewYearInUnGradute> fieldsOfNewYearInUnGradutes = db.FieldsOfNewYearInUnGradutesRepository.GetIncludeEntities(fi=>fi.Field,fi=>fi.UnderGradutesInNewAcademyYear.UnderGradute,fi=>fi.UnderGradutesInNewAcademyYear.AcademyYear).AsQueryable();

                if (where == null)
                {

                    fieldsOfNewYearInUnGradutesViewModels = fieldsOfNewYearInUnGradutes.Select( fi=>new FieldsOfNewYearInUnGradutesViewModel()
                    {
                        AcademyYearId=fi.UnderGradutesInNewAcademyYear.FkAcademyYearId,
                        AcademyYearString=fi.UnderGradutesInNewAcademyYear.AcademyYear.AcademyYearName,
                        FkUnderGraduteInAcademyYearId=fi.UnderGradutesInNewAcademyYear.FkUnGraduteId,
                        FkUnderGraduteInAcademyYearIdString=fi.UnderGradutesInNewAcademyYear.UnderGradute.UnGraduteName+" "+ fi.UnderGradutesInNewAcademyYear.UnderGradute.Grade.GradeName,
                        FkFieldsOfNewYearInUnGradutesId=fi.FkFieldId,
                        FkFieldsOfNewYearInUnGradutesIdString=fi.Field.FieldName
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
        public void Dispose()
        {
            if (fieldsOfNewYearInUnGradutesViewModels!=null)
            {
                fieldsOfNewYearInUnGradutesViewModels = null;
            }
        }

    }
}
