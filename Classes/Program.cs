namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "F-150";
            carOne.Year = 2025;

            Console.WriteLine($"{carOne.Year} {carOne.Make} {carOne.Model}");

        }
    }
}
