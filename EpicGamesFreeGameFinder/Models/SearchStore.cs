using System.Collections.Generic;

namespace EpicGamesFreeGameFinder.Models
{
    public class SearchStore    {
        public List<Element> elements { get; set; } 
        public Paging paging { get; set; } 
    }
}