using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeManageMent.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _studentsList;
        public MockStudentRepository()
        {
            _studentsList = new List<Student>()
            {
                new Student{Id=1,Name="马云",ClassName="一年级",Email="mayun@163.com" },
                new Student{Id=2,Name="马化腾",ClassName="二年级",Email="mahuateng@163.com" },
                new Student{Id=3,Name="雷军",ClassName="三年级",Email="leijun@163.com" }
            };
        }
        public Student GetStudent(int id)
        {
           return _studentsList.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Student> GetStudentsAll()
        {
            return _studentsList;
        }
    }
}
