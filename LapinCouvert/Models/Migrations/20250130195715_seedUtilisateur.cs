using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class seedUtilisateur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b07de285-edfd-4a2e-801f-86b7578855b6", "AQAAAAIAAYagAAAAEJjCWcP0hJAEY8hvv/uRqa+2v0jz76jzNy9cgd18qUNPA1x6Yvlvl6Z5VAHYb20VfQ==", "90973882-fb8b-44fa-9f24-addfce4c832f" });

            migrationBuilder.InsertData(
                table: "Utilisateurs",
                columns: new[] { "Id", "Matricule", "Nom", "Prenom", "UserId" },
                values: new object[] { 1, "1111111", "a", "a", "11111111-1111-1111-1111-111111111111" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Utilisateurs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5219d7c4-b8ca-4424-8645-4c28035814af", "AQAAAAIAAYagAAAAEHE9LzJu+ou9ulx9KasO/J+PtwAYK3uRJOM6ar/TdgHklE3x3eRu/3PWC+W8yUTehA==", "dcecb760-4d64-4abb-aa4d-4903d4a401ce" });
        }
    }
}
