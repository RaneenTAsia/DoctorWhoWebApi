using DoctorWhoDomain;
using DoctorWhoDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db
{
    public class ModelCreator
    {
        public ModelBuilder modelBuilder { get; set; }
        public ModelCreator(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void ConfigureEnemyShadowProperties()
        {
            modelBuilder.Entity<Enemy>().Property<string>(e => e.EnemyName).HasMaxLength(30);
            modelBuilder.Entity<Enemy>().Property<string>(e => e.Description).HasDefaultValue("Null");

        }

        public void SeedEnemiesTable()
        {
            List<Enemy> enemies = new List<Enemy> {
                new Enemy { EnemyId= 1, EnemyName="Za", Description="Desires Power" },
                new Enemy { EnemyId= 2, EnemyName="Kal", Description="Desires Power" },
                new Enemy { EnemyId= 3, EnemyName="Daleks", Description="Desires Earth invasion/Human extermination" },
                new Enemy { EnemyId= 4, EnemyName="Yartek", Description="Wants to take control of the Conscience of Marinus in order to control the people of Marinus" },
                new Enemy { EnemyId= 5, EnemyName="Voord", Description="Wants to control a planet"}
            };
            modelBuilder.Entity<Enemy>().HasData(enemies);
        }

        public void ConfigureCompanionShadowProperties()
        {
            modelBuilder.Entity<Companion>().Property<string>(c => c.CompanionName).HasMaxLength(30);
            modelBuilder.Entity<Companion>().Property<string>(c => c.WhoPlayed).HasMaxLength(30);

        }

        public void SeedCompanionsTable()
        {
            List<Companion> companions = new List<Companion>
            {
                new Companion { CompanionId = 1, CompanionName = "Barbara Wright", WhoPlayed = "Jacqueline Hill"},
                new Companion { CompanionId = 2, CompanionName = "Ian Chesterton", WhoPlayed = "Willim Russel"},
                new Companion { CompanionId = 3, CompanionName = "Susan Foreman", WhoPlayed = "Carole Ann Ford"},
                new Companion { CompanionId = 4, CompanionName = "Vicki", WhoPlayed = "Maureen O'Brien"},
                new Companion { CompanionId = 5, CompanionName = "Steven Taylor", WhoPlayed = "Peter Purves"}
            };
            modelBuilder.Entity<Companion>().HasData(companions);
        }

        public void ConfigureDoctorShadowProperties()
        {
            modelBuilder.Entity<Doctor>().Property<int>(d => d.DoctorNumber).IsRequired();
            modelBuilder.Entity<Doctor>().Property<string>(d => d.DoctorName).HasMaxLength(30);
            modelBuilder.Entity<Doctor>().Property(d => d.BirthDate).HasColumnType("DATE");
            modelBuilder.Entity<Doctor>().Property(d => d.BirthDate).HasDefaultValueSql("Null");
            modelBuilder.Entity<Doctor>().Property(d => d.FirstEpisodeDate).HasColumnType("DATE");
            modelBuilder.Entity<Doctor>().Property(d => d.FirstEpisodeDate).HasDefaultValueSql("Null");
            modelBuilder.Entity<Doctor>().Property(d => d.LastEpisodeDate).HasColumnType("DATE");
            modelBuilder.Entity<Doctor>().Property(d => d.LastEpisodeDate).HasDefaultValueSql("Null");

        }

        public void SeedDoctorsTable()
        {
            List<Doctor> doctors = new List<Doctor>
            {
                new Doctor { DoctorId = 1, DoctorNumber = 1, DoctorName = "The First Doctor", FirstEpisodeDate = new DateTime(1963,11,23), LastEpisodeDate = new DateTime(1965, 09,11) },
                new Doctor { DoctorId = 2, DoctorNumber = 2, DoctorName = "The Second Doctor",  FirstEpisodeDate = new DateTime(1966, 09, 10), LastEpisodeDate = new DateTime(1968, 08, 10) },
                new Doctor { DoctorId = 3, DoctorNumber = 3, DoctorName = "The Third Doctor" , FirstEpisodeDate = new DateTime(1970, 01, 03), LastEpisodeDate = new DateTime(1973, 12, 15)},
                new Doctor { DoctorId = 4, DoctorNumber = 4, DoctorName = "The Fourth Doctor" , FirstEpisodeDate = new DateTime(1974, 12, 28), LastEpisodeDate = new DateTime(1980, 08, 30)},
                new Doctor { DoctorId = 5, DoctorNumber = 5, DoctorName = "The Fifth Doctor" , FirstEpisodeDate = new DateTime(1982, 01, 04), LastEpisodeDate = new DateTime(1984, 01, 05)}
            };
            modelBuilder.Entity<Doctor>().HasData(doctors);
        }

        public void ConfigureAuthorShadowProperties()
        {
            modelBuilder.Entity<Author>().Property<string>(a => a.AuthorName).HasMaxLength(30);

        }

        public void SeedAuthorsTable()
        {
            List<Author> authors = new List<Author>
            {
                new Author{ AuthorId = 1, AuthorName = "Anthony Coburn"},
                new Author{ AuthorId = 2, AuthorName = "Terry Nation"},
                new Author{ AuthorId = 3, AuthorName = "John Lucarotti"},
                new Author{ AuthorId = 4, AuthorName = "Peter R. Newman"},
                new Author{ AuthorId = 5, AuthorName = "Dennis Spooner"}
            };
            modelBuilder.Entity<Author>().HasData(authors);
        }

        public void ConfigureEpisodeShadowProperties()
        {
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeDate).HasColumnType("date");
            modelBuilder.Entity<Episode>().Property<int>(e => e.SeriesNumber).HasDefaultValue(0);
            modelBuilder.Entity<Episode>().Property<int>(e => e.EpisodeNumber).HasDefaultValue(0);
            modelBuilder.Entity<Episode>().Property<string>(e => e.EpisodeType).HasMaxLength(30);
            modelBuilder.Entity<Episode>().Property<string>(e => e.Title).HasDefaultValue("Null");
            modelBuilder.Entity<Episode>().Property<DateTime>(e => e.EpisodeDate).HasDefaultValueSql("Null");
            modelBuilder.Entity<Episode>().Property<string>(e => e.Notes).HasDefaultValue("Null");
        }

        public void SeedEpisodesTable()
        {
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
        }

        public void ConfigureEpisodeEnemyShadowProperties()
        {
            modelBuilder.Entity<EpisodeEnemy>().HasKey(ee => ee.EpisodeId);
            modelBuilder.Entity<EpisodeEnemy>().HasKey(ee => ee.EnemyId);

        }

        public void SeedEpisodeEnemiesTable()
        {
            List<EpisodeEnemy> episodeEnemies = new List<EpisodeEnemy>
            {
                new EpisodeEnemy{ EpisodeId = 1, EnemyId = 1},
                new EpisodeEnemy{ EpisodeId = 1, EnemyId = 2},
                new EpisodeEnemy{ EpisodeId = 2, EnemyId = 1},
                new EpisodeEnemy{ EpisodeId = 2, EnemyId = 2},
                new EpisodeEnemy{ EpisodeId = 3, EnemyId = 2},
                new EpisodeEnemy{ EpisodeId = 3, EnemyId = 3},
                new EpisodeEnemy{ EpisodeId = 4, EnemyId = 1},
                new EpisodeEnemy{ EpisodeId = 4, EnemyId = 4},
                new EpisodeEnemy{ EpisodeId = 5, EnemyId = 1},
                new EpisodeEnemy{ EpisodeId = 5, EnemyId = 3},
                new EpisodeEnemy{ EpisodeId = 5, EnemyId = 5}
            };
            modelBuilder.Entity<EpisodeEnemy>().HasData(episodeEnemies);
        }

        public void ConfigureEpisodeCompanionShadowProperties()
        {
            modelBuilder.Entity<EpisodeCompanion>().HasKey(ec => ec.CompanionId);
            modelBuilder.Entity<EpisodeCompanion>().HasKey(ec => ec.EpisodeId);
        }

        public void SeedEpisodeCompanionsTable()
        {
            List<EpisodeCompanion> episodeCompanions = new List<EpisodeCompanion>
            {
                new EpisodeCompanion{  EpisodeId = 1, CompanionId = 1},
                new EpisodeCompanion{  EpisodeId = 2, CompanionId = 1},
                new EpisodeCompanion{  EpisodeId = 2, CompanionId = 2},
                new EpisodeCompanion{ EpisodeId = 3, CompanionId = 3},
                new EpisodeCompanion{ EpisodeId = 4, CompanionId = 1},
                new EpisodeCompanion{ EpisodeId = 4, CompanionId = 2},
                new EpisodeCompanion{ EpisodeId = 5, CompanionId = 4},
                new EpisodeCompanion{ EpisodeId = 6, CompanionId = 1},
                new EpisodeCompanion{ EpisodeId = 6, CompanionId = 2},
                new EpisodeCompanion{ EpisodeId = 6, CompanionId = 3}
            };
            modelBuilder.Entity<EpisodeCompanion>().HasData(episodeCompanions);
        }

        public void MapViews()
        {
            modelBuilder.Entity<ViewEpisodes>().HasNoKey().ToView("viewEpisodes");
        }

        public void SetUpRelationships()
        {
            modelBuilder.Entity<Episode>()
                        .HasMany(e => e.Companions)
                        .WithMany(e => e.Episodes)
                        .UsingEntity<EpisodeCompanion>
                        (
                            ec => ec.HasOne(e => e.Companion)
                            .WithMany()
                            .HasForeignKey(e => e.CompanionId),
                            ec => ec.HasOne(e => e.Episode)
                                 .WithMany()
                                 .HasForeignKey(e => e.EpisodeId),
                            ec =>
                            {
                                ec.ToTable("EpisodeCompanions");
                                var episodeId = ec.HasIndex(e => e.EpisodeId);
                                var companionId = ec.HasIndex(e => e.CompanionId);
                                ec.HasKey(a => new { a.EpisodeId, a.CompanionId });
                            }
                        );

            modelBuilder.Entity<Episode>()
                        .HasMany(e => e.Enemies)
                        .WithMany(e => e.Episodes)
                        .UsingEntity<EpisodeEnemy>
                        (
                            ee => ee.HasOne(e => e.Enemy)
                            .WithMany()
                            .HasForeignKey(e => e.EnemyId),
                            ee => ee.HasOne(e => e.Episode)
                                 .WithMany()
                                 .HasForeignKey(e => e.EpisodeId),
                            ee =>
                            {
                                ee.ToTable("EpisodeEnemies");
                                ee.HasKey(a => new { a.EpisodeId, a.EnemyId });
                            }
                        );
        }
    }
}
