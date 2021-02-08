using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NtireArchitecturewithAdo.Models;

namespace NtireArchitecturewithAdo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NtireArchitecturewithAdo.Models.Banks> Banks { get; set; }
      
    }
}
