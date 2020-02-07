using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 121,
                columns: new[] { "Cats", "Quantity" },
                values: new object[] { "Bengal", 3 });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 131,
                columns: new[] { "Cats", "Quantity" },
                values: new object[] { "Ragdoll", 1 });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 141,
                columns: new[] { "Cats", "Quantity" },
                values: new object[] { "Birman", 2 });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 151,
                columns: new[] { "Cats", "Dogs", "Quantity" },
                values: new object[] { "Persian", "Husky", 4 });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 161,
                columns: new[] { "Cats", "Quantity" },
                values: new object[] { "Sphynx", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 121,
                columns: new[] { "Cats", "Quantity" },
                values: new object[] { "Brown", 51 });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 131,
                columns: new[] { "Cats", "Quantity" },
                values: new object[] { "White", 61 });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 141,
                columns: new[] { "Cats", "Quantity" },
                values: new object[] { "Egyptian", 71 });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 151,
                columns: new[] { "Cats", "Dogs", "Quantity" },
                values: new object[] { "Grey", "Pug", 81 });

            migrationBuilder.UpdateData(
                table: "Animal",
                keyColumn: "AnimalId",
                keyValue: 161,
                columns: new[] { "Cats", "Quantity" },
                values: new object[] { "Orange", 91 });
        }
    }
}
