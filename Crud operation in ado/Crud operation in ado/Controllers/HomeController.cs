using Crud_operation_in_ado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

 
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
 
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace Crud_operation_in_ado.Controllers
{
    /*public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
*/
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }

        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            List<lecturer> teacherList = new List<lecturer>();

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SqlDataReader
                connection.Open();

                string sql = "Select * From Teacher";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        lecturer teacher = new lecturer();
                        teacher.Id = Convert.ToInt32(dataReader["Id"]);
                        teacher.LecturerName = Convert.ToString(dataReader["Name"]);
                        teacher.Skills = Convert.ToString(dataReader["Skills"]);
                        teacher.NoofStudents = Convert.ToInt32(dataReader["TotalStudents"]);
                        teacher.Salary = Convert.ToDecimal(dataReader["Salary"]);
                        teacher.AddedOn = Convert.ToDateTime(dataReader["AddedOn"]);

                        teacherList.Add(teacher);
                    }
                }

                connection.Close();
            }
            return View(teacherList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(lecturer teacher)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = $"Insert Into Teacher (Name, Skills, TotalStudents, Salary,AddedOn) Values ('{teacher.LecturerName}', '{teacher.Skills}','{teacher.NoofStudents}','{teacher.Salary}', '{teacher.AddedOn}')";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    return RedirectToAction("Index");
                }
            }
            else
                return View();
        }

        public IActionResult Update(int id)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];

            lecturer teacher = new lecturer();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Select * From Teacher Where Id='{id}'";
                SqlCommand command = new SqlCommand(sql, connection);

                connection.Open();

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        teacher.Id = Convert.ToInt32(dataReader["Id"]);
                        teacher.LecturerName = Convert.ToString(dataReader["Name"]);
                        teacher.Skills = Convert.ToString(dataReader["Skills"]);
                        teacher.NoofStudents = Convert.ToInt32(dataReader["TotalStudents"]);
                        teacher.Salary = Convert.ToDecimal(dataReader["Salary"]);
                        teacher.AddedOn = Convert.ToDateTime(dataReader["AddedOn"]);
                    }
                }

                connection.Close();
            }
            return View(teacher);
        }

        [HttpPost]
        [ActionName("Update")]
        public IActionResult Update_Post(lecturer teacher)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Update Teacher SET Name='{teacher.LecturerName}', Skills='{teacher.Skills}', TotalStudents='{teacher.NoofStudents}', Salary='{teacher.Salary}' Where Id='{teacher.Id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"Delete From Teacher Where Id='{id}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        ViewBag.Result = "Operation got error:" + ex.Message;
                    }
                    connection.Close();
                }
            }

            return RedirectToAction("Index");
        }
    }