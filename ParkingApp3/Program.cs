using System.Drawing;

namespace ParkingApp3
{


    internal class Program
    {
       static void Main(string[] args)
       {
            using (Parking parking1 = new Parking("Skyline Complex - Lot #45", "1341 Baseline Rd", 2))
            {
                Color color1 = new Color(111, 0, 255, 100);
                Color color2 = new Color(0, 172, 0, 50);

                Car car1 = new Car("Tesla", "Model 3", color1, "7VIP583", DateTime.Now.AddHours(-3), DateTime.Now.AddHours(1));
                Car car2 = new Car("Dodge", "Ram", color2, "5RTW387", DateTime.Now.AddHours(2), DateTime.Now.AddHours(3));

                parking1.ParkCar(car1);
                parking1.ParkCar(car2);

                Console.WriteLine("Parking 1 State:");
                Console.WriteLine(parking1.GetStateMessage());

                string departingCarBrand = car1.Brand;
                parking1.RemoveCar(car1);
                Console.WriteLine($"{departingCarBrand} {car1.Number} drove away.");

                Console.WriteLine("Parking 1 State after car departure:");
                Console.WriteLine(parking1.GetStateMessage());
            }
       }
    }
}