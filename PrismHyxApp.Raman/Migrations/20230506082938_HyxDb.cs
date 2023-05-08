using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrismHyxApp.Raman.Migrations
{
    /// <inheritdoc />
    public partial class HyxDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OilInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OilNo = table.Column<string>(type: "TEXT", nullable: true),
                    OilType = table.Column<string>(type: "TEXT", nullable: true),
                    SpectrumInfo = table.Column<string>(type: "TEXT", nullable: true),
                    PredictValue = table.Column<string>(type: "TEXT", nullable: true),
                    SampleDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SamplePart = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OilInfo",
                columns: new[] { "Id", "Name", "OilNo", "OilType", "PredictValue", "SampleDate", "SamplePart", "SpectrumInfo" },
                values: new object[,]
                {
                    { 1, "0#车柴", null, "{\"TypeName\":\"柴油\",\"GradeName\":\"0#\"}", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, "-35#军柴", null, "{\"TypeName\":\"柴油\",\"GradeName\":\"-35#\"}", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 3, "-50#军柴", null, "{\"TypeName\":\"柴油\",\"GradeName\":\"-50#\"}", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 4, "茂名通用喷气燃料", null, "{\"TypeName\":\"航煤\",\"GradeName\":\"3#喷气燃料\"}", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 5, "高闪点-驱三", null, "{\"TypeName\":\"航煤\",\"GradeName\":\"高闪点喷气燃料\"}", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OilInfo");
        }
    }
}
