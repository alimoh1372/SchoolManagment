using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class StudentViewModel : IStudentViewModel
    {
        public int StudentId { get ; set ; }
        public string StudentName { get ; set ; }
        public string StudentNationCode { get ; set ; }
        public int? FkLastPassedUgraduteId { get ; set; }
        public string FkLastPassedUgraduteIdString { get; set; }
        public int FkStudentFieldId { get ; set ; }
        public string FkStudentFieldIdString { get ; set; }
    }
}
