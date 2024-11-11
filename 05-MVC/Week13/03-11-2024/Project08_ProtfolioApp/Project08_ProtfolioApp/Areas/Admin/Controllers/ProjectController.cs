using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Project08_ProtfolioApp.Models;

namespace Project08_ProtfolioApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        // GET: ProjectController
        
        public async Task<ActionResult> Index()

        {
            var connectionString = "Server=localhost,1441;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            var queryProjects = "select * from Projects";
            var projects = await connection.QueryAsync<Project>(queryProjects);

            return View(projects);
        }

        public async Task<ActionResult> Create()
        {
            return View();
        }
        private async Task<List<>>

    }
}
