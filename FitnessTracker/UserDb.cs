using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker
{
    public class UserDb : DbContext
    {
        // creating the connection
        public DbSet<tbl_Users> Users { get; set; }
        public DbSet<tbl_Exercises> Exercises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-DNB9KRF;Initial Catalog=FitnessDatabase;Integrated Security=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Users>().ToTable("tbl_Users");
            modelBuilder.Entity<tbl_Exercises>().ToTable("tbl_Exercisess");
        }
    }
    

}
