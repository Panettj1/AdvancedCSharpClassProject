using AdvancedCSharpClassProject.Classes;
using AdvancedCSharpClassProject.Classes.BaseClasses;
using AdvancedCSharpClassProject.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AdvancedCSharpClassProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext()
        {

        }


        /// <summary>
        /// Initalizes DbContext Class
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        /// <summary>
        /// Sets Models to be added to DB on database update
        /// </summary>
        public DbSet<LandAnimals> LandAnimals { get; set; }
        public DbSet<AquaticAnimal> AqauticAnimals { get; set; }
        public DbSet<Owner> Owners { get; set; }

        /// <summary>
        /// Adds Seed data to DB if it doesn't already exist in local DB
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>()
                .HasMany(o => o.Animals)
                .WithOne(p => p.Owner)
                .HasForeignKey(p => p.OwnerId);

            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Owner)
                .WithMany(o => o.Animals)
                .HasForeignKey(a => a.OwnerId);

            modelBuilder.Entity<LandAnimals>()
                .ToTable("LandAnimals");

            modelBuilder.Entity<AquaticAnimal>()
                .ToTable("AqauticAnimals");

            modelBuilder.SeedData();
        }

        /// <summary>
        /// Declaration of the connection string which is set in app.config
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AdvancedCSharpProjectDatabase"].ConnectionString);
        }
    }
}
