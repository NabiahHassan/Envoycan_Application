using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Envoycan_Application.Migrations
{
    /// <inheritdoc />
    public partial class EnvoycanApplicationDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACRepair",
                columns: table => new
                {
                    ACRepairID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACRepairName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACRepair", x => x.ACRepairID);
                });

            migrationBuilder.CreateTable(
                name: "Carpenter",
                columns: table => new
                {
                    CarpenterServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarpenterServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carpenter", x => x.CarpenterServiceID);
                });

            migrationBuilder.CreateTable(
                name: "HouseCleaning",
                columns: table => new
                {
                    HouseCleaningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseCleaningName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseCleaning", x => x.HouseCleaningID);
                });

            migrationBuilder.CreateTable(
                name: "Painter",
                columns: table => new
                {
                    PainterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PainterName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Painter", x => x.PainterID);
                });

            migrationBuilder.CreateTable(
                name: "PestControl",
                columns: table => new
                {
                    PestControlID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PestControlName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PestControl", x => x.PestControlID);
                });

            migrationBuilder.CreateTable(
                name: "Plumber",
                columns: table => new
                {
                    PlumberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlumberName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plumber", x => x.PlumberID);
                });

            migrationBuilder.CreateTable(
                name: "Salon",
                columns: table => new
                {
                    SalonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalonName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salon", x => x.SalonID);
                });

            migrationBuilder.CreateTable(
                name: "SmartHome",
                columns: table => new
                {
                    SmartHomeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmartHomeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartHome", x => x.SmartHomeID);
                });

            migrationBuilder.CreateTable(
                name: "User_registration",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_registration", x => x.UserID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACRepair");

            migrationBuilder.DropTable(
                name: "Carpenter");

            migrationBuilder.DropTable(
                name: "HouseCleaning");

            migrationBuilder.DropTable(
                name: "Painter");

            migrationBuilder.DropTable(
                name: "PestControl");

            migrationBuilder.DropTable(
                name: "Plumber");

            migrationBuilder.DropTable(
                name: "Salon");

            migrationBuilder.DropTable(
                name: "SmartHome");

            migrationBuilder.DropTable(
                name: "User_registration");
        }
    }
}
