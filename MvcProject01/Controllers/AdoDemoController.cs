using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MvcProject01.Models;
namespace MvcProject01.Controllers
{
    public class AdoDemoController : Controller
    {
        string cs = string.Empty;                   string query = string.Empty;

        SqlConnection cn = null;                    SqlCommand cmd = null;
        SqlDataReader dr = null;
        SqlConnection ConnectToSql()
        {
            cs = @"server=DESKTOP-DM30GHJ;user id=sa;password=welcome;database=EmpDB";
            cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }
        public IActionResult Index()
        {            
            query = "select * from tblEmployees";
            cmd = new SqlCommand(query, ConnectToSql());

            dr = cmd.ExecuteReader();
            List<EmpModel> employees = new List<EmpModel>();

            while (dr.Read())
            {
                EmpModel e = new EmpModel();
                e.Id = Convert.ToInt32(dr[0]);
                e.EName = dr[1].ToString();
                e.Job = dr[2].ToString();
                e.Salary = Convert.ToInt32(dr[3]);

                employees.Add(e);
            }
            dr.Close();     cmd.Dispose();
            return View(employees);
        }
        public EmpModel GetRowById(int id)
        {
            query = "select * from tblEmployees where id=@id";
            cmd = new SqlCommand(query, ConnectToSql());
            cmd.Parameters.AddWithValue("@id", id);
            dr = cmd.ExecuteReader();
            EmpModel e = new EmpModel();

            if (dr.Read())
            {
                e.Id = Convert.ToInt32(dr[0]);
                e.EName = dr[1].ToString();
                e.Job = dr[2].ToString();
                e.Salary = Convert.ToInt32(dr[3]);
            }
            dr.Close(); cmd.Dispose();
            return e;
        }
        public IActionResult Details(int id)
        {            
            return View(GetRowById(id));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmpModel e)
        {
            query = "insert into tblEmployees values ( @id, @ename, @job, @salary)";
            cmd = new SqlCommand(query, ConnectToSql());
            cmd.Parameters.AddWithValue("@id", e.Id);
            cmd.Parameters.AddWithValue("@ename", e.EName);
            cmd.Parameters.AddWithValue("@job", e.Job);
            cmd.Parameters.AddWithValue("@salary", e.Salary);
            cmd.ExecuteNonQuery();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            return View(GetRowById(id));
        }
        [HttpPost]
        public IActionResult Edit(EmpModel e)
        {
            query = "update tblEmployees set ename= @ename, job=@job, salary=@salary where id=@id";
            cmd = new SqlCommand(query, ConnectToSql());
            cmd.Parameters.AddWithValue("@id", e.Id);
            cmd.Parameters.AddWithValue("@ename", e.EName);
            cmd.Parameters.AddWithValue("@job", e.Job);
            cmd.Parameters.AddWithValue("@salary", e.Salary);
            cmd.ExecuteNonQuery();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            return View(GetRowById(id));
        }
        [HttpPost]
        public IActionResult Delete(EmpModel e)
        {
            query = "delete tblEmployees  where id=@id";
            cmd = new SqlCommand(query, ConnectToSql());
            cmd.Parameters.AddWithValue("@id", e.Id);
            
            cmd.ExecuteNonQuery();
            return RedirectToAction("index");
        }
    }
}
