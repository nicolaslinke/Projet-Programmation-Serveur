using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    PrixVendu = table.Column<decimal>(type: "numeric", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Quantite = table.Column<int>(type: "integer", nullable: false),
                    PrixCoutant = table.Column<decimal>(type: "numeric", nullable: false),
                    Disponible = table.Column<bool>(type: "boolean", nullable: false),
                    Categorie = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.ProduitId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Prenom = table.Column<string>(type: "text", nullable: false),
                    Matricule = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "11111111-1111-1111-1111-111111111111", 0, "a79343c6-183d-42ea-b17b-9b987ab51235", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEFcMXmWKD6aCwoYTCAS51KLQkufJL9ZVMU/fjnsNGQWu9xQufQCPxgWkwInfJLHbbQ==", null, false, "436ad574-e468-4ea1-934f-0dea9955bbc3", false, "a@a.a" });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "ProduitId", "Categorie", "Description", "Disponible", "Image", "Nom", "PrixCoutant", "PrixVendu", "Quantite" },
                values: new object[,]
                {
                    { 1, 2, "Une barre chocolatée Cadbury avec un cœur de caramel fondant enrobé de chocolat au lait.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Caramilk.png", "Caramilk", 2.00m, 2.75m, 5 },
                    { 2, 2, "Une barre chocolatée Nestlé avec un intérieur alvéolé unique.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Aero.png", "Aero", 1.80m, 2.50m, 10 },
                    { 3, 2, "Un délicieux beignet moelleux recouvert d'un glaçage au chocolat.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/BeigneChocolat.png", "Beigne au chocolat", 1.20m, 1.99m, 8 },
                    { 4, 1, "Un burrito garni de viande, fromage et légumes dans une tortilla souple.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Burrito.png", "Burrito", 4.00m, 5.50m, 6 },
                    { 5, 0, "Une boisson énergisante aux électrolytes pour une hydratation optimale.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/GatoradeBleu.png", "Gatorade Bleu Cool", 2.00m, 3.25m, 12 },
                    { 6, 0, "Une boisson énergisante naturelle avec caféine biologique.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/GuruOriginal.png", "Guru Original", 2.50m, 3.99m, 7 },
                    { 7, 2, "Une barre chocolatée avec des gaufrettes croustillantes enrobées de chocolat.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/KitKat.png", "KitKat", 1.80m, 2.75m, 9 },
                    { 8, 0, "Lait ultra-filtré riche en protéines avec une saveur chocolatée onctueuse.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/FairlifeChocolat.png", "Lait Protéiné Fairlife Chocolat", 3.00m, 4.50m, 10 },
                    { 9, 1, "Une pochette croustillante farcie de sauce tomate, fromage et pepperoni.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PizzaPochette.png", "McCain Pizza Pochette au Pepperoni", 3.25m, 4.99m, 6 },
                    { 10, 0, "Une boisson énergisante puissante avec une haute teneur en caféine.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/MonsterOriginal.png", "Monster Original", 2.50m, 3.99m, 8 },
                    { 11, 0, "Une version sans sucre de la célèbre boisson énergisante Monster.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/MonsterUltra.png", "Monster Ultra", 2.50m, 3.99m, 10 },
                    { 12, 2, "Un biscuit croustillant au chocolat fourré d’une crème sucrée.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Oreo.png", "Oreo", 2.00m, 3.25m, 10 },
                    { 13, 0, "Un thé glacé rafraîchissant au goût sucré et fruité.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PeaceTeaOriginal.png", "Peace Tea Original", 2.00m, 2.99m, 8 },
                    { 14, 1, "Une pizza garnie de sauce tomate, fromage et divers ingrédients.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PizzaPoivrons.png", "Pizza aux poivrons", 5.00m, 7.99m, 5 },
                    { 15, 1, "Un hot-dog sur bâton enrobé d'une pâte frite croustillante.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Pogo.png", "Pogo", 2.50m, 3.50m, 7 },
                    { 16, 1, "Des frites croustillantes recouvertes de fromage en grains et de sauce brune.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Poutine.png", "Poutine", 4.50m, 6.99m, 6 },
                    { 17, 0, "Une boisson hydratante à saveur de fraise et melon d’eau.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PrimeFraiseMelon.png", "Prime Fraise et Melon d'eau", 2.50m, 3.99m, 8 },
                    { 18, 0, "Une boisson énergisante classique pour un regain de vitalité.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/RedbullOriginal.png", "Redbull Original", 2.50m, 3.99m, 10 },
                    { 19, 1, "Un sandwich frais garni de tomates juteuses et d’assaisonnements.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SandwichTomates.png", "Sandwich aux tomates", 2.75m, 4.25m, 5 },
                    { 20, 1, "Une soupe instantanée épicée avec des nouilles et un bouillon savoureux.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SoupeShin.png", "Soupe aux nouilles Shin", 2.25m, 3.75m, 7 },
                    { 21, 2, "Des bonbons gélifiés acidulés puis sucrés pour une explosion de saveurs.", true, "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SourPatchKids.png", "Sour Patch Kids", 2.00m, 2.99m, 12 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_UserId",
                table: "Utilisateurs",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
