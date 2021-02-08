using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EXAMMVC.Models;

namespace EXAMMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EXAMMVC.Models.Products> Products { get; set; }
        public DbSet<EXAMMVC.Models.OrderDetails> OrderDetails { get; set; }
    }
}
