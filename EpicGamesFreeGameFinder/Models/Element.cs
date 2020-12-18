using System;
using System.Collections.Generic;

namespace EpicGamesFreeGameFinder.Models
{
    public class Element    {
        public string title { get; set; } 
        public string id { get; set; } 
        public string @namespace { get; set; } 
        public string description { get; set; } 
        public DateTime effectiveDate { get; set; } 
        public List<KeyImage> keyImages { get; set; } 
        public int currentPrice { get; set; } 
        public Seller seller { get; set; } 
        public string productSlug { get; set; } 
        public string urlSlug { get; set; } 
        public object url { get; set; } 
        public List<Tag> tags { get; set; } 
        public List<Item> items { get; set; } 
        public List<CustomAttribute> customAttributes { get; set; } 
        public List<Category> categories { get; set; } 
        public Price price { get; set; } 
    }
}