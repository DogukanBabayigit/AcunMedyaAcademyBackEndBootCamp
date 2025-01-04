using System;
using EShop.Shared.ComplexTypes;
using Microsoft.AspNetCore.Identity;

namespace EShop.Entity.Concrete;

public class ApplicationUser : IdentityUser
{
  private ApplicationUser() // EF Core için gerekli
  {
  }
  public ApplicationUser(string firstName, string lastName, DateTime dateOfBirth, GenderType genderType)
  {
    FirstName = firstName;
    LastName = lastName;
    DateOfBirth = dateOfBirth;
    GenderType = genderType;
  }

  public string FirstName { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public string? Address { get; set; }
  public string? City { get; set; }
  public DateTime DateOfBirth { get; set; }
  public GenderType GenderType { get; set; }
}
