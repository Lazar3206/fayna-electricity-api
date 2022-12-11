using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Electricity.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateElectricityDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricitySwitchRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectricitySwithRecordKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SwitchType = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricitySwitchRecord", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricitySwitchRecord");
        }
    }
}
