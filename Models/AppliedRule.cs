using System;

namespace EpicGamesFreeGameFinder.Models
{
    public class AppliedRule    {
        public string id { get; set; } 
        public DateTime endDate { get; set; } 
        public DiscountSetting discountSetting { get; set; } 
    }
}