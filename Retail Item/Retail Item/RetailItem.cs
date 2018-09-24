namespace Retail_Item
{
    public class RetailItem
    {
        //three properties for retail item objects
        public string Description { get; set; }
        public int UnitOnHand { get; set; }
        public decimal Price { get; set; }
        // creating constructor having parameters
        public RetailItem(string des,int unit,decimal price)
        {
            Description = des;
            UnitOnHand = unit;
            Price = price;
        }
    }
}
