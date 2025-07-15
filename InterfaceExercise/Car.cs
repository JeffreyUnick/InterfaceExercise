using System;

namespace InterfaceExercise;

public class Car: IVehicule, ICompany
{
    public bool hasTrunk { get; set; }
    public int maxSpeed { get; set; }
    public int numberOfWheels { get; set; }
    public bool isElectric { get; set; }
    public string color { get; set; }
    public void Drive()
    {
        Console.WriteLine("Someone is driving");
        ;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car Informations are\nColor: {color}\nWheels: {numberOfWheels}\n" +
                          $"IsElectric: {isElectric}\nMax Speed: {maxSpeed}\nHas Trunk: {hasTrunk}\nBrand Name: {brand}" +
                          $"\nLogo ={logo}\n");
    }

    public string brand { get; set; }
    public string logo { get; set; }
}