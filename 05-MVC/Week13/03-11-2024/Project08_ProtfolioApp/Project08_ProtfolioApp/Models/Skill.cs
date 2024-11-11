using System;

namespace Project08_ProtfolioApp.Models;

public class Skill
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public byte Rate { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }

}
