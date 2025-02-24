11. Write a program to implement class and its objects.

OUTPUT:

using System;

class Person
{
    public string Name;
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
}
class Program
{
    static void Main()
    {
        Person p = new Person {Name = "Rahul" };
        p.Introduce();
        
    }
    }