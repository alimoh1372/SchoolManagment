using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public interface IGradeGridViewModel
    {
         int PkGradeId { get; set; }
         
        int FkGradePrequiestis { get; set; }

         string FkGradePrequiestisString { get; set; }

        string GradeName { get; set; }
    }
}
