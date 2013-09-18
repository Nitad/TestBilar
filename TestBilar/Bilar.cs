using System;


public class Bilar
{
    string Name { get; set; }
    int Wheels {get; set;}
    int Horsepower { get; set; }
    bool Broken { get; set; }

    public Bilar(string name, int wheels, int horsepower)
    {
        Broken = false;
        Name = name;
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

    public void burnOut()
    {
        if (!Broken)
        {
            Console.WriteLine("Wheeee! Burnoooooout! Your " + this.Wheels + " is now broken.");
            Broken = false;
        }
        else
        {
            Console.WriteLine("Your car is not broken.");
        }
    }

}

