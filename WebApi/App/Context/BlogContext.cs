namespace App.Context
{
    using Microsoft.EntityFrameworkCore;
    using App.Models;

    public class BlogContext
        : DbContext
    {
        public BlogContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("secrets.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultDB");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}