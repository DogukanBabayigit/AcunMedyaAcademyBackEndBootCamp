using System;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using Project08_PortfolioApp.Models;

namespace Project08_PortfolioApp.Areas.Admin.ViewComponents;

public class UserInfoViewComponent : ViewComponent
{

  public async Task<IViewComponentResult> InvokeAsync()
  {
    var connectionString = "Server=localhost,1441;Database=PortfolioDb;User=SA;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
    var connection = new SqlConnection(connectionString);

    var queryAppSetting = "select BrandName from AppSettings";
    var appSetting = (await connection.QueryAsync<AppSetting>(queryAppSetting)).First();

    return View(appSetting);
  }
  /*   public IViewComponentResult Invoke()
    {} */
}
