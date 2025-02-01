using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.Models;


namespace DMS.Repositories
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Component> Component { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Engine> Engine { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Vendor> Vendor { get; set; }


    }
}
