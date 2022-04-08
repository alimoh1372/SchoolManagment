using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer;
using SchoolManagment.DataLayer.DatabaseModel;
using SchoolManagment.ViewModel;

namespace SchoolManagment.Bussiness
{
    public class TimeAlterNateHandler : ITimeAlterNateHandler
    {
       private IEnumerable<TimeAlterNate> timeAlterNates;
       private IEnumerable<TimeAlterNateViewModel> timeAlterNateViewModels;

        public IEnumerable<TimeAlterNate> GetTimeAlterNates()
        {
            using (UnitOfWork db = new UnitOfWork(new SchoolManagmentEntities()))
            {
                timeAlterNates = db.TimeAlterNateRepository.Get();
                
            }
            return timeAlterNates;
        }
        public IEnumerable<TimeAlterNateViewModel> GetAndFillViewModel()
        {

            timeAlterNateViewModels = GetTimeAlterNates().Select(ta => new TimeAlterNateViewModel()
            {
                PkTimeId=ta.PkTimeId,
                timeFromToTime="از ساعت "+ta.FromTime.ToString(@"hh\:mm")+" تا ساعت "+ta.ToTime.ToString(@"hh\:mm")
            });
            return timeAlterNateViewModels;
        }

        public void Dispose()
        {
            if (timeAlterNates != null)
            {
                timeAlterNates = null;
            }
            if (timeAlterNateViewModels!=null)
            {
                timeAlterNateViewModels = null;
            }
        }
    }
}
