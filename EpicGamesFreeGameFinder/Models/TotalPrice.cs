namespace EpicGamesFreeGameFinder.Models
{
    public class TotalPrice    {
        public int discountPrice { get; set; } 
        public int originalPrice { get; set; } 
        public int voucherDiscount { get; set; } 
        public int discount { get; set; } 
        public string currencyCode { get; set; } 
        public CurrencyInfo currencyInfo { get; set; } 
        public FmtPrice fmtPrice { get; set; } 
    }
}