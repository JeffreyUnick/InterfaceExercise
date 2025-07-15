using System;

namespace InterfaceExercise;

public class SUV: IVehicule, ICompany 
{
    public bool leatherSeat { get; set; }
    public int numberOfSeats { get; set; }
    public int numberOfWheels { get; set; }
    public bool isElectric { get; set; }
    public string color { get; set; }
    public void Drive()
    {
        Console.WriteLine("SUV is driving");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"SUV informations:\nBrand: {brand}\nColor: {color}\n Numb Of seats: {numberOfSeats}\n" +
                          $"Number of Wheels: {numberOfWheels}\n");
    }

    public string brand { get; set; }
    public string logo { get; set; }
}