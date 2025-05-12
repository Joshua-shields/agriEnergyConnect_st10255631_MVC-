﻿/////////////////////////////////////////START OF IMPORTS//////////////////////////////////////////////////////////////////
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/////////////////////////////////////////END OF IMPORTS//////////////////////////////////////////////////////////////////

namespace AgriEnergyConnect_st10255631_MVC.Models;

// Represents a user in the system Employee or Farmer
public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Username { get; set; }

    [Required]
    public string PasswordHash { get; set; }
    [Required]
    [StringLength(50)]
    public string Role { get; set; }

    public virtual Farmer? FarmerProfile { get; set; }
}
////////////////////////////////////////////////////////////END OF FILE////////////////////////////////////////////////////////////