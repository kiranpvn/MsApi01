using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
namespace MsStudentApi
{
    public class CourseBO
    {
        public SqlConnection ConnectToSql()
        {
            SqlConnection cn = new SqlConnection(cs1);
            cn.Open();
            return cn;
        }
        public string cs1 { get; }
        private List<CourseModel> courses { set; get; }
        public CourseBO() { 
            cs1 =  "server=DESKTOP-DM30GHJ;user id=sa;password=welcome;database=CourseDB";
            SqlCommand cmd = new SqlCommand("Select * From tblCourses", ConnectToSql());
            SqlDataReader dr = cmd.ExecuteReader();
            courses = new List<CourseModel> { };
            CourseModel c = null;
            while (dr.Read())
            {
                c = new CourseModel();
                c.Id = Convert.ToInt32(dr[0]);
                c.Course = dr[1].ToString();
                c.Hod = dr[2].ToString();
                courses.Add(c);
            }
        }
        public List<CourseModel> GetCourses() => courses;
        public CourseModel GetCourseById(int id) => courses.Single(x => x.Id == id);
        public void AddCourse(CourseModel c)
        {
            string query = "insert into tblCourses values ( @id, @course, @hod)";
            SqlCommand cmd = new SqlCommand(query, ConnectToSql());
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@course", c.Course);
            cmd.Parameters.AddWithValue("@hod", c.Hod);
            cmd.ExecuteNonQuery();
        }
        public void EditCourse(CourseModel c,int id)
        {
            string query = "update tblCourses set course=@course, hod=@hod where id=@id";
            SqlCommand cmd = new SqlCommand(query, ConnectToSql());
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@course", c.Course);
            cmd.Parameters.AddWithValue("@hod", c.Hod);
            cmd.ExecuteNonQuery();
        }
        public void DeleteCourse( int id)
        {
            string query = "delete tblCourses  where id=@id";
            SqlCommand cmd = new SqlCommand(query, ConnectToSql());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
