using System;
using System.Collections.Generic;

//Like Java and other c languages you have to put the data type
//type variableName = value;

//int 
int myNum = 3;
//String
String name = "Hadear";
//Float
float a = 10.5f; // f at the end to specify that it is a float type
//boolean
bool myBool = true;


String[] MBTA = {"Blue Line","Green Line","Orange Line","Red Line"};
//to delcare an array, define the variable type with '[]'

// Sytax for list: List<T>
List<int> l = new List<int>();
l.Add(1);
l.Add(2);
l.Add(3);
Console.Write(l.Contains(2));

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



