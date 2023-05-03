using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherDomain;
using Microsoft.EntityFrameworkCore;
namespace PublisherData
{
    public class PublisherContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YourDatabase");
        }
    }
}
