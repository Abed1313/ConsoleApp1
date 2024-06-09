namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Class1.NumParser("21");

            string role = "admen";

          string sd=   Class2.GetUserRole3(role,true);
            Console.WriteLine($"THe Role is {sd}");
        }
    }
}
