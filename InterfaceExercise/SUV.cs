using System;

namespace InterfaceExercise;

public class SUV: IVehicle, ICompany 
{
    public bool LeatherSeat { get; set; }
    public int NumberOfSeats { get; set; }
    public int NumberOfWheels { get; set; }
    public bool IsElectric { get; set; }
    public string Color { get; set; }
    public void Drive()
    {
        Console.WriteLine("SUV is driving");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"SUV informations:\nBrand: {Brand}\nColor: {Color}\n Numb Of seats: {NumberOfSeats}\n" +
                          $"Number of Wheels: {NumberOfWheels}\n");
    }

    public string Brand { get; set; }
    public string Logo { get; set; }
}