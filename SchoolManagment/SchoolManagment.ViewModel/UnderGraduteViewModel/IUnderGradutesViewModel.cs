using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public interface IUnderGradutesViewModel
    {
         int PkUnGraduteId { get; set; }

        int ? FkUnGradutePrequestis { get; set; }

        string FkUnGradutePrequestisString { get; set; }

        int FkGradeId { get; set; }

        string FkGradeIdString { get; set; }

        string UnGraduteName { get; set; }
    }
}
