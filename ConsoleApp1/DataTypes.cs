using System;
using System.Collections.Generic;

class DataTypes
{
    static void Main(string[] args)
    {
        //integer
        int myNum = 5;
        //string
        string name = "Hadear";
        //float
        float a = 10.5f; // f at the end to specify that it is a float type
        //double
        
        //boolean
        bool myBool = true;
        string[] mbtaLines = {"Blue Line","Green Line","Orange Line","Red Line"};
        //to delcare an array, define the variable type with '[]'
        // Sytax for list: List<T>
        List<int> l = new List<int>();
        l.Add(1);
        l.Add(2);
        l.Add(3);
        Console.WriteLine(l.Contains(2));

        //dictionary
        //Dictionary in C# is a generic collection that stores key-value pairs
        //defined under System.Collections.Generic namespace

        Dictionary<int, string>
        family = new Dictionary<int, string>
        {
            {24,"Hadear"},
            {50, "Bouchra"},
            {18,"Noor"}
        };
    }
}