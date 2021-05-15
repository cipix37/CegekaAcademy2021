using Microsoft.EntityFrameworkCore.Migrations;

namespace TemaS2MiercuriV2
{
    public partial class CreateZipcodeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zipcode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    County = table.Column<string>(maxLength: 20, nullable: false),
                    City = table.Column<string>(maxLength: 20, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zipcode", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zipcode");
        }
    }
}
