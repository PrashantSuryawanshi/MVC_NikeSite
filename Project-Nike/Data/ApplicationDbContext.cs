using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_Nike.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Nike.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Inventry> Inventry { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}
