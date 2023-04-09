using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class SeedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Anthony Coburn" },
                    { 2, "Terry Nation" },
                    { 3, "John Lucarotti" },
                    { 4, "Peter R. Newman" },
                    { 5, "Dennis Spooner" }
                });

            migrationBuilder.InsertData(
                table: "Companions",
                columns: new[] { "CompanionId", "CompanionName", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Barbara Wright", "Jacqueline Hill" },
                    { 2, "Ian Chesterton", "Willim Russel" },
                    { 3, "Susan Foreman", "Carole Ann Ford" },
                    { 4, "Vicki", "Maureen O'Brien" },
                    { 5, "Steven Taylor", "Peter Purves" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "DoctorName", "DoctorNumber" },
                values: new object[,]
                {
                    { 1, "The First Doctor", 1 },
                    { 2, "The Second Doctor", 2 },
                    { 3, "The Third Doctor", 3 },
                    { 4, "The Fourth Doctor", 4 },
                    { 5, "The Fifth Doctor", 5 }
                });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyId", "Description", "EnemyName" },
                values: new object[,]
                {
                    { 1, "Desires Power", "Za" },
                    { 2, "Desires Power", "Kal" },
                    { 3, "Desires Earth invasion/Human extermination", "Daleks" },
                    { 4, "Wants to take control of the Conscience of Marinus in order to control the people of Marinus", "Yartek" },
                    { 5, "Wants to control a planet", "Voord" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "EpisodeId", "AuthorId", "DoctorId", "EpisodeDate", "EpisodeNumber", "EpisodeType", "SeriesNumber", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(1963, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mystery", 1, "An Unearthly Child" },
                    { 2, 1, 1, new DateTime(1963, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Mystery", 1, "The Cave of Skulls" },
                    { 3, 1, 1, new DateTime(1963, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mystery", 1, "The Forest of Fear" },
                    { 4, 2, 1, new DateTime(1963, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Mystery", 1, "The Firemake" },
                    { 5, 3, 1, new DateTime(1963, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Mystery", 1, "The Dead Planet" },
                    { 6, 3, 1, new DateTime(1963, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Mystery", 1, "Survivors" }
                });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeCompanionId", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 2 },
                    { 4, 3, 3 },
                    { 5, 1, 4 },
                    { 6, 2, 4 },
                    { 7, 4, 5 },
                    { 8, 1, 6 },
                    { 9, 2, 6 },
                    { 10, 3, 6 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeEnemyId", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 2 },
                    { 5, 2, 3 },
                    { 6, 3, 3 },
                    { 7, 1, 4 },
                    { 8, 4, 4 },
                    { 9, 1, 5 },
                    { 10, 3, 5 },
                    { 11, 5, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companions",
                keyColumn: "CompanionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);
        }
    }
}
