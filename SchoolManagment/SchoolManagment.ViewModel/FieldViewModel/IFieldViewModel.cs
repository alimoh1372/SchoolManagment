using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
     public interface IFieldViewModel
    {
        int PkFieldId { get; set; }
        string FieldName { get; set; }

        int FKUnGraduteId { get; set; }

        string FKUnGraduteIdString { get; set; }
    }
}
