using System;

namespace newsapp.ViewModels
{
    public class SearchViewModel{
        public string Query{get;set;}
        public DateTime? Start{get;set;}
        public DateTime? End{get;set;}
        public int? Limit{get;set;}
    }
}