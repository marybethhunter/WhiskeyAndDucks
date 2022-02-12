using WhiskeyAndDucks.Models;

namespace WhiskeyAndDucks.DataAccess
{
    public class WhiskeyRepository
    {
        private static List<Whiskey> _whiskeys = new List<Whiskey>()
        {
            new Whiskey()
            {
                Id = 1,
                Name = "Jack Daniels",
                Price = 30.99,
                Proof = 50,
                StockQuantity = 100,
            },
            new Whiskey()
            {
                Id = 2,
                Name = "Woodford Reserve",
                Price = 100.99,
                Proof = 80,
                StockQuantity = 15,
            },
            new Whiskey()
            {
                Id = 3,
                Name = "Dickel",
                Price = 39.99,
                Proof = 90,
                StockQuantity = 50,
            },
            new Whiskey()
            {
                Id = 4,
                Name = "Eagle Rare",
                Price = 149.99,
                Proof = 85,
                StockQuantity = 5,
            }
        };

        internal object GetByName(string name)
        {
            var match = _whiskeys.FirstOrDefault(w => w.Name == name);
            return match;
        }

        internal List<Whiskey> GetAll()
        {
            return _whiskeys;
        }
    }
}
