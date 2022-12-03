using Fiorello_Lab.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_Lab.DAL
{
    public class FioDbContext:DbContext
    {
        public FioDbContext(DbContextOptions<FioDbContext> opt):base(opt)
        {

        }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Setting> Settings { get; set;  }
    }
}
