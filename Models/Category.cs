
using System.Collections.Generic;

namespace newsapp.Models
{
    public class Category{
        public int CategoryId{get;set;}
        public string Name{get;set;}
        public List<ArticleCategory> ArticleCategories{get;set;}
    }
}