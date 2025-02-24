16. Concept of three variables: temp,pressure and water level for a chemical industry boiler from the keyboard.

OUTPUT:

using System;

class BoilerMonitor
{
    public static event Action<string> Alert;
    public static void Main()
    {
        Alert += message => Console.WriteLine("ALERT: "+ message);
        
        int temp = 120, pressure = 80, waterLevel = 30;
        if (temp > 100 || pressure > 75 || waterLevel < 20)
        Alert("Critical Boiler Condition!");
        
    }
}