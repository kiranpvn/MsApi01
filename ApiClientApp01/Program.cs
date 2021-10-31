using System;
using System.Net.Http;
namespace ApiClientApp01
{
    class CourseModel
    {
        public int Id { get; set; }
        public string Course { get; set; }
        public string Hod { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {               
            using (var client = new HttpClient())
            {
                var course = new CourseModel { Id = 11, Course = "ABCD", Hod = "ABCD" };
                client.BaseAddress = new Uri("http://localhost:56154/api/");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<CourseModel>("Courses", course);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                    Console.WriteLine("Row Added successfully...");
            }

        }
    }
}