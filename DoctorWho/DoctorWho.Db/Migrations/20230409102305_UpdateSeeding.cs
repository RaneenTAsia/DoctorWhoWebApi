using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(1966, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(1970, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1973, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(1974, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { new DateTime(1982, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2,
                column: "EpisodeNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3,
                column: "EpisodeNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4,
                column: "EpisodeNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "EpisodeNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 6,
                columns: new[] { "EpisodeNumber", "Title" },
                values: new object[] { 6, "Survivors" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "FirstEpisodeDate", "LastEpisodeDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 2,
                column: "EpisodeNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 3,
                column: "EpisodeNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 4,
                column: "EpisodeNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 5,
                column: "EpisodeNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "EpisodeId",
                keyValue: 6,
                columns: new[] { "EpisodeNumber", "Title" },
                values: new object[] { 1, "Survicors" });
        }
    }
}
