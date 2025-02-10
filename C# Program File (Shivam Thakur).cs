//C# Console Programming

//1. Demonstrate the working of C# SDK
This program prints a message to verify that the C# SDK is working correctly.


output: 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("C# SDK is working correctly.");
    }
}

//2. Use of Various Data Types in C#
This program demonstrates different data types available in C#.

OUTPUT:

using System;

class DataTypesExample
{
    static void Main()
    {
        int intValue = 10;
        float floatValue = 10.5f;
        double doubleValue = 20.99;
        char charValue = 'A';
        bool boolValue = true;
        string stringValue = "Hello, C#";

        Console.WriteLine("Integer: " + intValue);
        Console.WriteLine("Float: " + floatValue);
        Console.WriteLine("Double: " + doubleValue);
        Console.WriteLine("Char: " + charValue);
        Console.WriteLine("Boolean: " + boolValue);
        Console.WriteLine("String: " + stringValue);
    }
}

//3. Understanding Control Statements
This program demonstrates the use of control statements such as if-else, loops, and switch case.

OUTPUT:

using System;

class ControlStatements
{
    static void Main()
    {
        int number = 10;

        if (number % 2 == 0)
            Console.WriteLine("Even Number");
        else
            Console.WriteLine("Odd Number");

        for (int i = 1; i <= 5; i++)
            Console.WriteLine("For Loop Iteration: " + i);

        int count = 0;
        while (count < 3)
        {
            Console.WriteLine("While Loop Iteration: " + count);
            count++;
        }

        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Invalid Day");
                break;
        }
    }
}

//4. Understanding Library Functions
This program demonstrates some commonly used built-in library functions in C#.

OUTPUT: 

using System;

class LibraryFunctions
{
    static void Main()
    {
        string text = "Hello, C#";
        Console.WriteLine("Upper Case: " + text.ToUpper());
        Console.WriteLine("Lower Case: " + text.ToLower());
        Console.WriteLine("Length: " + text.Length);

        double sqrtValue = Math.Sqrt(25);
        Console.WriteLine("Square Root of 25: " + sqrtValue);

        int maxValue = Math.Max(10, 20);
        Console.WriteLine("Max Value between 10 and 20: " + maxValue);
    }
}

//5. Various Operators in C#
This program demonstrates different types of operators used in C#.

OUTPUT:

using System;

class OperatorsExample
{
    static void Main()
    {
        int a = 10, b = 5;
        
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));
        Console.WriteLine("Increment: " + (++a));
        Console.WriteLine("Decrement: " + (--b));

        bool x = true, y = false;
        Console.WriteLine("AND Operator: " + (x && y));
        Console.WriteLine("OR Operator: " + (x || y));
        Console.WriteLine("NOT Operator: " + (!x));

       
        int bitA = 5, bitB = 3; // 5 = 101, 3 = 011
        Console.WriteLine("Bitwise AND: " + (bitA & bitB));
        Console.WriteLine("Bitwise OR: " + (bitA | bitB));
        Console.WriteLine("Bitwise XOR: " + (bitA ^ bitB));

        int num = 10;
        num += 5;
        Console.WriteLine("Assignment += : " + num);

        int min = (a < b) ? a : b;
        Console.WriteLine("Minimum Value: " + min);
    }
}


//6. Write a program to store 10 elements in an array  and display the array elements in incresing order.
OUTPUT:

using System;

class ArraySorting
{
    static void Main()
    {
        int[] arr = { 5,2,9,1,3};
        Array.Sort(arr);
        Console.WriteLine("Sorted Array: "+ string.Join(", ", arr));
    }
}


//7. Demonstrate the use of passbyvalue and passbyReference by  writing a program.

OUTPUT:

using System;

class PassByDemo
{
    static void PassByValue(int x)
    {
        x += 10;
    }

    static void PassByReference(ref int x)
    {
        x += 10;
        
    }
    static void Main()
    {
        int num = 10;
        
         PassByValue(num);
         Console.WriteLine($"After PassByValue: {num}");
         
         PassByReference(ref num);
         Console.WriteLine($"After PassByReference: {num}");
         
    }
    
}


//8. Write a program to implement recursion.

OUTPUT:

using System;

class RecursionDemo
{
    static int Factorial(int n)
    {
        if(n == 0) return 1;
        return n * Factorial( n - 1);
    }
    static void Main()
    { Console.WriteLine("Factorial of 5: "+ Factorial(5));
    }
}

//9. Write prograams to implement one dimentional and two dimentional array.

OUTPUT: 

using System;

class ArrayDemo
{
    static void Main()
    {
        int[] arr1D = {1,2,3,4,5};
        Console.WriteLine("1D Array: "+ string.Join(", ", arr1D));
        
         int[,] arr2D = {{1,2},{3,4}};
        Console.WriteLine("2D Array: "+ arr2D[0,0]+ " "+arr2D[0,1]);
    }
}


//10. Write a program to understand the working of predefined string functions.

OUTPUT:

using System;

class StringFunctions
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        
        Console.WriteLine("Compare: " + str1.CompareTo(str2));
        Console.WriteLine("Concat: " + string.Concat(str1, " ", str2));
        Console.WriteLine("Join: " + string.Join(", ", str1, str2));
        
    }
}