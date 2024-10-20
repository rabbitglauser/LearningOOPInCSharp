using System;

namespace MyApplication
{
    class Car
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car color: {color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Color = "blue";
            myCar.DisplayCarInfo();
        }
    }
}