using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdvancedCSharpClassProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotesToSitter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Food = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AqauticAnimals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Tank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LightIntensity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AqauticAnimals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AqauticAnimals_Animal_Id",
                        column: x => x.Id,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LandAnimals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    WaterInterval = table.Column<int>(type: "int", nullable: true),
                    Caged = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandAnimals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandAnimals_Animal_Id",
                        column: x => x.Id,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name", "Phone" },
                values: new object[] { 1, null, "John", null });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "Id", "Age", "Color", "Food", "Name", "NotesToSitter", "OwnerId" },
                values: new object[,]
                {
                    { -2, 7, "red", "Kibbles N' Bits", "TestAnimal2", "This is the second test note, please also take care of my dog", 1 },
                    { -1, 5, "Blue", "Fish Filet", "TestAnimal", "This is a test note, please take good care of my dog", 1 }
                });

            migrationBuilder.InsertData(
                table: "AqauticAnimals",
                columns: new[] { "Id", "LightIntensity", "Tank" },
                values: new object[] { -1, 67, "Large Tank" });

            migrationBuilder.InsertData(
                table: "LandAnimals",
                columns: new[] { "Id", "Caged", "WaterInterval" },
                values: new object[] { -2, true, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_OwnerId",
                table: "Animal",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AqauticAnimals");

            migrationBuilder.DropTable(
                name: "LandAnimals");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
