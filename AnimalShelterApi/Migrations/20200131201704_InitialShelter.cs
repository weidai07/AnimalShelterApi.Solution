using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Solution.Migrations
{
    public partial class InitialShelter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cats = table.Column<string>(nullable: true),
                    Dogs = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "AnimalId", "Cats", "Dogs", "Quantity" },
                values: new object[,]
                {
                    { 121, "Brown", "Corgi", 51 },
                    { 131, "White", "Lab", 61 },
                    { 141, "Egyptian", "Retriever", 71 },
                    { 151, "Grey", "Pug", 81 },
                    { 161, "Orange", "Chihuahua", 91 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");
        }
    }
}
