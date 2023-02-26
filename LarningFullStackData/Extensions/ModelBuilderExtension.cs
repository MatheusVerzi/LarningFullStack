using LarningFullStackDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningFullStackData.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                new User
                {
                    Id = Guid.Parse("39e46af9-e154-48ec-823a-f16554f5fb8f"),
                    Name = "User Default",
                    Email = " userdefault@larningFullStack.com"
                });

            return builder;
        }
    }
}
