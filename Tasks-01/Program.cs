namespace Tasks_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double smallCarpetPrice = 25;
            double largeCarpetPrice = 35;
            double taxRate = 6;

            Console.WriteLine("Welcome To Eslam Carpet Cleaner");
            Console.WriteLine("=====================================");
            Console.WriteLine("Price List : ");
            Console.WriteLine($"Small Carpet = {smallCarpetPrice} L.E");
            Console.WriteLine($"Large Carpet = {largeCarpetPrice} L.E");
            Console.WriteLine(" ");
            Console.WriteLine($"Prices Excluded {taxRate}% Taxes");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine("=====================================");
            Console.WriteLine("Please Place your Order");

            int smallCarpetCount = GetCarpetCount("Small carpet count : ");
            int largeCarpetCount = GetCarpetCount("Large carpet count : ");

            Console.WriteLine("=====================================");
            double totalPriceBeforeTax = (smallCarpetCount * smallCarpetPrice) + (largeCarpetCount * largeCarpetPrice);
            Console.Write($"Total Price Before Tax = {totalPriceBeforeTax}");
            Console.WriteLine(" ");
            Console.Write($"Total Price After Tax = {totalPriceBeforeTax * (1 + (taxRate / 100))}");
            Console.WriteLine(" ");
            Console.WriteLine("This estimate is valid for 30 days");
            Console.WriteLine("=====================================");

            Console.WriteLine("Thank You For purchase from us");
        }

        // I tried to search how after fail or error console app return to entry point again 
        static int GetCarpetCount(string message)
        {
            int count;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out count) && count >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
            return count;
        }
    }
}

