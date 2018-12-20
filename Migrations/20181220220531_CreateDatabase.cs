using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace newsapp.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Published = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => new { x.ArticleId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ArticleCategory_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 1, "<p>Cientificos de Inglaterra inventan una nueva pierna robotica para futbolistas</p>", "https://ecuadorwillana.com/wp-content/uploads/2017/07/robot_futbolistas.jpg", new DateTime(2018, 12, 13, 16, 5, 31, 344, DateTimeKind.Local).AddTicks(7820), "Nueva pierna robotica para jugar futbol" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 10, "<p>Un grupo de estudiantes de biologia de la Universidad Nacional Autonoma de Nicaragua descubren el fosil de una flor a orillas del lago Xolotlan</p>", "https://img.europapress.es/fotoweb/fotonoticia_20170511132704_644.jpg", new DateTime(2018, 12, 18, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7066), "Descubren una flor fosil a orillas del lago Xolotlan" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 8, "<p>El famoso certamen de belleza finalizo este año con uno de los resultados mas inesperados de los ultimos años.</p>", "https://media.metrolatam.com/2018/12/17/missuniversocatrionagray-2eced66d1f28b9bc8ec17def1fe899f1-1200x600.jpg", new DateTime(2018, 12, 16, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7063), "Resultados de Miss Universo 2018" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 7, "<p>La Policia de Mexico capturo este lunes a las cabezas de una de las bandas de narcotraficantes mas peligrosas de la region en la frontera con USA.</p>", "https://www.ecestaticos.com/imagestatic/clipping/d1c/ef6/d1cef69a0c3246ed5d0725b153bb7deb/un-enfrentamiento-entre-narcos-y-policias-deja-43-muertos-en-mexico.jpg?mtime=1432325695", new DateTime(2018, 12, 15, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7060), "Policia de Mexico captura narcotraficantes en frontera" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 6, "<p>Un fuerte sismo de 8.8 sacude las tierras Australianas dejando varios heridos y desaparecidos</p>", "https://miamidiario.com/wp-content/uploads/2018/12/shutterstock_529014751-890x395_c.jpg", new DateTime(2018, 12, 15, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7060), "Terremoto en Australia" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 9, "<p>Un grupo de cientificos japoneses anunciaron que descubrieron la cura definitiva para la gripe.</p>", "https://pijamasurf.com/wp-content/uploads/10.208.149.45/uploads/cache/2015/03/cience1/2569612364.jpg", new DateTime(2018, 12, 17, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7066), "Cientificos descubren la cura contra la gripe" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 4, "<p>El fabricante de telefonos lanzo al mercado el dia de hoy un nuevo telefono inteligente para no videntes</p>", "https://andro4all.com/files/2018/06/Huawei-P20.jpg", new DateTime(2018, 12, 14, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7057), "Huawei lanza nuevo telefono para no videntes" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 3, "<p>El gigante de las compras en lineas ha tenido una mala racha este año y sus acciones van en picada</p>", "https://style.shockvisual.net/wp-content/uploads/2018/05/Amazon.jpg", new DateTime(2018, 12, 14, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7057), "Acciones de Amazon.com bajan mas de un 2% por semana" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 2, "<p>Este fin de semana el presidente de Dinamarca visito la capital de Brasil para firmar un acuerdo de paz con el presidente de este pais...</p>", "https://www.elpais.com.co/files/article_main_small/uploads/2018/04/10/5acd8e568a834.jpeg", new DateTime(2018, 12, 13, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7047), "Presidente de Dinamarca visita Brasil" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Content", "Image", "Published", "Title" },
                values: new object[] { 5, "<p>Expertos en nutricion explican por que las dietas realmente no te ayudan a bajar de peso</p>", "http://as01.epimg.net/deporteyvida/imagenes/2017/08/25/portada/1503656601_282453_1503656815_noticia_normal.jpg", new DateTime(2018, 12, 14, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7060), "¿Realmente sirven las dietas para bajar de peso?" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 6, "deporte" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "destacado" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "tecnologia" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "economia" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 4, "ciencia" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 5, "internacionales" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 7, "salud" });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 5, 7 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 8, 5 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 7, 5 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 6, 5 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 10, 4 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 9, 4 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 10, 2 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 8, 7 });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[] { 9, 7 });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategory_CategoryId",
                table: "ArticleCategory",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
