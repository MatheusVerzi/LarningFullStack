using LarningFullStackDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace LarningFullStackData.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                new User
                {
                    Id = Guid.Parse("39e46af9-e154-48ec-823a-f16554f5fb8f"),
                    Name = "User Default",
                    Email = " userdefault@larningFullStack.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = null,
                    IsDeleted = false,
                });

            return modelBuilder;
        }

        public static ModelBuilder ApplyGlobalConfiguration(this ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(User.Id):
                            property.IsKey();
                            break;
                        case nameof(User.DateUpdated):
                            property.IsNullable = true;
                            break;
                        case nameof(User.DateCreated):
                            property.IsNullable = false;
                            break;
                        case nameof(User.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;
                        default:
                            break;
                    }
                }
            }
            return modelBuilder;
        }

    }
}
