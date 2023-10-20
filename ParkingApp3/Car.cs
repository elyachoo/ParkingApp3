namespace ParkingApp3
{
  
    public class Car
    {
        /// <summary>
        ///  unique identifier of the car.
        /// </summary>
        public int Id { get; }

        /// <summary>
        ///  the brand of the car.
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        ///  the model of the car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        ///  the color of the car.
        /// </summary>
        public Color CarColor { get; private set; }

        /// <summary>
        /// the license number of the car.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// the arrival time of the car.
        /// </summary>
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// the departure time of the car.
        /// </summary>
        public DateTime DepartureTime { get; set; }

        private static int _idCounter = 0;

        public Car(string brand, string model, Color color, string number, DateTime arrivalTime, DateTime departureTime)
        {
            Id = _idCounter++;
            Brand = brand;
            Model = model;
            CarColor = color;
            Number = number;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }

        //конструктори
        public Car(string brand, string model, Color color, string number) : this(brand, model, color, number, DateTime.Now, DateTime.Now)
        {
        }

        public Car(string brand, string model) : this(brand, model, Color.Unknown, "Unknown")
        {
        }

        public Car() : this("Unknown", "Unknown")
        {
        }

        /// <summary>
        /// Changes the color of the car to the specified color.
        /// </summary>
        /// <param name="newColor">The new color of the car.</param>
        public void ChangeColor(Color newColor)
        {
            CarColor = newColor;
        }
    }
}
