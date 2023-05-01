using System.Reflection;

namespace PlaybookCsharp
{
    internal class Program
    {        
        static void Main(string[] args)            
        {
            //loop design
            List<string> groceries = new List<string>() { "Milk", "Eggs", "Bread", "Cheese", "Ham", "Butter" };

            foreach (string item in groceries.Take(3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");

            foreach (string item in groceries.Skip(3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");

            foreach (string item in groceries.Take(3).Skip(1))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");

            string filePath1 = Assembly.GetExecutingAssembly().Location;
            string filePath2 = Assembly.GetEntryAssembly()!.Location;
            Console.WriteLine(filePath1);
            Console.WriteLine(filePath2);
        }
    }
}