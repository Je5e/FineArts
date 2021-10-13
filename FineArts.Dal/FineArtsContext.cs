using System;
using Microsoft.EntityFrameworkCore;
using FineArts.Entities;

namespace FineArts.Dal
{
    public class FineArtsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FineArts");
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
