using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.ViewModel
{
    public class StudenPresentDetailViewModel : StudentViewModel, IStudenPresentDetailViewModel
    {
        public int PkStudentPresents { get ; set ; }
        public int FkStudentMustPresentinClassesWhicTeacherTeachLessonAccToCalenderInClassId { get ; set ; }
    }
}
