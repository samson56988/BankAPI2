using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankAPI2.Migrations
{
    public partial class intialmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccoutNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardType = table.Column<int>(type: "int", nullable: false),
                    DeleiveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardRequests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardRequests");
        }
    }
}
