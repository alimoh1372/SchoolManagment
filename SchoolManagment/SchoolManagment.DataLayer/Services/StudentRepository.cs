using SchoolManagment.DataLayer.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.DataLayer
{
   public class StudentRepository:BaseRepository<Student>,IStudentRepository
    {
        public  StudentRepository(SchoolManagmentEntities db) : base(db)
        {

        }


    }
}
