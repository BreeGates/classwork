
namespace ShoppingListLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display at least 8 item names and prices.
            // Ask the user to enter an item name
            // If that item exists, display that item and price and add that item to the user’s order.
            // If that item doesn’t exist, display an error and re-prompt the user.  (Display the menu again if you’d like.)
            // After adding one to their order, ask if they want to add another. If so, repeat.  (User can enter an item more than once; we’re not keeping track of quantity at this point.)
            // When they’re done adding items, display a list of all items ordered with prices in columns.
            // Display the sum price of the items ordered.
            // 
            
            //Display at least 8 item names and prices.
            Dictionary<string, double> menu = new Dictionary<string, double>()
            {
                { "apple", 0.99 },
                { "banana", 0.59 },
                { "cauliflower", 1.59 },
                { "dragonfruit", 2.19 },
                { "elderberry", 1.79 },
                { "figs", 2.09 },
                { "grapefruit", 1.99 },
                { "honeydew", 3.49 }
            };

            List<string> cart = new List<string>();
            string answer = "y";

            Console.WriteLine("Welcome to Chirpus Market!");

            while (answer == "y")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Item List");
                Console.WriteLine(" ");
                foreach (var item in menu)
                {
                    Console.WriteLine(item.Key + " - " + item.Value);
                }
                
                    // Ask the user to enter an item name

                Console.WriteLine();
                Console.Write("What item would you like to order? ");
                string input = Console.ReadLine().ToLower();

                // If that item exists, display that item and price and add that item to the user’s order.
                
                if (menu.ContainsKey(input))
                {
                    Console.WriteLine("Adding " + input + " to cart at " + menu[input]);
                    cart.Add(input);
                }
                else
                {
                    // After adding one to their order, ask if they want to add another. If so, repeat.
                    Console.WriteLine("Sorry, we don't have that item. Please try again.");
                    continue;
                }

                Console.Write("Would you like to order anything else (y/n)? ");
                answer = Console.ReadLine().ToLower();

                while (answer != "y" && answer != "n")
                {
                    Console.Write("Invalid response. Please enter 'y' or 'n': ");
                    answer = Console.ReadLine().ToLower();
                }
            }
            // When they’re done adding items, display a list of all items ordered with prices in columns
            // Display the sum price of the items ordered
            Console.WriteLine("");
            Console.WriteLine("Thanks for your order!");
            Console.WriteLine("Here's what you got:");

            double total = 0;

            foreach (string item in cart)
            {
                Console.WriteLine(item + " - " + menu[item]);
                total += menu[item];
            }

            if (cart.Count > 0)
            {
                double average = total / cart.Count;
                Console.Read();
            }
        }
    }
}
//End of Program