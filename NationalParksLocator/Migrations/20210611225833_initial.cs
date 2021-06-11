using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParksLocator.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    State = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    YearFounded = table.Column<int>(type: "int", nullable: false),
                    YearlyVisitors = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State", "YearFounded", "YearlyVisitors" },
                values: new object[,]
                {
                    { 1, "Acadia", "Maine", 1919, "3,500,000" },
                    { 2, "American Samoa", "American Samoa", 1988, "60,000" },
                    { 3, "Arches", "Utah", 1971, "1,600,000" },
                    { 4, "Badlands", "South Dakota", 1978, "970,000" },
                    { 5, "Big Bend", "Texas", 1944, "460,000" },
                    { 6, "Biscayne", "Florida", 1980, "700,000" },
                    { 7, "Black Canyon of the Gunnison", "Colorado", 1999, "432,000" },
                    { 8, "Bryce Canyon", "Utah", 1928, "2,500,000" },
                    { 9, "Canyonlands", "Utah", 1964, "733,000" },
                    { 10, "Capitol Reef", "Utah", 1930, "1,200,000" },
                    { 11, "Carlsbad Caverns", "New Mexico", 1930, "440,000" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
