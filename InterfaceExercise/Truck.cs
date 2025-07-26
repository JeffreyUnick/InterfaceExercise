using System;

namespace InterfaceExercise;

public class Truck: IVehicle, ICompany
{
    public string MotorType { get; set; }
    public int PullingCapacity { get; set; }
    public int NumberOfWheels { get; set; }
    public bool IsElectric { get; set; }
    public string Color { get; set; }
    public void Drive()
    {
        Console.WriteLine("Truck is driving");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Truck informations: Brand: {Brand}\nLogo: {Logo}\nPulling capacity: {PullingCapacity}\n" +
                          $"Wheels: {NumberOfWheels}\nColor: {Color}\nIs Electric: {IsElectric}\nMorton Type: {MotorType}\n");
    }

    public string Brand { get; set; }
    public string Logo { get; set; }
}