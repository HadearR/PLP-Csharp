using System;
using System.Collections.Generic;

class DataTypes
{
    static void Main(string[] args)
    {
    //Data Types
        //integer
        int myNum = 5;

        //string
        string name = "Hadear";

        //float
        //a number with a decimal point is a double by default so adding f specifies that it is a float type
        float a = 10.5f; 

        //double
        double b = 2.3; 

        //decimal 
        //same idea with decimals, adding the m specifies that it is a decimal
        decimal c = 4.4m;

        //boolean
        bool myBool = true;

        //string (both String and string work but it is more conventional to use string)
        string[] mbtaLines = {"Blue Line","Green Line","Orange Line","Red Line"};
        //to delcare an array, define the variable type with '[]'

        //List
        // Sytax for list: List<T>
        List<int> l = new List<int>();
        l.Add(1);
        l.Add(2);
        l.Add(3);

        //Dictionary in C# is a generic collection that stores key-value pairs
        //defined under System.Collections.Generic namespace
        Dictionary<int, string>
        family = new Dictionary<int, string>
        {
            {1,"Hadear"},
            {2, "Bouchra"},
            {3,"Mikael"}
        };

    //mixed data type operations
        var sum = myNum + a;//int + floats = float
        Console.WriteLine(sum + " is a " + sum.GetType());
        var sum1 = myNum + b;//int + double = double
        Console.WriteLine(sum1 + " is a " + sum1.GetType());
        var sum2 = myNum + c;//int + decimal = decimal
        Console.WriteLine(sum2 + " is a " + sum2.GetType());
        
        



    }
}