using System.Collections.Generic;
using System.Linq;
namespace ConApp01
{
    class StudentBO
    {
        public List<StudentModel> students { get; set; }
        public StudentBO()
        {
            //In realtime the data will fetch from database
            students = new List<StudentModel>{
                new StudentModel { Id = 1001, SName = "Anil", Course = ".NET", Fee = 5000 },
                new StudentModel { Id = 1002, SName = "Bobby", Course = "MVC.NET", Fee = 2500 },
                new StudentModel { Id = 1003, SName = "Cathe", Course = "Angular", Fee = 6000 },
                new StudentModel { Id = 1004, SName = "David", Course = "React", Fee = 6200 }
            };
        }
        public List<StudentModel> GetAllStudents()
        {
            return students;
        }
        public StudentModel GetStudentById(int id)
        {
              return students.SingleOrDefault(x => x.Id == id);                                    
        }
        public StudentModel AddStudent (StudentModel s)
        {
            students.Add(s);
            return s;
        }
        public void EditStudent(StudentModel s , int id)
        {
            int index = students.FindIndex(x => x.Id == id);
            students[index] = s;

        }
        public void DeleteStudentById(int id)
        {
            int index = students.FindIndex(x => x.Id == id);
            students.RemoveAt(index);           
        }
    }
}

// F5:          Debug
//Coffe break: Session resume at 11:15am

// Shift+F5:    Stop Debug
//Ctrl+F5   :   Run the project