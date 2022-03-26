using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class FieldViewModel : IFieldViewModel
    {
        public int PkFieldId { get ; set ; }
        public string FieldName { get ; set; }
        public int FKUnGraduteId { get ; set ; }
        public string FKUnGraduteIdString { get ; set; }
    }
}
