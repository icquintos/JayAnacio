using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BasicCRUD.Models
{
    public class MyDbContext : DbContext
    {

        public DbSet<Person> Person { get; set; }

        public DbSet<UserAccounts> UserAccounts { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<EmploymentRole> EmploymentRole { get; set; }

        public DbSet<EmploymentStatus> EmploymentStatus { get; set; }
    }

}