using System.Collections.Generic;

namespace EpicGamesFreeGameFinder.Models
{
    public class CacheControl    {
        public int version { get; set; } 
        public List<Hint> hints { get; set; } 
    }
}