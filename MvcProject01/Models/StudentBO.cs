using System.Collections.Generic;
using System.Linq;

namespace MvcProject01.Models
{
    public class StudentBO
    {
        public List<StudentModel> Students { get; set; }
        public StudentBO()
        {
            this.Students = new List<StudentModel> {
                new StudentModel{Id=1,SName="Anil",Course="MVC.NET",Fee=12000},
                new StudentModel{Id=2,SName="Bobby",Course="Angular",Fee=15000},
                new StudentModel{Id=3,SName="Cathe",Course="React",Fee=11000},
                new StudentModel{Id=4,SName="David",Course="Angular",Fee=14000},
                new StudentModel{Id=5,SName="Fernandez",Course="React",Fee=11000}
            };
            //In real time the data will come from database using ADO.NET or ORM or via API
        }
        public List<StudentModel> GetAllStudents() => Students;
        public StudentModel GetStudentById(int id) => Students.Single(x => x.Id == id);
        public List<StudentModel> GetAngularStudents() => Students.Where(x => x.Course == "Angular").ToList();
        public List<StudentModel> GetReactStudents() => Students.Where(x => x.Course == "React").ToList();
        public void AddStudent(StudentModel s)
        {
            Students.Add(s);
        }
        public void EditStudent(StudentModel s, int id)
        {
            var index = Students.FindIndex(x => x.Id == id);
            Students[index] = s;
        }
        public void DeleteStudentById(int id)
        {
            Students.Remove(Students.Find(x => x.Id == id));
        }
    }
}
