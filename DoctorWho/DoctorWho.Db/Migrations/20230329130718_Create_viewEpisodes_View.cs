using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    public partial class Create_viewEpisodes_View : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE VIEW viewEpisodes AS
	            SELECT E.SeriesNumber,
                       E.EpisodeNumber,
                       E.Title,
                       A.AuthorName,
                       D.DoctorName, 
                       dbo.fnCompanions(E.EpisodeId) AS Companions,
                       dbo.fnEnemies(E.EpisodeId) AS Enemies
	            FROM Episodes AS E
	            INNER JOIN Authors AS A ON E.AuthorId = A.AuthorId
	            INNER JOIN Doctors AS D ON E.DoctorId = D.DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW viewEpisodes");
        }
    }
}
