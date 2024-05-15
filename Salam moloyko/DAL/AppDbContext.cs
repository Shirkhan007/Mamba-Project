using Microsoft.EntityFrameworkCore;
using Salam_moloyko.Models;

namespace Salam_moloyko.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public  DbSet<Team> teams { get; set; }
    }
}
