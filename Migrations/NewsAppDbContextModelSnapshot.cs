﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using newsapp.Models;

namespace newsapp.Migrations
{
    [DbContext(typeof(NewsAppDbContext))]
    partial class NewsAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("newsapp.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<DateTime>("Published");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            Content = "<p>Cientificos de Inglaterra inventan una nueva pierna robotica para futbolistas</p>",
                            Image = "https://ecuadorwillana.com/wp-content/uploads/2017/07/robot_futbolistas.jpg",
                            Published = new DateTime(2018, 12, 13, 16, 5, 31, 344, DateTimeKind.Local).AddTicks(7820),
                            Title = "Nueva pierna robotica para jugar futbol"
                        },
                        new
                        {
                            ArticleId = 2,
                            Content = "<p>Este fin de semana el presidente de Dinamarca visito la capital de Brasil para firmar un acuerdo de paz con el presidente de este pais...</p>",
                            Image = "https://www.elpais.com.co/files/article_main_small/uploads/2018/04/10/5acd8e568a834.jpeg",
                            Published = new DateTime(2018, 12, 13, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7047),
                            Title = "Presidente de Dinamarca visita Brasil"
                        },
                        new
                        {
                            ArticleId = 3,
                            Content = "<p>El gigante de las compras en lineas ha tenido una mala racha este año y sus acciones van en picada</p>",
                            Image = "https://style.shockvisual.net/wp-content/uploads/2018/05/Amazon.jpg",
                            Published = new DateTime(2018, 12, 14, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7057),
                            Title = "Acciones de Amazon.com bajan mas de un 2% por semana"
                        },
                        new
                        {
                            ArticleId = 4,
                            Content = "<p>El fabricante de telefonos lanzo al mercado el dia de hoy un nuevo telefono inteligente para no videntes</p>",
                            Image = "https://andro4all.com/files/2018/06/Huawei-P20.jpg",
                            Published = new DateTime(2018, 12, 14, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7057),
                            Title = "Huawei lanza nuevo telefono para no videntes"
                        },
                        new
                        {
                            ArticleId = 5,
                            Content = "<p>Expertos en nutricion explican por que las dietas realmente no te ayudan a bajar de peso</p>",
                            Image = "http://as01.epimg.net/deporteyvida/imagenes/2017/08/25/portada/1503656601_282453_1503656815_noticia_normal.jpg",
                            Published = new DateTime(2018, 12, 14, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7060),
                            Title = "¿Realmente sirven las dietas para bajar de peso?"
                        },
                        new
                        {
                            ArticleId = 6,
                            Content = "<p>Un fuerte sismo de 8.8 sacude las tierras Australianas dejando varios heridos y desaparecidos</p>",
                            Image = "https://miamidiario.com/wp-content/uploads/2018/12/shutterstock_529014751-890x395_c.jpg",
                            Published = new DateTime(2018, 12, 15, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7060),
                            Title = "Terremoto en Australia"
                        },
                        new
                        {
                            ArticleId = 7,
                            Content = "<p>La Policia de Mexico capturo este lunes a las cabezas de una de las bandas de narcotraficantes mas peligrosas de la region en la frontera con USA.</p>",
                            Image = "https://www.ecestaticos.com/imagestatic/clipping/d1c/ef6/d1cef69a0c3246ed5d0725b153bb7deb/un-enfrentamiento-entre-narcos-y-policias-deja-43-muertos-en-mexico.jpg?mtime=1432325695",
                            Published = new DateTime(2018, 12, 15, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7060),
                            Title = "Policia de Mexico captura narcotraficantes en frontera"
                        },
                        new
                        {
                            ArticleId = 8,
                            Content = "<p>El famoso certamen de belleza finalizo este año con uno de los resultados mas inesperados de los ultimos años.</p>",
                            Image = "https://media.metrolatam.com/2018/12/17/missuniversocatrionagray-2eced66d1f28b9bc8ec17def1fe899f1-1200x600.jpg",
                            Published = new DateTime(2018, 12, 16, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7063),
                            Title = "Resultados de Miss Universo 2018"
                        },
                        new
                        {
                            ArticleId = 9,
                            Content = "<p>Un grupo de cientificos japoneses anunciaron que descubrieron la cura definitiva para la gripe.</p>",
                            Image = "https://pijamasurf.com/wp-content/uploads/10.208.149.45/uploads/cache/2015/03/cience1/2569612364.jpg",
                            Published = new DateTime(2018, 12, 17, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7066),
                            Title = "Cientificos descubren la cura contra la gripe"
                        },
                        new
                        {
                            ArticleId = 10,
                            Content = "<p>Un grupo de estudiantes de biologia de la Universidad Nacional Autonoma de Nicaragua descubren el fosil de una flor a orillas del lago Xolotlan</p>",
                            Image = "https://img.europapress.es/fotoweb/fotonoticia_20170511132704_644.jpg",
                            Published = new DateTime(2018, 12, 18, 16, 5, 31, 345, DateTimeKind.Local).AddTicks(7066),
                            Title = "Descubren una flor fosil a orillas del lago Xolotlan"
                        });
                });

            modelBuilder.Entity("newsapp.Models.ArticleCategory", b =>
                {
                    b.Property<int>("ArticleId");

                    b.Property<int>("CategoryId");

                    b.HasKey("ArticleId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ArticleCategory");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ArticleId = 1,
                            CategoryId = 6
                        },
                        new
                        {
                            ArticleId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ArticleId = 2,
                            CategoryId = 5
                        },
                        new
                        {
                            ArticleId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            ArticleId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            ArticleId = 4,
                            CategoryId = 1
                        },
                        new
                        {
                            ArticleId = 4,
                            CategoryId = 2
                        },
                        new
                        {
                            ArticleId = 5,
                            CategoryId = 4
                        },
                        new
                        {
                            ArticleId = 5,
                            CategoryId = 7
                        },
                        new
                        {
                            ArticleId = 6,
                            CategoryId = 1
                        },
                        new
                        {
                            ArticleId = 6,
                            CategoryId = 5
                        },
                        new
                        {
                            ArticleId = 7,
                            CategoryId = 1
                        },
                        new
                        {
                            ArticleId = 7,
                            CategoryId = 5
                        },
                        new
                        {
                            ArticleId = 8,
                            CategoryId = 5
                        },
                        new
                        {
                            ArticleId = 8,
                            CategoryId = 7
                        },
                        new
                        {
                            ArticleId = 9,
                            CategoryId = 4
                        },
                        new
                        {
                            ArticleId = 9,
                            CategoryId = 7
                        },
                        new
                        {
                            ArticleId = 10,
                            CategoryId = 2
                        },
                        new
                        {
                            ArticleId = 10,
                            CategoryId = 4
                        });
                });

            modelBuilder.Entity("newsapp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "destacado"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "tecnologia"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "economia"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "ciencia"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "internacionales"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "deporte"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "salud"
                        });
                });

            modelBuilder.Entity("newsapp.Models.ArticleCategory", b =>
                {
                    b.HasOne("newsapp.Models.Article", "Article")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("newsapp.Models.Category", "Category")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
