using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using newsapp.Helpers;
using newsapp.Models;
using newsapp.ViewModels;

namespace newsapp.Controllers{
    public class NewsController: Controller{
        protected INewsHelper Helper{get;set;}
        public NewsController(INewsHelper Helper){
            this.Helper = Helper;
        }
        public IEnumerable<ArticleViewModel> Featured(int id = 3){
            return Helper.GetFeaturedNews(id);
        }
        public IEnumerable<ArticleViewModel> Search(SearchViewModel search){
            return Helper.Search(search);
        }
        public IActionResult Index(){
            return View();
        }
        public IActionResult Article(int id){
            var model = Helper.GetById(id);

            return View(model);
        }
    }
}