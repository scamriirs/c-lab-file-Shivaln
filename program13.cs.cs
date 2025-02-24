
13. Create one admission enquiry form.

OUTPUT:

using System;

class EnquiryForm
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}