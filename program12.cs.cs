
12. Write a program to implement Constructor.

OUTPUT:
using System;

class Car
{
    public string Model;
    public Car(string Model)
    {
        Model = model;
    }
    public void ShowModel()
    {
        Console.WriteLine($"Car Model: {Model}");
    }
}
class Program
{
    static void Main()
{
Car c = new Car("Tesla");
c.ShowModel();
}
}