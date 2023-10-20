namespace ParkingApp3
{
    public class Parking : IDisposable
    {
        public List<Car> Cars { get; private set; } = new List<Car>();
        /// <summary>
        ///  the unique identifier of the parking lot.
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// the name of the parking lot.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the address of the parking lot.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// the total capacity of the parking lot.
        /// </summary>
        public int Capacity { get; private set; }

        /// <summary>
        /// the list of cars parked in the parking lot.
        /// </summary>
        private List<Car> ParkedCars { get; set; }

        private static int _idCounter = 0;


        /// <summary>
        /// Initializes a new instance of the Parking class with specified details.
        /// </summary>
        /// <param name="name">The name of the parking lot.</param>
        /// <param name="address">The address of the parking lot.</param>
        /// <param name="capacity">The total capacity of the parking lot.</param>
        public Parking(string name, string address, int capacity)
        {
            Id = _idCounter++;
            Name = name;
            Address = address;
            Capacity = capacity;
            ParkedCars = new List<Car>();
        }

        //конструктори
        public Parking(List<Car> initialCars)
        {
            Cars = initialCars;
        }

        public Parking()
        {
        }


        /// <summary>
        /// Parks the specified car in the parking lot.
        /// </summary>
        /// <param name="car">The car to be parked.</param>
        /// <returns>True if the car was parked successfully, false otherwise.</returns>
        public bool ParkCar(Car car)
        {
            if (ParkedCars.Count < Capacity)
            {
                ParkedCars.Add(car);
                return true;
            }
            return false;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
            Console.WriteLine("Car parked");
        }


        /// <summary>
        /// Removes the specified car from the parking lot.
        /// </summary>
        /// <param name="car">The car to be removed.</param>
        /// <returns>True if the car was removed successfully, false otherwise.</returns>
        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
            car.DepartureTime = DateTime.Now;
        }

        public void DisplayCars()
        {
            Console.WriteLine("Cars in the parking:");
            foreach (var car in Cars)
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Color: {car.CarColor}, Number: {car.Number}, Arrival Time: {car.ArrivalTime}, Departure Time: {car.DepartureTime}");
            }
        }


        /// <summary>
        /// Gets the number of available parking spaces in the parking lot.
        /// </summary>
        /// <returns>The number of available parking spaces.</returns>
        public int GetAvailableSpaces()
        {
            return Capacity - ParkedCars.Count;
        }


        /// <summary>
        /// Gets a message describing the current state of the parking lot.
        /// </summary>
        /// <returns>A string containing information about total spaces, available spaces, and occupied spaces.</returns>
        public string GetStateMessage()
        {
            return $"Total spaces: {Capacity}, Available spaces: {GetAvailableSpaces()}, Occupied spaces: {ParkedCars.Count}";
        }
        // Implementation of the Dispose() method, which is part of the IDisposable interface.
        public void Dispose()
        {
            foreach (var car in Cars)
            {
                car.DepartureTime = DateTime.Now;
            }
            Cars.Clear();
            Console.WriteLine("Parking is now free and all cars have been set to departure.");
        }

    }
}
