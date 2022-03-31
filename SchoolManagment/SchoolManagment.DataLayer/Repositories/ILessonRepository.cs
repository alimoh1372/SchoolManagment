using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagment.DataLayer.DatabaseModel;
using System.Data.Entity;
using System.Linq.Expressions;
using SchoolManagment.ViewModel;

namespace SchoolManagment.DataLayer
{
    public interface ILessonRepository:IBaseRepository<Lesson>
    {
        IEnumerable<LessonViewModel> FillViewModel();
        
    }
}
