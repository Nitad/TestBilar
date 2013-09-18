using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Bilar
{
    public static int Wheels {get; set;}
    public static int Horsepower { get; set; }

    public Bilar(int wheels, int horsepower)
    {
        Wheels = wheels;
        Horsepower = horsepower;
    }
    public int CountWheels()
    {
        return Wheels;
    }
    public int CountHorsepower()
    {
        return Horsepower;
    }
}

