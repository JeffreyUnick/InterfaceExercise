using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
            var Car1 = new Car();
            Car1.Drive();
            Car1.brand = "Toyota";
            Car1.logo = "Two Ellipses crossed";
            Car1.color = "Red";
            Car1.hasTrunk = true;
            Car1.isElectric = true;
            Car1.maxSpeed = 160;
            Car1.numberOfWheels = 4;
            
            var SUV1 = new SUV();
            SUV1.Drive();
            SUV1.brand = "Honda";
            SUV1.logo = " H ";
            SUV1.color = "BLACK";
            SUV1.leatherSeat = true;
            SUV1.isElectric = false;
            SUV1.numberOfWheels = 4;
            SUV1.numberOfSeats = 8;
            
            var Truck1 = new Truck();
            Truck1.Drive();
            Truck1.brand = "FORD";
            Truck1.logo = "Ford";
            Truck1.color = "yellow";
            Truck1.pullingCapacity = 10000;
            Truck1.numberOfWheels = 6;
            Truck1.isElectric = false;
            Truck1.motorType = "V12";

            Car1.DisplayDetails();
            SUV1.DisplayDetails();
            Truck1.DisplayDetails();


        }
    }
}
