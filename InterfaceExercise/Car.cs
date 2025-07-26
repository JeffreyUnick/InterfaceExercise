using System;

namespace InterfaceExercise;

public class Car: IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public int MaxSpeed { get; set; }
    public int NumberOfWheels { get; set; }
    public bool IsElectric { get; set; }
    public string Color { get; set; }
    public void Drive()
    {
        Console.WriteLine("Someone is driving");
        ;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car Informations are\nColor: {Color}\nWheels: {NumberOfWheels}\n" +
                          $"IsElectric: {IsElectric}\nMax Speed: {MaxSpeed}\nHas Trunk: {HasTrunk}\nBrand Name: {Brand}" +
                          $"\nLogo ={Logo}\n");
    }

    public string Brand { get; set; }
    public string Logo { get; set; }
}