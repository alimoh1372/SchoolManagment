using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class UnderGradutesViewModel : IUnderGradutesViewModel
    {
        public int PkUnGraduteId { get; set; }
        public int? FkUnGradutePrequestis
        {
            get; set;
        }
        public string FkUnGradutePrequestisString { get; set; }
        public int FkGradeId { get; set; }
        public string FkGradeIdString { get; set; }
        public string UnGraduteName { get; set; }
        
    }
}
