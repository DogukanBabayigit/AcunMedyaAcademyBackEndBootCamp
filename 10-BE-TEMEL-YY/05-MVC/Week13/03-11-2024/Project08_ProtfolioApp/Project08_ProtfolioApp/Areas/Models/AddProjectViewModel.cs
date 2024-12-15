using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project08_ProtfolioApp.Areas.Models;

public class AddProjectViewModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? GithubUrl { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; }
    public DateTime ModifiedDate { get; set; }
    public int CategoryId { get; set; }
    public List<SelectListItem>? CategoryList { get; set; }

}
