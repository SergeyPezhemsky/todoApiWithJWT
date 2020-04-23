using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.Models
{
    public class peopleContex : DbContext
    {
        public peopleContex(DbContextOptions<peopleContex> options)
   : base(options)
        {
        }
        public DbSet<People> Peoples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>()
                .OwnsMany(property => property.tasks);
        }
    }
}
