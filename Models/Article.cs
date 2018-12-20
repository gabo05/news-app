using System;
using System.Collections.Generic;

namespace newsapp.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content{get;set;}
        public string Image{get;set;}
        public DateTime Published{get;set;}
        public List<ArticleCategory> ArticleCategories{get;set;}
    }
}