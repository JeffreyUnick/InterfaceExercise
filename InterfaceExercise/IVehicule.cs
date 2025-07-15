namespace InterfaceExercise;

public interface IVehicule : ICompany
{
    public int numberOfWheels { get; set; }
    public bool isElectric { get; set; }
    public string color { get; set; }

    public void Drive();

    public void DisplayDetails();
}