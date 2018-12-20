using System;
using System.Collections.Generic;

namespace newsapp.ViewModels{
    public class ArticleViewModel{
        public string Title { get; set; }
        public string Content{get;set;}
        public string Image{get;set;}
        public DateTime Published{get;set;}
        public IEnumerable<string> Categories{get;set;}

    }
}