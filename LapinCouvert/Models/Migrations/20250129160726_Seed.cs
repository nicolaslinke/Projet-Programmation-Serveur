using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    PrixCoutant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false),
                    Categorie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.ProduitId);
                });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "ProduitId", "Categorie", "Description", "Disponible", "Image", "Nom", "Prix", "PrixCoutant", "Quantite" },
                values: new object[,]
                {
                    { 1, 0, " Le Caramilk est une barre chocolatée emblématique de la marque Cadbury, qui combine une riche et crémeuse chocolat au lait avec un délicieux cœur de caramel fondant. Sa texture unique est à la fois lisse et fondante, créant une expérience sucrée et gourmande. Le caramel, caché à l'intérieur, apporte une douceur subtile et une note sucrée intense qui se marie parfaitement avec le chocolat au lait.", true, "../../Images/Caramilk.png", "Caramilk", 2.75m, 3m, 5 },
                    { 2, 0, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/Gatorade Bleu Cool.png", "Gatorade Bleu", 3m, 3m, 4 },
                    { 3, 0, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/Guru Original.png", "Guru", 4.50m, 3m, 6 },
                    { 4, 2, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/KitKat.png", "KitKat", 2.25m, 3m, 25 },
                    { 5, 0, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/Lait protéiné Fairlife Chocolat.png", "Lait protéiné Fairlife", 4.50m, 3m, 2 },
                    { 6, 1, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/McCain Pizza Pochette au pepperoni.png", "Pizza Pochette au pepperoni", 2.50m, 3m, 46 },
                    { 7, 0, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/Monster Original.png", "Monster Original", 3.50m, 3m, 4 },
                    { 8, 0, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/Peace Tea Original.png", "Peace Tea Original", 1.50m, 3m, 16 },
                    { 9, 1, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/Pogo.png", "Pogo", 3.50m, 3m, 65 },
                    { 10, 0, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/Red Bull Original.png", "Red Bull Original", 3m, 3m, 23 },
                    { 11, 1, "boisson électrolyte rafraîchissante au goût fruité", true, "../../Images/Soupe aux nouilles Shin.png", "Soupr aux nouilles Shin", 4.50m, 3m, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");
        }
    }
}
