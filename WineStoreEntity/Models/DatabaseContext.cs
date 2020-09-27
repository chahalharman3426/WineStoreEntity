using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineStoreEntity.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        //creating the database set to insert the value or make relation with the database table 
        public DbSet<Employee_Table> Employee_Table { get; set; }

        public DbSet<Purchase_Data> Purchase_Data { get; set; }

        public DbSet<Sale_Data> Sale_Data { get; set; }

        public DbSet<Contact_Data> Contact_Data { get; set; }

    }
}
