﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoDbContext))]
    [Migration("20230329131512_Create_spSummariseEpisodes_StoredProcedure")]
    partial class Create_spSummariseEpisodes_StoredProcedure
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWhoDomain.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Anthony Coburn"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Terry Nation"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "John Lucarotti"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Peter R. Newman"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Dennis Spooner"
                        });
                });

            modelBuilder.Entity("DoctorWhoDomain.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"));

                    b.Property<string>("CompanionName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("WhoPlayed")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Barbara Wright",
                            WhoPlayed = "Jacqueline Hill"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Ian Chesterton",
                            WhoPlayed = "Willim Russel"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Susan Foreman",
                            WhoPlayed = "Carole Ann Ford"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Vicki",
                            WhoPlayed = "Maureen O'Brien"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Steven Taylor",
                            WhoPlayed = "Peter Purves"
                        });
                });

            modelBuilder.Entity("DoctorWhoDomain.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<DateTime?>("BirthDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATE")
                        .HasDefaultValueSql("Null");

                    b.Property<string>("DoctorName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstEpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATE")
                        .HasDefaultValueSql("Null");

                    b.Property<DateTime?>("LastEpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATE")
                        .HasDefaultValueSql("Null");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            DoctorName = "The First Doctor",
                            DoctorNumber = 1
                        },
                        new
                        {
                            DoctorId = 2,
                            DoctorName = "The Second Doctor",
                            DoctorNumber = 2
                        },
                        new
                        {
                            DoctorId = 3,
                            DoctorName = "The Third Doctor",
                            DoctorNumber = 3
                        },
                        new
                        {
                            DoctorId = 4,
                            DoctorName = "The Fourth Doctor",
                            DoctorNumber = 4
                        },
                        new
                        {
                            DoctorId = 5,
                            DoctorName = "The Fifth Doctor",
                            DoctorNumber = 5
                        });
                });

            modelBuilder.Entity("DoctorWhoDomain.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"));

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Null");

                    b.Property<string>("EnemyName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "Desires Power",
                            EnemyName = "Za"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "Desires Power",
                            EnemyName = "Kal"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "Desires Earth invasion/Human extermination",
                            EnemyName = "Daleks"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "Wants to take control of the Conscience of Marinus in order to control the people of Marinus",
                            EnemyName = "Yartek"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "Wants to control a planet",
                            EnemyName = "Voord"
                        });
                });

            modelBuilder.Entity("DoctorWhoDomain.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("Null");

                    b.Property<int>("EpisodeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Null");

                    b.Property<int>("SeriesNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Null");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Mystery",
                            SeriesNumber = 1,
                            Title = "An Unearthly Child"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Mystery",
                            SeriesNumber = 1,
                            Title = "The Cave of Skulls"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Mystery",
                            SeriesNumber = 1,
                            Title = "The Forest of Fear"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 2,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Mystery",
                            SeriesNumber = 1,
                            Title = "The Firemake"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 3,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Mystery",
                            SeriesNumber = 1,
                            Title = "The Dead Planet"
                        },
                        new
                        {
                            EpisodeId = 6,
                            AuthorId = 3,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Mystery",
                            SeriesNumber = 1,
                            Title = "Survicors"
                        });
                });

            modelBuilder.Entity("DoctorWhoDomain.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"));

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 1,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 6,
                            CompanionId = 2,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 7,
                            CompanionId = 4,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeCompanionId = 8,
                            CompanionId = 1,
                            EpisodeId = 6
                        },
                        new
                        {
                            EpisodeCompanionId = 9,
                            CompanionId = 2,
                            EpisodeId = 6
                        },
                        new
                        {
                            EpisodeCompanionId = 10,
                            CompanionId = 3,
                            EpisodeId = 6
                        });
                });

            modelBuilder.Entity("DoctorWhoDomain.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"));

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 2,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 6,
                            EnemyId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 7,
                            EnemyId = 1,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 8,
                            EnemyId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 9,
                            EnemyId = 1,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeEnemyId = 10,
                            EnemyId = 3,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeEnemyId = 11,
                            EnemyId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWhoDomain.Episode", b =>
                {
                    b.HasOne("DoctorWhoDomain.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhoDomain.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWhoDomain.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWhoDomain.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhoDomain.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWhoDomain.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWhoDomain.Enemy", "Enemy")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWhoDomain.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWhoDomain.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWhoDomain.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWhoDomain.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWhoDomain.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWhoDomain.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
