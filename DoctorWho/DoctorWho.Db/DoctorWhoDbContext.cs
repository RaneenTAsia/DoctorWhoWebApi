using DoctorWhoDomain;
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
            //Enemy Shadow Properties
            modelBuilder.Entity<Enemy>().Property<string>(e => e.EnemyName).HasMaxLength(30);
            modelBuilder.Entity<Enemy>().Property<string>(e => e.Description).HasDefaultValue("Null");

            //Enemy Table Seeding
            List<Enemy> enemies = new List<Enemy> {
                new Enemy { EnemyId= 1, EnemyName="Za", Description="Desires Power" },
                new Enemy { EnemyId= 2, EnemyName="Kal", Description="Desires Power" },
                new Enemy { EnemyId= 3, EnemyName="Daleks", Description="Desires Earth invasion/Human extermination" },
                new Enemy { EnemyId= 4, EnemyName="Yartek", Description="Wants to take control of the Conscience of Marinus in order to control the people of Marinus" },
                new Enemy { EnemyId= 5, EnemyName="Voord", Description="Wants to control a planet"}
            };
            modelBuilder.Entity<Enemy>().HasData(enemies);

            //Companion Shadow Properties
            modelBuilder.Entity<Companion>().Property<string>(c => c.CompanionName).HasMaxLength(30);
            modelBuilder.Entity<Companion>().Property<string>(c => c.WhoPlayed).HasMaxLength(30);

            //Companion Table Seeding
            List<Companion> companions = new List<Companion>
            {
                new Companion { CompanionId = 1, CompanionName = "Barbara Wright", WhoPlayed = "Jacqueline Hill"},
                new Companion { CompanionId = 2, CompanionName = "Ian Chesterton", WhoPlayed = "Willim Russel"},
                new Companion { CompanionId = 3, CompanionName = "Susan Foreman", WhoPlayed = "Carole Ann Ford"},
                new Companion { CompanionId = 4, CompanionName = "Vicki", WhoPlayed = "Maureen O'Brien"},
                new Companion { CompanionId = 5, CompanionName = "Steven Taylor", WhoPlayed = "Peter Purves"}
            };
            modelBuilder.Entity<Companion>().HasData(companions);

            //Doctor Shadow Properties
            modelBuilder.Entity<Doctor>().Property<int>(d => d.DoctorNumber).IsRequired();
            modelBuilder.Entity<Doctor>().Property<string>(d => d.DoctorName).HasMaxLength(30);
            modelBuilder.Entity<Doctor>().Property(d => d.BirthDate).HasColumnType("DATE");
            modelBuilder.Entity<Doctor>().Property(d => d.BirthDate).HasDefaultValueSql("Null");
            modelBuilder.Entity<Doctor>().Property(d => d.FirstEpisodeDate).HasColumnType("DATE");
            modelBuilder.Entity<Doctor>().Property(d => d.FirstEpisodeDate).HasDefaultValueSql("Null");
            modelBuilder.Entity<Doctor>().Property(d => d.LastEpisodeDate).HasColumnType("DATE");
            modelBuilder.Entity<Doctor>().Property(d => d.LastEpisodeDate).HasDefaultValueSql("Null");

            //Doctor Table Seeding
            List<Doctor> doctors = new List<Doctor>
            {
                new Doctor { DoctorId = 1, DoctorNumber = 1, DoctorName = "The First Doctor" },
                new Doctor { DoctorId = 2, DoctorNumber = 2, DoctorName = "The Second Doctor" },
                new Doctor { DoctorId = 3, DoctorNumber = 3, DoctorName = "The Third Doctor" },
                new Doctor { DoctorId = 4, DoctorNumber = 4, DoctorName = "The Fourth Doctor" },
                new Doctor { DoctorId = 5, DoctorNumber = 5, DoctorName = "The Fifth Doctor" }
            };
            modelBuilder.Entity<Doctor>().HasData(doctors);

            //Author Shadow Properties
            modelBuilder.Entity<Author>().Property<string>(a => a.AuthorName).HasMaxLength(30);

            //Author Table Seeding
            List<Author> authors = new List<Author>
            {
                new Author{ AuthorId = 1, AuthorName = "Anthony Coburn"},
                new Author{ AuthorId = 2, AuthorName = "Terry Nation"},
                new Author{ AuthorId = 3, AuthorName = "John Lucarotti"},
                new Author{ AuthorId = 4, AuthorName = "Peter R. Newman"},
                new Author{ AuthorId = 5, AuthorName = "Dennis Spooner"}
            };
            modelBuilder.Entity<Author>().HasData(authors);

            //Episode Shadow Properties
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeDate).HasColumnType("date");
            modelBuilder.Entity<Episode>().Property<int>(e => e.SeriesNumber).HasDefaultValue(0);
            modelBuilder.Entity<Episode>().Property<int>(e => e.EpisodeNumber).HasDefaultValue(0);
            modelBuilder.Entity<Episode>().Property<string>(e => e.EpisodeType).HasMaxLength(30);
            modelBuilder.Entity<Episode>().Property<string>(e => e.Title).HasDefaultValue("Null");
            modelBuilder.Entity<Episode>().Property<DateTime>(e => e.EpisodeDate).HasDefaultValueSql("Null");
            modelBuilder.Entity<Episode>().Property<string>(e => e.Notes).HasDefaultValue("Null");

            //Episode Table Seeding
            List<Episode> episodes = new List<Episode>
            {
                new Episode{ EpisodeId= 1, SeriesNumber = 1, EpisodeNumber = 1, EpisodeType = "Mystery", Title = "An Unearthly Child", EpisodeDate = (new DateTime(1963,09,07)), AuthorId = 1, DoctorId = 1},
                new Episode{ EpisodeId= 2, SeriesNumber = 1, EpisodeNumber = 2, EpisodeType = "Mystery", Title = "The Cave of Skulls", EpisodeDate = new DateTime(1963,11,30), AuthorId = 1, DoctorId = 1},
                new Episode{ EpisodeId= 3, SeriesNumber = 1, EpisodeNumber = 3, EpisodeType = "Mystery", Title = "The Forest of Fear", EpisodeDate = new DateTime(1963,12,07), AuthorId = 1, DoctorId = 1},
                new Episode{ EpisodeId= 4, SeriesNumber = 1, EpisodeNumber = 4, EpisodeType = "Mystery", Title = "The Firemake", EpisodeDate = new DateTime(1963,12,14), AuthorId = 2, DoctorId = 1},
                new Episode{ EpisodeId= 5, SeriesNumber = 1, EpisodeNumber = 5, EpisodeType = "Mystery", Title = "The Dead Planet", EpisodeDate = new DateTime(1963,12,21), AuthorId = 3, DoctorId = 1},
                new Episode{ EpisodeId= 6, SeriesNumber = 1, EpisodeNumber = 6, EpisodeType = "Mystery", Title = "Survivors", EpisodeDate = new DateTime(1963,12,28), AuthorId = 3, DoctorId = 1}
            };
            modelBuilder.Entity<Episode>().HasData(episodes);

            //EpisodeEnemy Table Seeding
            List<EpisodeEnemy> episodeEnemies = new List<EpisodeEnemy>
            {
                new EpisodeEnemy{ EpisodeEnemyId = 1, EpisodeId = 1, EnemyId = 1},
                new EpisodeEnemy{ EpisodeEnemyId = 2, EpisodeId = 1, EnemyId = 2},
                new EpisodeEnemy{ EpisodeEnemyId = 3, EpisodeId = 2, EnemyId = 1},
                new EpisodeEnemy{ EpisodeEnemyId = 4, EpisodeId = 2, EnemyId = 2},
                new EpisodeEnemy{ EpisodeEnemyId = 5, EpisodeId = 3, EnemyId = 2},
                new EpisodeEnemy{ EpisodeEnemyId = 6, EpisodeId = 3, EnemyId = 3},
                new EpisodeEnemy{ EpisodeEnemyId = 7, EpisodeId = 4, EnemyId = 1},
                new EpisodeEnemy{ EpisodeEnemyId = 8, EpisodeId = 4, EnemyId = 4},
                new EpisodeEnemy{ EpisodeEnemyId = 9, EpisodeId = 5, EnemyId = 1},
                new EpisodeEnemy{ EpisodeEnemyId = 10, EpisodeId = 5, EnemyId = 3},
                new EpisodeEnemy{ EpisodeEnemyId = 11, EpisodeId = 5, EnemyId = 5}
            };
            modelBuilder.Entity<EpisodeEnemy>().HasData(episodeEnemies);

            //EpisodeCompanion Table Seeding
            List<EpisodeCompanion> episodeCompanions = new List<EpisodeCompanion>
            {
                new EpisodeCompanion{ EpisodeCompanionId = 1, EpisodeId = 1, CompanionId = 1},
                new EpisodeCompanion{ EpisodeCompanionId = 2, EpisodeId = 2, CompanionId = 1},
                new EpisodeCompanion{ EpisodeCompanionId = 3, EpisodeId = 2, CompanionId = 2},
                new EpisodeCompanion{ EpisodeCompanionId = 4, EpisodeId = 3, CompanionId = 3},
                new EpisodeCompanion{ EpisodeCompanionId = 5, EpisodeId = 4, CompanionId = 1},
                new EpisodeCompanion{ EpisodeCompanionId = 6, EpisodeId = 4, CompanionId = 2},
                new EpisodeCompanion{ EpisodeCompanionId = 7, EpisodeId = 5, CompanionId = 4},
                new EpisodeCompanion{ EpisodeCompanionId = 8, EpisodeId = 6, CompanionId = 1},
                new EpisodeCompanion{ EpisodeCompanionId = 9, EpisodeId = 6, CompanionId = 2},
                new EpisodeCompanion{ EpisodeCompanionId = 10, EpisodeId = 6, CompanionId = 3}
            };
            modelBuilder.Entity<EpisodeCompanion>().HasData(episodeCompanions);

            //State functions as DbFunctions
            modelBuilder.HasDbFunction(typeof(DoctorWhoDbContext).GetMethod(nameof(CompanionsFunctionResult), new[] { typeof(int) }))
                .HasName("fnCompanions");
            modelBuilder.HasDbFunction(typeof(DoctorWhoDbContext).GetMethod(nameof(EnemiesFunctionResult), new[] { typeof(int) }))
               .HasName("fnEnemies");

            //Mapping View
            modelBuilder.Entity<ViewEpisodes>().HasNoKey().ToView("viewEpisodes");

        }
    }
}