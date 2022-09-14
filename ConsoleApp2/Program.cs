using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberTo = 0;
            string numbers = null;
            while (numberTo < 1 || numberTo > 100)
            {
                try
                {

                    Console.WriteLine("Input integer from 1 to a 100:");
                    numberTo = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("The input was incorrect.");
                }
            }
            while (numbers == null)
            {
                try
                {
                    Console.WriteLine("Input ODD for odd numbers and EVEN for even numbers:");
                 numbers = Console.ReadLine();


                }
                catch
                {
                    Console.WriteLine("The input was incorrect.");
                }
            }
            Console.WriteLine("You have selected " + numbers + ". The numbers between 0 and " + numberTo);
            if (numbers == "ODD")
            {
             for (int counter = 1; counter <= numberTo; counter+=2)
                {
                    Console.WriteLine(counter);
                }
            }
            if (numbers == "EVEN")
            {
                for (int counter = 0; counter <= numberTo; counter+=2)
                {
                    Console.WriteLine(counter);
                }
            }

        }
    }
}