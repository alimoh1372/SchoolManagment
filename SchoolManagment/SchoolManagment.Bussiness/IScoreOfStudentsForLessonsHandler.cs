﻿using SchoolManagment.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.Bussiness
{
   public interface IScoreOfStudentsForLessonsHandler:IDisposable
    {
        IEnumerable<ITeacherMenoAllLessonsClassViewModel> GetAllLessonClassWithPresentForeignKey();
    }
}
