using System;


public class Bilar
{
    public string Name { get; set; }
    public int Wheels {get; set;}
    public int Horsepower { get; set; }
    public bool Broken { get; set; }

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
            Console.WriteLine("Wheeee! Burnoooooout! Your " + this.Name + " is now broken.");
            Broken = true;
        }
        else
        {
            Console.WriteLine("Your car is broken.");
        }
    }

}

