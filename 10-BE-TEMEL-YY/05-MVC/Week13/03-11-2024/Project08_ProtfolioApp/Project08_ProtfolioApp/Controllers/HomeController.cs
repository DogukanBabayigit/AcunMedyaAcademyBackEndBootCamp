using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Project08_ProtfolioApp.Models;


namespace Project08_ProtfolioApp.Controllers;

public class HomeController : Controller
{


    public async Task<IActionResult> Index()
    {
        //Bağlantıyı hazırlıyoruz.
        var connectionString = "Server=localhost,1441;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
        var connection = new SqlConnection(connectionString);

        //site ayarlarını çekiyoruz
        var queryAppSetting = "select * from AppSettings";
        var appSetting = (await connection.QueryAsync<AppSetting>(queryAppSetting)).First();

        //Category ayarlarını çekiyoruz
        var queryCategory = "select * from Categories";
        var categories = await connection.QueryAsync<Category>(queryCategory);

        //Socials ayarlarını çekiyoruz
        var querySocial = "select * from Socials";
        var social = await connection.QueryAsync<Social>(querySocial);

        //Skills ayarlarını çekiyoruz
        var querySkill = "select * from Skills";
        var skill = await connection.QueryAsync<Skill>(querySkill);

        //Services ayarlarını çekiyoruz
        var queryService = "select * from Services";
        var service = await connection.QueryAsync<Service>(queryService);

        //Projects ayarlarını çekiyoruz
        var queryProject = "select * from Projects";
        var project = await connection.QueryAsync<Project>(queryProject);

        //Contacts ayarlarını çekiyoruz
        var queryContact = "select * from Contacts";
        var contact = await connection.QueryAsync<Contact>(queryContact);


        HomaPageModel model = new()
        {
            AppSetting = appSetting,
            Categories = categories,
            Projects = project,
            Services = service,
            Skills = skill,
            Socials = social
        };

        return View(model);
    }


}
