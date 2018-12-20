using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace newsapp.Models
{
    public class NewsAppDbContext : DbContext
    {
        public NewsAppDbContext(DbContextOptions<NewsAppDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Article
            modelBuilder.Entity<Article>()
                        .HasKey(x=>x.ArticleId);
            modelBuilder.Entity<Article>()
                        .Property(x=>x.ArticleId)
                        .ValueGeneratedOnAdd();
            modelBuilder.Entity<Article>()
                        .Property(x=>x.Title)
                        .IsRequired();
            modelBuilder.Entity<Article>()
                        .Property(x=>x.Content)
                        .IsRequired();
            modelBuilder.Entity<Article>()
                        .Property(x=>x.Image)
                        .IsRequired();
            modelBuilder.Entity<Article>()
                        .HasData(new Article{
                            ArticleId = 1,
                            Title = "Nueva pierna robotica para jugar futbol",
                            Content = "<p>Cientificos de Inglaterra inventan una nueva pierna robotica para futbolistas</p>",
                            Image = "https://ecuadorwillana.com/wp-content/uploads/2017/07/robot_futbolistas.jpg",
                            Published = DateTime.Now.AddDays(-7)
                        }, new Article{
                            ArticleId = 2,
                            Title = "Presidente de Dinamarca visita Brasil",
                            Content = "<p>Este fin de semana el presidente de Dinamarca visito la capital de Brasil para firmar un acuerdo de paz con el presidente de este pais...</p>",
                            Image = "https://www.elpais.com.co/files/article_main_small/uploads/2018/04/10/5acd8e568a834.jpeg",
                            Published = DateTime.Now.AddDays(-7)
                        }, new Article{
                            ArticleId = 3,
                            Title = "Acciones de Amazon.com bajan mas de un 2% por semana",
                            Content = "<p>El gigante de las compras en lineas ha tenido una mala racha este año y sus acciones van en picada</p>",
                            Image = "https://style.shockvisual.net/wp-content/uploads/2018/05/Amazon.jpg",
                            Published = DateTime.Now.AddDays(-6)
                        }, new Article{
                            ArticleId = 4,
                            Title = "Huawei lanza nuevo telefono para no videntes",
                            Content = "<p>El fabricante de telefonos lanzo al mercado el dia de hoy un nuevo telefono inteligente para no videntes</p>",
                            Image = "https://andro4all.com/files/2018/06/Huawei-P20.jpg",
                            Published = DateTime.Now.AddDays(-6)
                        }, new Article{
                            ArticleId = 5,
                            Title = "¿Realmente sirven las dietas para bajar de peso?",
                            Content = "<p>Expertos en nutricion explican por que las dietas realmente no te ayudan a bajar de peso</p>",
                            Image = "http://as01.epimg.net/deporteyvida/imagenes/2017/08/25/portada/1503656601_282453_1503656815_noticia_normal.jpg",
                            Published = DateTime.Now.AddDays(-6)
                        }, new Article{
                            ArticleId = 6,
                            Title = "Terremoto en Australia",
                            Content = "<p>Un fuerte sismo de 8.8 sacude las tierras Australianas dejando varios heridos y desaparecidos</p>",
                            Image = "https://miamidiario.com/wp-content/uploads/2018/12/shutterstock_529014751-890x395_c.jpg",
                            Published = DateTime.Now.AddDays(-5)
                        }, new Article{
                            ArticleId = 7,
                            Title = "Policia de Mexico captura narcotraficantes en frontera",
                            Content = "<p>La Policia de Mexico capturo este lunes a las cabezas de una de las bandas de narcotraficantes mas peligrosas de la region en la frontera con USA.</p>",
                            Image = "https://www.ecestaticos.com/imagestatic/clipping/d1c/ef6/d1cef69a0c3246ed5d0725b153bb7deb/un-enfrentamiento-entre-narcos-y-policias-deja-43-muertos-en-mexico.jpg?mtime=1432325695",
                            Published = DateTime.Now.AddDays(-5)
                        }, new Article{
                            ArticleId = 8,
                            Title = "Resultados de Miss Universo 2018",
                            Content = "<p>El famoso certamen de belleza finalizo este año con uno de los resultados mas inesperados de los ultimos años.</p>",
                            Image = "https://media.metrolatam.com/2018/12/17/missuniversocatrionagray-2eced66d1f28b9bc8ec17def1fe899f1-1200x600.jpg",
                            Published = DateTime.Now.AddDays(-4)
                        }, new Article{
                            ArticleId = 9,
                            Title = "Cientificos descubren la cura contra la gripe",
                            Content = "<p>Un grupo de cientificos japoneses anunciaron que descubrieron la cura definitiva para la gripe.</p>",
                            Image = "https://pijamasurf.com/wp-content/uploads/10.208.149.45/uploads/cache/2015/03/cience1/2569612364.jpg",
                            Published = DateTime.Now.AddDays(-3)
                        }, new Article{
                            ArticleId = 10,
                            Title = "Descubren una flor fosil a orillas del lago Xolotlan",
                            Content = "<p>Un grupo de estudiantes de biologia de la Universidad Nacional Autonoma de Nicaragua descubren el fosil de una flor a orillas del lago Xolotlan</p>",
                            Image = "https://img.europapress.es/fotoweb/fotonoticia_20170511132704_644.jpg",
                            Published = DateTime.Now.AddDays(-2)
                        });
            #endregion

            #region Category
            modelBuilder.Entity<Category>()
                        .HasKey(x=>x.CategoryId);
            modelBuilder.Entity<Category>()
                        .Property(x=>x.CategoryId)
                        .ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>()
                        .Property(x=>x.Name)
                        .IsRequired();
            modelBuilder.Entity<Category>()
                        .HasData(new Category(){
                            CategoryId = 1,
                            Name = "destacado"
                        }, new Category(){
                            CategoryId = 2,
                            Name = "tecnologia"
                        }, new Category(){
                            CategoryId = 3,
                            Name = "economia"
                        }, new Category(){
                            CategoryId = 4,
                            Name = "ciencia"
                        }, new Category(){
                            CategoryId = 5,
                            Name = "internacionales"
                        }, new Category(){
                            CategoryId = 6,
                            Name = "deporte"
                        }, new Category(){
                            CategoryId = 7,
                            Name = "salud"
                        });
            #endregion

            #region ArticleCategory
            modelBuilder.Entity<ArticleCategory>()
                        .HasKey(x=>new {x.ArticleId, x.CategoryId});
            modelBuilder.Entity<ArticleCategory>()
                        .HasOne(x=>x.Article)
                        .WithMany(x=>x.ArticleCategories)
                        /*.HasForeignKey(x=>x.ArticleId)*/;
            modelBuilder.Entity<ArticleCategory>()
                        .HasOne(x=>x.Category)
                        .WithMany(x=>x.ArticleCategories)
                        /*.HasForeignKey(x=>x.CategoryId)*/;
            modelBuilder.Entity<ArticleCategory>()
                        .HasData(new ArticleCategory{
                            ArticleId = 1,
                            CategoryId = 2
                        }, new ArticleCategory{
                            ArticleId = 1,
                            CategoryId = 6
                        }, new ArticleCategory{
                            ArticleId = 2,
                            CategoryId = 1
                        }, new ArticleCategory{
                            ArticleId = 2,
                            CategoryId = 5
                        }, new ArticleCategory{
                            ArticleId = 3,
                            CategoryId = 1
                        }, new ArticleCategory{
                            ArticleId = 3,
                            CategoryId = 2
                        }, new ArticleCategory{
                            ArticleId = 4,
                            CategoryId = 1
                        }, new ArticleCategory{
                            ArticleId = 4,
                            CategoryId = 2
                        }, new ArticleCategory{
                            ArticleId = 5,
                            CategoryId = 4
                        }, new ArticleCategory{
                            ArticleId = 5,
                            CategoryId = 7
                        }, new ArticleCategory{
                            ArticleId = 6,
                            CategoryId = 1
                        }, new ArticleCategory{
                            ArticleId = 6,
                            CategoryId = 5
                        }, new ArticleCategory{
                            ArticleId = 7,
                            CategoryId = 1
                        }, new ArticleCategory{
                            ArticleId = 7,
                            CategoryId = 5
                        }, new ArticleCategory{
                            ArticleId = 8,
                            CategoryId = 5
                        }, new ArticleCategory{
                            ArticleId = 8,
                            CategoryId = 7
                        }, new ArticleCategory{
                            ArticleId = 9,
                            CategoryId = 4
                        }, new ArticleCategory{
                            ArticleId = 9,
                            CategoryId = 7
                        }, new ArticleCategory{
                            ArticleId = 10,
                            CategoryId = 2
                        }, new ArticleCategory{
                            ArticleId = 10,
                            CategoryId = 4
                        });
            #endregion
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}