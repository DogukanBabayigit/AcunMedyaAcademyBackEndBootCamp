using System;
using System.Data.Common;
using Microsoft.AspNetCore.Identity;

namespace EShop.Entity.Concrete;

public class ApplicationRole : IdentityRole
{
  private ApplicationRole() // EF Core için gerekli
  {
  }
  public ApplicationRole(string description)
  {
    Description = description;
  }

  public string Description { get; set; } = string.Empty;
}
