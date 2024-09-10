using WooDopShop_Models.Enums;

namespace WooDopShop_Models
{
    public class Item
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public ItemCategory Category { get; set; }
    }
}
