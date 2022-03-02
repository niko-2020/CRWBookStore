using Microsoft.EntityFrameworkCore;

namespace CRWBookStore.Models {
    public class StoreDbContext : DbContext {

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }

        public DbSet<BookModel> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
