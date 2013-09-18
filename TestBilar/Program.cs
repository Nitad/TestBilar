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
            var saab = new Bilar(4, 90);
            var BMW = new Bilar(4, 200);

            Console.WriteLine(saab.CountWheels());
            Console.WriteLine(BMW.CountHorsepower());

        }
    }
}
