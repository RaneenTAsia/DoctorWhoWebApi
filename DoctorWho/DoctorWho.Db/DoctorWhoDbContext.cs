using DoctorWhoDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DoctorWho.Db
{
    public class DoctorWhoDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemies { get; set; }
        public DbSet<ViewEpisodes> ViewEpisodes { get; set; }
        public string CompanionsFunctionResult(int EpisodeId) => throw new NotSupportedException();
        public string EnemiesFunctionResult(int EpisodeId) => throw new NotSupportedException();

        public DoctorWhoDbContext()
        {
        }

        public DoctorWhoDbContext(DbContextOptions<DoctorWhoDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DoctorWhoCore")
                    .LogTo(Console.WriteLine, new[]
                    {DbLoggerCategory.Database.Command.Name },
                     LogLevel.Information).EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var creator = new ModelCreator(modelBuilder);
          
            //Enemy
            creator.ConfigureEnemyShadowProperties();
            creator.SeedEnemiesTable();

            //Companion
            creator.ConfigureCompanionShadowProperties();
            creator.SeedCompanionsTable();

            //Doctor 
            creator.ConfigureDoctorShadowProperties();
            creator.SeedDoctorsTable();

            //Author
            creator.ConfigureAuthorShadowProperties();
            creator.SeedAuthorsTable();

            //Episode 
            creator.ConfigureEpisodeShadowProperties();
            creator.SeedEpisodesTable();

            //EpisodeEnemy 
            creator.ConfigureEpisodeEnemyShadowProperties();
            creator.SeedEpisodeEnemiesTable();

            //EpisodeCompanion 
            creator.ConfigureEpisodeCompanionShadowProperties();
            creator.SeedEpisodeCompanionsTable();

            //State functions as DbFunctions
            modelBuilder.HasDbFunction(typeof(DoctorWhoDbContext).GetMethod(nameof(CompanionsFunctionResult), new[] { typeof(int) }))
                 .HasName("fnCompanions");
            modelBuilder.HasDbFunction(typeof(DoctorWhoDbContext).GetMethod(nameof(EnemiesFunctionResult), new[] { typeof(int) }))
               .HasName("fnEnemies");

            //Mapping View
            creator.MapViews();

            //Set up relationships
            creator.SetUpRelationships();
        }
    }
}