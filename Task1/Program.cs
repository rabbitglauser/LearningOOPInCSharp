using System;

namespace MyApplication
{
    class Vehicle
    {
        public string color = "red";
        public int maxSpeed = 100;

        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }
    }

    class Car : Vehicle
    {
        public string model = "Sedan";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.WriteLine($"Color: {myCar.color}, Model: {myCar.model}, Max Speed: {myCar.maxSpeed}");
            myCar.Honk();
        }
    }
}