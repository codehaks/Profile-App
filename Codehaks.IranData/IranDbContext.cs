using Codehaks.IranData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codehaks.IranData
{
    public class IranDbContext:DbContext
    {
        public IranDbContext(DbContextOptions<IranDbContext> options)
               : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}
