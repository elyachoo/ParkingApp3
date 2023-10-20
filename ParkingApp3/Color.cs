namespace ParkingApp3
{
    public struct Color
    {
        public static Color Unknown { get; } = new Color(0, 0, 0, 0);
        public int Red { get; private set; }
        public int Green { get; private set; }
        public int Blue { get; private set; }
        public int Opacity { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Color struct with specified RGB and opacity values.
        /// </summary>
        /// <param name="red">The red component (0 to 255).</param>
        /// <param name="green">The green component (0 to 255).</param>
        /// <param name="blue">The blue component (0 to 255).</param>
        /// <param name="opacity">The opacity (0 to 100).</param>
        public Color(int red, int green, int blue, int opacity)
        {
            if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255 || opacity < 0 || opacity > 100)
            {
                Console.WriteLine("Invalid color or opacity value.");
                Red = Green = Blue = Opacity = 0;
            }
            else
            {
                Red = red;
                Green = green;
                Blue = blue;
                Opacity = opacity;
            }
        }

        // конструктори
        public Color(int red, int green, int blue) : this(red, green, blue, 100)
        {
        }

        public Color(int red, int green) : this(red, green, 0, 100)
        {
        }

        public Color(int grayScale) : this(grayScale, grayScale, grayScale, 100)
        {
        }
    }
}