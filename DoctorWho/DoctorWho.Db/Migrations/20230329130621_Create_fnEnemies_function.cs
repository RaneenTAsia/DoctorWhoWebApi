using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class Create_fnEnemies_function : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE FUNCTION fnEnemies(@EpisodeId INT)
                RETURNS VARCHAR(MAX) AS 
	                BEGIN
		                DECLARE @Result VARCHAR(MAX) = ''

		                SELECT @Result = @Result + E.EnemyName + ', '
		                From Enemies As E
		                INNER JOIN EpisodeEnemies AS EE
			                ON EE.EnemyId = E.EnemyId
			                WHERE EE.EpisodeId = @EpisodeId
		                RETURN @RESULT
	                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION fnEnemies");
        }
    }
}

