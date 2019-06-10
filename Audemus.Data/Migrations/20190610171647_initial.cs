using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Audemus.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    StreetNumber = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    CityLocation = table.Column<string>(nullable: true),
                    StateLocation = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 13, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: false),
                    DateAttempted = table.Column<string>(nullable: true),
                    EmployeeContact = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
