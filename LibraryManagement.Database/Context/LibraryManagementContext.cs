using LibraryManagement.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service.Context
{
    public class LibraryManagementContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Another> AnotherTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=LibraryManagement2;Integrated Security=True;Encrypt=False");

        }

    }
}
