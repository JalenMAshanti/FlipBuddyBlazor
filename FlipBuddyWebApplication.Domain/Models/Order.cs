using System;

namespace FlipBuddyWebApplication.Domain.Models
{
    public class Order
    {
        public string Location { get; set; } = string.Empty;
        public decimal Population { get; set; }
    }

    public static class OrderGenerator
    {
        private static readonly Random random = new Random();
        private static readonly List<string> locations = new List<string>
        {
        "New York", "Los Angeles", "Chicago", "Houston", "Phoenix"
        }; 
            public static List<Order> GenerateRandomOrders(int numberOfOrders = 1)
            {
            var orders = new List<Order>();

            for (int i = 0; i < numberOfOrders; i++)
            {
                var order = new Order
                {
                    Location = locations[random.Next(locations.Count)],
                    Population = random.Next(100000, 1000000) // Random population between 100k and 1M
                };

                orders.Add(order);
            }

            return orders;
        }
    }

   
}
