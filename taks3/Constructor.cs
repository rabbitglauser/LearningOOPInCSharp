using System;

class Computer
{
  public string color;
  public string model;
  public string brand;

  public Computer(string computerColor, string computerModel, string computerBrand)
  {
    color = computerColor;
    model = computerModel;
    brand = computerBrand;
  }
}

class Program
{
  static void Main(string[] args)
  {
    Computer mycomputer = new Computer("Red", "Sedan", "Toyota");
    Console.WriteLine($"Car color: {mycomputer.color}, Model: {mycomputer.model}, brand: {mycomputer.brand}");
  }
}