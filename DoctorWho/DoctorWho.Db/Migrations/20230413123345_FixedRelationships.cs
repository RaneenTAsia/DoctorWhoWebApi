using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class FixedRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeEnemies",
                table: "EpisodeEnemies");

            migrationBuilder.DropIndex(
                name: "IX_EpisodeEnemies_EpisodeId",
                table: "EpisodeEnemies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeCompanions",
                table: "EpisodeCompanions");

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumn: "EpisodeCompanionId",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumn: "EpisodeEnemyId",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "EpisodeEnemyId",
                table: "EpisodeEnemies");

            migrationBuilder.DropColumn(
                name: "EpisodeCompanionId",
                table: "EpisodeCompanions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeEnemies",
                table: "EpisodeEnemies",
                columns: new[] { "EpisodeId", "EnemyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeCompanions",
                table: "EpisodeCompanions",
                columns: new[] { "EpisodeId", "CompanionId" });

            migrationBuilder.InsertData(
                table: "EpisodeCompanions",
                columns: new[] { "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 4, 5 },
                    { 1, 6 },
                    { 2, 6 },
                    { 3, 6 }
                });

            migrationBuilder.InsertData(
                table: "EpisodeEnemies",
                columns: new[] { "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 1, 4 },
                    { 4, 4 },
                    { 1, 5 },
                    { 3, 5 },
                    { 5, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeEnemies",
                table: "EpisodeEnemies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EpisodeCompanions",
                table: "EpisodeCompanions");

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "EpisodeCompanions",
                keyColumns: new[] { "CompanionId", "EpisodeId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "EpisodeEnemies",
                keyColumns: new[] { "EnemyId", "EpisodeId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.AddColumn<int>(
                name: "EpisodeEnemyId",
                table: "EpisodeEnemies",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EpisodeCompanionId",
                table: "EpisodeCompanions",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeEnemies",
                table: "EpisodeEnemies",
                column: "EpisodeEnemyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EpisodeCompanions",
                table: "EpisodeCompanions",
                column: "EpisodeCompanionId");

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

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeEnemies_EpisodeId",
                table: "EpisodeEnemies",
                column: "EpisodeId");
        }
    }
}
