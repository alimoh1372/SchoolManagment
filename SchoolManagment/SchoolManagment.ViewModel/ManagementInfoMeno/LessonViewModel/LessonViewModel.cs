using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class LessonViewModel : ILessonViewModel
    {
        public int PKLessonId { get ; set ; }
        public string LessonName { get ; set ; }
        public int LessonUnits { get ; set ; }
        public int ? FkFileldId { get ; set ; }
        public string FkFileldIdString { get ; set; }
    }
}
