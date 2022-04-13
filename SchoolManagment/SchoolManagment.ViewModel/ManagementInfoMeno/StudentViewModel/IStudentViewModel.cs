using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public interface IStudentViewModel
    {
        bool checkboxSelectStudent { get; set; }
        int StudentId { get; set; }
        string StudentName { get; set; }

        string StudentNationCode { get; set; }
        int? FkLastPassedUgraduteId { get; set; }

        string FkLastPassedUgraduteIdString { get; set; }

        int FkStudentFieldId { get; set; }

        string FkStudentFieldIdString { get; set; }
    }
}
