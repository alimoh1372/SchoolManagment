using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
   public class GradeGridViewModel : IGradeGridViewModel
    {
        public int PkGradeId { get ; set ; }
        public int FkGradePrequiestis { get; set; }
        public string FkGradePrequiestisString { get; set ; }
        public string GradeName { get ; set ; }
        
        
    }
}
