using DOTNET.TEMPLATE.COMMON.MODELS;
using Microsoft.EntityFrameworkCore;

namespace DOTNET.TEMPLATE.DATAACCESS
{
    public class MyContextDb : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyContextDb(DbContextOptions<MyContextDb> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
