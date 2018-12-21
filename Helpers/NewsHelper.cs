using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using newsapp.Models;
using newsapp.ViewModels;

namespace newsapp.Helpers{
    public interface INewsHelper{
        IEnumerable<ArticleViewModel> GetFeaturedNews(int limit);
        IEnumerable<ArticleViewModel> Search(SearchViewModel search);
        ArticleViewModel GetById(int id);
    }
    public class NewsHelper: INewsHelper{
        protected NewsAppDbContext DbContext{get;set;}
        public NewsHelper(NewsAppDbContext DbContext){
            this.DbContext = DbContext;
        }

        public IEnumerable<ArticleViewModel> GetFeaturedNews(int limit)
        {
            var result = DbContext.Articles
                                .Where(x=>x.ArticleCategories.Any(y=>y.CategoryId == 1))
                                .Select(x=> new ArticleViewModel(){
                                    Id = x.ArticleId,
                                    Title = x.Title,
                                    Content = x.Content,
                                    Image = x.Image,
                                    Published = x.Published,
                                    Categories = x.ArticleCategories.Select(y=>y.Category.Name)
                                })
                                .OrderByDescending(x=>x.Published)
                                .Take(limit);

            return result.ToList();
        }

        public IEnumerable<ArticleViewModel> Search(SearchViewModel search)
        {
            if(String.IsNullOrEmpty(search.Query) && !search.Start.HasValue && !search.End.HasValue && !search.Limit.HasValue)
                return new List<ArticleViewModel>();

            var result = DbContext.Articles
                            .Where(x=>EF.Functions.Like(x.Title, $"%{(search.Query??"").Replace(" ", "%")}%") && (!search.Start.HasValue || x.Published >= search.Start) && (!search.End.HasValue || x.Published <= search.End))
                            .Select(x=>new ArticleViewModel(){
                                Id = x.ArticleId,
                                Title = x.Title,
                                Content = x.Content,
                                Image = x.Image,
                                Published = x.Published,
                                Categories = x.ArticleCategories.Select(y=>y.Category.Name)
                            })
                            .OrderByDescending(x=>x.Published)
                            .Take(search.Limit ?? 10);

            return result.ToList();
        }
        public ArticleViewModel GetById(int id){
            var result = DbContext.Articles.Where(x=>x.ArticleId == id)
                            .Select(x=>new ArticleViewModel(){
                                Id = x.ArticleId,
                                Title = x.Title,
                                Content = x.Content,
                                Image = x.Image,
                                Published = x.Published,
                                Categories = x.ArticleCategories.Select(y=>y.Category.Name)
                            }).FirstOrDefault();
            return result;
        }
    }
}