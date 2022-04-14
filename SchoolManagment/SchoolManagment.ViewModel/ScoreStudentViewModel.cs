using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class ScoreStudentViewModel : StudentViewModel, IScoreStudentViewModel
    {
        public decimal ScoreOfLesson { get ; set ; }
    }
}
