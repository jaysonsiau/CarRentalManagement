﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                // This is a random GUID that can be generated online.
                Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            },
            new IdentityRole
            {
                Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                Name = "User",
                NormalizedName = "USER"
            }
            );
        }
    }
}