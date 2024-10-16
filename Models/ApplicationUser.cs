﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace eManagement.Models
{
    [NotMapped]
    public class ApplicationUser: IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }
}
