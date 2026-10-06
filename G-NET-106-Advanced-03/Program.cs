using System.Security.Cryptography.X509Certificates;

namespace G_NET_106_Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Student Grade Manager");
            Console.WriteLine("--------------------------------------");

            List<int> numbers = new List<int> {85, 92, 78, 95, 88, 70, 100, 65 };

            Console.WriteLine("List Count: " + numbers.Count);

            Console.WriteLine("First Grade: " + numbers[0]);

            Console.WriteLine("Last Grade: " + numbers[numbers.Count - 1]);

            numbers.Sort();

            Helper.printCollection("Sorted Grades", numbers);

            int highGrade = numbers.Find(n => n > 90);
            Console.WriteLine("First Grade > 90: " + highGrade);

            List<int> failingGrades = numbers.FindAll(n => n < 75);
            Helper.printCollection("Failing Grades", failingGrades);

            numbers.RemoveAll(n => n < 75);
            Helper.printCollection("Grades After Removing Failing", numbers);

            bool hasFullMarks = numbers.Exists(n => n == 100);

            Console.WriteLine("Has Full Marks (100): " + hasFullMarks);

            List<string> strings = numbers.ConvertAll(n => $"Grade: {n}");

            Helper.printCollection("String Grades", strings);

            Console.WriteLine("");
            #endregion


            #region Exercise 2

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Leaderboard");
            Console.WriteLine("--------------------------------------");

            Dictionary<int, string> leaderboard = new Dictionary<int, string>
            {
                { 500, "Ahmed" },
                { 200, "Sara" },
                { 800, "Ali" },
                { 350, "Mona" }
            };

            var sortedLeaderboard = leaderboard.OrderBy(entry => entry.Key);

            Helper.printCollection("Sorted Leaderboard", sortedLeaderboard);

            var firstEntry = sortedLeaderboard.First();
            Console.WriteLine($"First Entry - Score: {firstEntry.Key}, Player: {firstEntry.Value}");

            bool scoreExists = leaderboard.ContainsKey(500);
            Console.WriteLine("Score 500 Exists: " + scoreExists);

            if (leaderboard.TryGetValue(999, out string player))
            {
                Console.WriteLine("Player with Score 999: " + player);
            }
            else
            {
                Console.WriteLine("Player with Score 999 does not exist.");
            }

            leaderboard.Remove(200);
            Console.WriteLine("Leaderboard after removing player with score 200:");
            Helper.printCollection("Updated Leaderboard", leaderboard);

            Console.WriteLine("");
            #endregion


            #region Exercise 3

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Phone Book");
            Console.WriteLine("--------------------------------------");

            Dictionary<string, string> phoneBook = new Dictionary<string, string>
            {
                { "Fatma", "01070610133" },
                { "Mohammed", "01228098364" },
                { "Hoda", "01273155681" },
                { "Menna", "01288887122" }

            };


            phoneBook["Menna"] = "01126386181"; 

            try
            {
                phoneBook.Add("Fatma", "01070610133");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            bool added = phoneBook.TryAdd("Fatma", "01070610133");
            Console.WriteLine("TryAdd Result: " + added);

            if (phoneBook.TryGetValue("Ali", out string aliNumber))
            {
                Console.WriteLine("Ali's Number: " + aliNumber);
            }
            else
            {
                Console.WriteLine("Ali's Number: Not Found");
            }

            Console.WriteLine("All Names: " + string.Join(", ", phoneBook.Keys));


            Console.WriteLine("All Numbers: " + string.Join(", ", phoneBook.Values));

            Console.WriteLine(" ");

            #endregion


            #region Exercise 4

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Unique Email Validator");
            Console.WriteLine("--------------------------------------");

            HashSet<string> emailSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "ahmed@test.com",
                "AHMED@test.com",
                "sara@test.com",
                "Sara@Test.Com"
            };

            Console.WriteLine("Count of unique emails: " + emailSet.Count);
            Console.WriteLine("Unique emails: " + string.Join(", ", emailSet));

            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };

            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            HashSet<int> unionSet = new HashSet<int>(setA);
            unionSet.UnionWith(setB);

            Console.WriteLine("Union: " + string.Join(", ", unionSet));

            HashSet<int> intersectSet = new HashSet<int>(setA);
            intersectSet.IntersectWith(setB);

            Console.WriteLine("Intersection: " + string.Join(", ", intersectSet));

            HashSet<int> exceptSet = new HashSet<int>(setA);
            exceptSet.ExceptWith(setB);

            Console.WriteLine("Difference: " + string.Join(", ", exceptSet));

            bool isSubset = new HashSet<int> { 1, 2 }.IsSubsetOf(setA);
            Console.WriteLine("Is {1,2} a subset of Set A? " + isSubset);



            
            #endregion


        }
    }
}
