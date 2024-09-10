using WooDopShop_Models.Enums;

namespace WooDopShop_Models
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public RentalType RentalType { get; set; }
        public List<Item> Items { get; set; }
        public Customer User { get; set; }

        public Contract()
        {
            Items = new List<Item>();
            StartDate = DateTime.Now;
        }
    }
}
