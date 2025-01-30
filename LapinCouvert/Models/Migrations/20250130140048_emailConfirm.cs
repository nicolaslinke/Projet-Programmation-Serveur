using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class emailConfirm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ac5e64f-8c09-40dc-aeb7-31722c90c607", true, "AQAAAAIAAYagAAAAEKL6nJb12o4n5WE7xO0Yb+q2/In+Tu6UK1IXnG5+lTfKXx5dV5gZTrjHEk9pYFS1Jw==", "8b450ed1-63f7-4edc-957a-79bb2b1e0ce9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "938da985-f2b6-4297-a242-86ca7a2a7da8", false, "AQAAAAIAAYagAAAAEFBeD4qWrCvm2tpXP9bozfHT46xzWObXPb6WlYn6ojg8ZTSm8R1jvTd4zkDFTjLZ5Q==", "c0765b40-d2b0-4516-b903-5890ffb7271a" });
        }
    }
}
