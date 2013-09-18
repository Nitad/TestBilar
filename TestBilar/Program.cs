using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBilar
{
    class Program
    {
        static void Main(string[] args)
        {
            var saab = new Bilar("Saab", 4, 90);
            var BMW = new Bilar("BMW", 4, 200);

            Console.WriteLine(saab.CountWheels());
            Console.WriteLine(BMW.CountHorsepower());
            Console.ReadLine();

            ConsoleKeyInfo KeyInfo;
            do
            {
                Console.Clear();
                Console.WriteLine("You are in your Saab. Press enter to burnout...");
                KeyInfo = Console.ReadKey();
                saab.burnOut();
                Console.ReadLine();
            } while (KeyInfo.Key != ConsoleKey.Escape);

        }
    }
}
