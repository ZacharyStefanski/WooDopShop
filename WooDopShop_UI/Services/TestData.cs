using WooDopShop_Models.Enums;
using WooDopShop_Models;

namespace WooDopShop_UI.Services
{
    public class TestData
    {
        public List<Item> Inventory { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Contract> Contracts { get; set; }

        public TestData()
        {
            List<Item> items = new List<Item>
            {
                new Item { Id = 1, SerialNumber = "SN001", Name = "Guitar", Price = 15.99, Description = "Acoustic guitar", Quantity = 5, Category = ItemCategory.Strings },
                new Item { Id = 2, SerialNumber = "SN002", Name = "Piano", Price = 25.99, Description = "Electric piano", Quantity = 3, Category = ItemCategory.Keyboards },
                new Item { Id = 3, SerialNumber = "SN003", Name = "Drum Set", Price = 20.99, Description = "Full drum set", Quantity = 2, Category = ItemCategory.Drums },
                new Item { Id = 4, SerialNumber = "SN004", Name = "Violin", Price = 12.99, Description = "Classical violin", Quantity = 4, Category = ItemCategory.Strings },
                new Item { Id = 5, SerialNumber = "SN005", Name = "Flute", Price = 8.99, Description = "Silver flute", Quantity = 6, Category = ItemCategory.Woodwinds },
                new Item { Id = 6, SerialNumber = "SN006", Name = "Microphone", Price = 5.99, Description = "Dynamic microphone", Quantity = 10, Category = ItemCategory.Microphones },
                new Item { Id = 7, SerialNumber = "SN007", Name = "Guitar Strings", Price = 3.99, Description = "Set of guitar strings", Quantity = 15, Category = ItemCategory.Accessories },
                new Item { Id = 8, SerialNumber = "SN008", Name = "Piano Bench", Price = 7.99, Description = "Adjustable piano bench", Quantity = 5, Category = ItemCategory.Accessories },
                new Item { Id = 9, SerialNumber = "SN009", Name = "Drumsticks", Price = 2.99, Description = "Pair of drumsticks", Quantity = 20, Category = ItemCategory.Accessories },
                new Item { Id = 10, SerialNumber = "SN010", Name = "Violin Bow", Price = 6.99, Description = "Wooden violin bow", Quantity = 7, Category = ItemCategory.Accessories },
                new Item { Id = 11, SerialNumber = "SN011", Name = "Sheet Music Stand", Price = 4.99, Description = "Foldable sheet music stand", Quantity = 8, Category = ItemCategory.Stands },
                new Item { Id = 12, SerialNumber = "SN012", Name = "Guitar Amplifier", Price = 18.99, Description = "Electric guitar amplifier", Quantity = 3, Category = ItemCategory.Amplifiers },
                new Item { Id = 13, SerialNumber = "SN013", Name = "Keyboard Stand", Price = 9.99, Description = "Adjustable keyboard stand", Quantity = 6, Category = ItemCategory.Stands },
                new Item { Id = 14, SerialNumber = "SN014", Name = "Drum Throne", Price = 11.99, Description = "Comfortable drum throne", Quantity = 4, Category = ItemCategory.Drums },
                new Item { Id = 15, SerialNumber = "SN015", Name = "Violin Case", Price = 14.99, Description = "Hard shell violin case", Quantity = 5, Category = ItemCategory.CasesAndBags },
                new Item { Id = 16, SerialNumber = "SN016", Name = "Flute Cleaning Rod", Price = 1.99, Description = "Flute cleaning rod", Quantity = 12, Category = ItemCategory.Accessories },
                new Item { Id = 17, SerialNumber = "SN017", Name = "Guitar Tuner", Price = 6.49, Description = "Digital guitar tuner", Quantity = 9, Category = ItemCategory.Accessories },
                new Item { Id = 18, SerialNumber = "SN018", Name = "Piano Cover", Price = 13.99, Description = "Dust cover for piano", Quantity = 4, Category = ItemCategory.Accessories },
                new Item { Id = 19, SerialNumber = "SN019", Name = "Drum Mute Pads", Price = 10.99, Description = "Set of drum mute pads", Quantity = 6, Category = ItemCategory.Accessories },
                new Item { Id = 20, SerialNumber = "SN020", Name = "Violin Rosin", Price = 2.49, Description = "Violin rosin", Quantity = 15, Category = ItemCategory.Accessories }
            };

            List<Customer> customers = new List<Customer>
            {
                new Customer { ID = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "Password1", PhoneNumber = "555-0101", Address = "123 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Password = "Password2", PhoneNumber = "555-0102", Address = "124 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 3, FirstName = "Jim", LastName = "Brown", Email = "jim.brown@example.com", Password = "Password3", PhoneNumber = "555-0103", Address = "125 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 4, FirstName = "Jake", LastName = "White", Email = "jake.white@example.com", Password = "Password4", PhoneNumber = "555-0104", Address = "126 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 5, FirstName = "Jill", LastName = "Black", Email = "jill.black@example.com", Password = "Password5", PhoneNumber = "555-0105", Address = "127 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 6, FirstName = "Jack", LastName = "Green", Email = "jack.green@example.com", Password = "Password6", PhoneNumber = "555-0106", Address = "128 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 7, FirstName = "Jenny", LastName = "Blue", Email = "jenny.blue@example.com", Password = "Password7", PhoneNumber = "555-0107", Address = "129 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 8, FirstName = "Joe", LastName = "Yellow", Email = "joe.yellow@example.com", Password = "Password8", PhoneNumber = "555-0108", Address = "130 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 9, FirstName = "Jessica", LastName = "Purple", Email = "jessica.purple@example.com", Password = "Password9", PhoneNumber = "555-0109", Address = "131 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 10, FirstName = "Jeremy", LastName = "Orange", Email = "jeremy.orange@example.com", Password = "Password10", PhoneNumber = "555-0110", Address = "132 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 11, FirstName = "Julia", LastName = "Pink", Email = "julia.pink@example.com", Password = "Password11", PhoneNumber = "555-0111", Address = "133 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 12, FirstName = "Jordan", LastName = "Gray", Email = "jordan.gray@example.com", Password = "Password12", PhoneNumber = "555-0112", Address = "134 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 13, FirstName = "Jasmine", LastName = "Brown", Email = "jasmine.brown@example.com", Password = "Password13", PhoneNumber = "555-0113", Address = "135 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 14, FirstName = "Jason", LastName = "White", Email = "jason.white@example.com", Password = "Password14", PhoneNumber = "555-0114", Address = "136 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 15, FirstName = "Jocelyn", LastName = "Black", Email = "jocelyn.black@example.com", Password = "Password15", PhoneNumber = "555-0115", Address = "137 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 16, FirstName = "Jeff", LastName = "Green", Email = "jeff.green@example.com", Password = "Password16", PhoneNumber = "555-0116", Address = "138 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 17, FirstName = "Judy", LastName = "Blue", Email = "judy.blue@example.com", Password = "Password17", PhoneNumber = "555-0117", Address = "139 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 18, FirstName = "Jerry", LastName = "Yellow", Email = "jerry.yellow@example.com", Password = "Password18", PhoneNumber = "555-0118", Address = "140 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 19, FirstName = "Janet", LastName = "Purple", Email = "janet.purple@example.com", Password = "Password19", PhoneNumber = "555-0119", Address = "141 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" },
                new Customer { ID = 20, FirstName = "Jacob", LastName = "Orange", Email = "jacob.orange@example.com", Password = "Password20", PhoneNumber = "555-0120", Address = "142 Main St", City = "Anytown", State = "Anystate", ZipCode = "12345", Country = "USA" }
            };

            Inventory = items;
            Customers = customers;

            Contracts = GenerateContracts(this);

        }

        public List<Contract> GenerateContracts(TestData testData)
        {
            List<Contract> contracts = new List<Contract>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                Contract contract = new Contract
                {
                    Id = i + 1,
                    StartDate = DateTime.Now.AddDays(-random.Next(0, 30)),
                    RentalType = (RentalType)random.Next(0, Enum.GetValues(typeof(RentalType)).Length),
                    User = testData.Customers[random.Next(testData.Customers.Count)]
                };

                int itemCount = random.Next(3, 8);
                for (int j = 0; j < itemCount; j++)
                {
                    contract.Items.Add(testData.Inventory[random.Next(testData.Inventory.Count)]);
                }

                contracts.Add(contract);
            }

            return contracts;
        }
    }
}
