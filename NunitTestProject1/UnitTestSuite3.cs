using NUnit.Framework;
using CalculationLibrary;
using System.Net.Http;
using System;

namespace NunitTestProject1
{
    public class UnitTestSuite3
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            //Assign
            int id = 3;
            string expectedCourse = "CSE";
            string actualCourse = string.Empty;
            //Act
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56154/api/");
                //HTTP GET
                var responseTask = client.GetAsync($"courses/{id}");

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<CourseModel>();
                    readTask.Wait();

                    var student = readTask.Result;

                     actualCourse = student.Course;
                }
            }

            //Assert
            Assert.AreEqual(expectedCourse, actualCourse);
        }
    }
}