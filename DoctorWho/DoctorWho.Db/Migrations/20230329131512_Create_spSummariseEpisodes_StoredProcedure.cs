using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class Create_spSummariseEpisodes_StoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE PROCEDURE spSummariseEpisodes 
                AS BEGIN

                  SELECT TOP 3 C.CompanionName
                  From Companions AS C
                  INNER JOIN EpisodeCompanions AS EC
                  ON C.CompanionID = EC.CompanionId
                  GROUP BY EC.CompanionId, C.CompanionName
                  ORDER BY COUNT(EC.EpisodeId) DESC

                  SELECT E.EnemyName
                  From Enemies AS E
                  INNER JOIN EpisodeEnemies AS EE
                  ON E.EnemyId = EE.EnemyId
                  GROUP BY EE.EnemyId, E.EnemyName
                  ORDER BY COUNT(EpisodeId) DESC
                  OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY

                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE spSummariseEpisodes");
        }
    }
}
