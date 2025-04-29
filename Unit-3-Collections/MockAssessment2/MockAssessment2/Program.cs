internal class Program
    {
        static void Main(string[] args)
        {
            // Test each method manually here if you want
            Console.WriteLine("Testing AddStarWarsCharacters:");
            string[] characters = { "Luke", "Leia", "Han", "Yoda", "Chewbacca" };
            Console.WriteLine(AddStarWarsCharacters(characters)); // Should print the index of Yoda

            Console.WriteLine("\nTesting DeathStarCombat:");
            Dictionary<string, int> jediFighters = new Dictionary<string, int>
            {
                {"Luke", 85},
                {"Yoda", 95},
                {"Obi-Wan", 90}
            };
            Console.WriteLine(DeathStarCombat(jediFighters)); // Should print "Yoda"

            Console.WriteLine("\nTesting ConvertPlanets:");
            string[] planets = { "Tatooine", "Alderaan", "Hoth", "Endor" };
            List<string> reversedPlanets = ConvertPlanets(planets);
            foreach (string planet in reversedPlanets)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("\nTesting AverageDroids:");
            List<int> droidIDs = new List<int> { 2, 3, 4, 5, 6 };
            Console.WriteLine(AverageDroids(droidIDs)); // Average of even numbers: (2+4+6)/3

            Console.WriteLine("\nTesting TryToCatchDarthVader:");
            Console.WriteLine(TryToCatchDarthVader("123")); // Should say Vader Was Captured!
            Console.WriteLine(TryToCatchDarthVader("escape")); // Should say Vader Got Away!
        }

        // 1. AddStarWarsCharacters
        static int AddStarWarsCharacters(string[] characters)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == "Yoda")
                {
                    return i;
                }
            }
            return -1;
        }

        // 2. DeathStarCombat
        static string DeathStarCombat(Dictionary<string, int> fighters)
        {
            int highestAttack = int.MinValue;
            string bestJedi = "";

            foreach (KeyValuePair<string, int> fighter in fighters)
            {
                if (fighter.Value > highestAttack)
                {
                    highestAttack = fighter.Value;
                    bestJedi = fighter.Key;
                }
            }

            return bestJedi;
        }

        // 3. ConvertPlanets
        static List<string> ConvertPlanets(string[] planets)
        {
            List<string> planetList = new List<string>();

            for (int i = planets.Length - 1; i >= 0; i--)
            {
                planetList.Add(planets[i]);
            }

            return planetList;
        }

        // 4. AverageDroids
        static double AverageDroids(List<int> droidIDs)
        {
            List<int> evens = new List<int>();

            foreach (int id in droidIDs)
            {
                if (id % 2 == 0)
                {
                    evens.Add(id);
                }
            }

            if (evens.Count == 0)
            {
                return 0;
            }

            double sum = 0;
            foreach (int id in evens)
            {
                sum += id;
            }

            return sum / evens.Count;
        }

        // 5. TryToCatchDarthVader
        static string TryToCatchDarthVader(string input)
        {
            try
            {
                int number = int.Parse(input);
                return "Vader Was Captured!";
            }
            catch (FormatException)
            {
                return "Vader Got Away!";
            }
        }
    }
