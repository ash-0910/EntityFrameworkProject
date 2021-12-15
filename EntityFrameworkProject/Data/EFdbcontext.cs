using EntityFrameworkProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Data
{
    public class EFdbcontext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<SaleItem> SalesItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(@"Data Source=C:\Temp\mydb.db");
        }
    }
}
