using Infrastructure.Persistance;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public partial class BookSharingContext : IdentityDbContext
    {
        public BookSharingContext(DbContextOptions<BookSharingContext> options) : base(options) { }
        private readonly static string IgnorePrefix = "AspNet";
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public new DbSet<User> Users { get; set; }
        public DbSet<PendingBook> PendingBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                        .HasIndex(i => i.FullName)
                        .IsUnique();
            modelBuilder.Entity<Genre>()
                        .HasIndex(i => i.Name)
                        .IsUnique();
            modelBuilder.Entity<Language>()
                        .HasIndex(i => i.Name)
                        .IsUnique();

            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith(IgnorePrefix))
                    entityType.SetTableName(tableName[IgnorePrefix.Length..]);
            }
        }
    }
}
