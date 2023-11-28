﻿using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
    }
}