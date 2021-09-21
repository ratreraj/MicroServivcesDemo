using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMicroservice.Database.Entities;
namespace UserMicroservice.Database
{
    public class DatabaseContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-HA42MEA\SQLEXPRESS; initial catalog=UserMicroservice;persist security info=True;user id=sa;password=Sql@2019; MultipleActiveResultSets=True;");
        }
    }
}
