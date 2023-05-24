using System.Collections.Generic;

namespace EpicGamesFreeGameFinder.Models
{
    public class Price    {
        public TotalPrice totalPrice { get; set; } 
        public List<LineOffer> lineOffers { get; set; } 
    }
}