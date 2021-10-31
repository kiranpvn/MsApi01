using System.Collections.Generic;
using System.Linq;
namespace MsApi01
{
    public class StudentBO
    {
        private List<StudentModel> students { get; set; }
        public StudentBO()
        {
            students = new List<StudentModel> {
            new StudentModel{Id=101,SName="Raj",Course="Angular",Fee=5000},
            new StudentModel{Id=102,SName="Dev",Course="React",Fee=8000},
            new StudentModel{Id=103,SName="Siva",Course="Angular",Fee=2000}
            };
        }
        public List<StudentModel> GetAllStudents() => students;
        public StudentModel GetStudentById(int id) => students.Single(x => x.Id == id);
        public void AddStudent(StudentModel s) => students.Add(s);
        public void EditStudents(StudentModel s, int id) => students[students.FindIndex(x => x.Id == id)] = s;
        public void DeleteStudent(int id) => students.RemoveAt(students.FindIndex(x => x.Id == id));
    }
}
