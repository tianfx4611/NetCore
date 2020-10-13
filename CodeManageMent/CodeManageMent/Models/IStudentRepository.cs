using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeManageMent.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int Id);
        IEnumerable<Student> GetStudentsAll();
    }
}
