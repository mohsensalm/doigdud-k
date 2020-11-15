using atuticatin_1.Model;
using Microsoft.EntityFrameworkCore;


namespace atuticatin_1
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}