using System;

namespace InterfaceExercise;

public class Truck: IVehicule, ICompany
{
    public string motorType { get; set; }
    public int pullingCapacity { get; set; }
    public int numberOfWheels { get; set; }
    public bool isElectric { get; set; }
    public string color { get; set; }
    public void Drive()
    {
        Console.WriteLine("Truck is driving");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Truck informations: Brand: {brand}\nLogo: {logo}\nPulling capacity: {pullingCapacity}\n" +
                          $"Wheels: {numberOfWheels}\nColor: {color}\nIs Electric: {isElectric}\nMorton Type: {motorType}\n");
    }

    public string brand { get; set; }
    public string logo { get; set; }
}