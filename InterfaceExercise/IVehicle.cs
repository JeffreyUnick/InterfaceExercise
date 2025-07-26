namespace InterfaceExercise;

public interface IVehicle : ICompany
{
    public int NumberOfWheels { get; set; }
    public bool IsElectric { get; set; }
    public string Color { get; set; }

    public void Drive();

    public void DisplayDetails();
}