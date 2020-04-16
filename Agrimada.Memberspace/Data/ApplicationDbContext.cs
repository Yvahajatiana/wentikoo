using System;
using System.Collections.Generic;
using System.Text;
using Agrimada.Memberspace.Models;
using Agrimada.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Agrimada.Memberspace.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<SupplierProduct> SupplierProducts { get; set; }

    }
}
