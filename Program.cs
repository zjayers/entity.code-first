using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // Class to be used to generate Database tables
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    // Setup DB Context to tell Entity Framework to generate tables for the given classes
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
