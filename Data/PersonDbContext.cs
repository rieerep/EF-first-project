using ef_firstproject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_firstproject.Data
{
    internal class PersonDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderList> OrderLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Data Source=SATURN; Initial Catalog=MobilePhoneDb;Integrated Security=true");


        }
    }
}
