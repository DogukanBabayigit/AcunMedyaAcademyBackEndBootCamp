using System;

namespace Project08_ProtfolioApp.Models;

public class HomaPageModel
{
    public AppSetting? AppSetting { get; set; }
    public IEnumerable<Category>? Categories { get; set; }
    public IEnumerable<Service>? Services { get; set; }
    public IEnumerable<Project>? Projects { get; set; }
    public IEnumerable<Skill>? Skills { get; set; }

    public IEnumerable<Social>? Socials { get; set; }

}
