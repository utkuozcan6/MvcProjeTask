using System;
using Microsoft.EntityFrameworkCore;
using TaskCategory.Entity.Entities;

namespace TaskCategory.Data.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}

