using LearnEnglish.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearnEnglish.API.Context
{
    public class LearnEnglishDbContext : DbContext
    {
        public DbSet<Text> Texts { get; set; }
        public DbSet<TextGroup> TextGroups { get; set; }
        public LearnEnglishDbContext(DbContextOptions<LearnEnglishDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Text>(entity =>
            {
                entity.HasKey(builder => builder.ID);
                entity.HasIndex(builder => builder.Value).IsUnique(true);
            });

            modelBuilder.Entity<TextGroup>(entity =>
            {
                entity.HasKey(builder => builder.ID);
                entity.HasIndex(builder => builder.Name).IsUnique(true);
            });
        }
    }
}
