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
        }
    }
}
