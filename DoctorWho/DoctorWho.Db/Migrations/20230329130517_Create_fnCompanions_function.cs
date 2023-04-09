using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class Create_fnCompanions_function : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE FUNCTION fnCompanions(@EpisodeId INT)
                RETURNS VARCHAR(MAX) AS 
	                BEGIN
		                DECLARE @Result VARCHAR(MAX) = ''

		                SELECT @Result = @Result + C.CompanionName + ', '
		                From Companions As C
		                INNER JOIN EpisodeCompanions AS EC
			                ON EC.CompanionId = C.CompanionID
			                WHERE EC.EpisodeId = @EpisodeId
		                RETURN @RESULT
	                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION fnCompanions");
        }
    }
}
