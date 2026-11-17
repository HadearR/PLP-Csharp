using System;
using System.Collections.Generic;
using System.Globalization;


class Methods
{
    //1.Write a function that takes in two numbers, multiplies them, and returns the output
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    //2.Write a recursive method to calculate sum
    static int Sum(int n)
    {
        if (n <= 1)
            return n;

        return n + Sum(n-1);
    }
    //3.Write a method that takes in a string and splits it into two strings, then returns both strings
    static string[] SplitString(string phrase)
    {
        return phrase.Split(' ');
    }
    //5.Write a function that tests whether your language is pass-by-reference or pass-by-value
    //pass-by-value
    static void PassByVal(int num)
    {
        num = 100;
    }
    //pass-by-reference
    static void PassByRef(ref int num)
    {
        num = 100;
    }
    static void Main()
    {
        //4. Call your methods and save the results of the method calls in variables.
        int result = Multiply(5, 3);
        Console.WriteLine(result);

        int n = 4;
        int sumResult = Sum(n);
        Console.WriteLine("Sum of numbers from 1 to " + n + " = " + sumResult);
        
        string phrase = "Hello World";
        string[] words = SplitString(phrase);
        Console.WriteLine(words[0]);
        Console.WriteLine(words[1]);

        //pass-by-value
        int numVal = 10;
        PassByVal(numVal);
        Console.WriteLine(numVal);

        //pass-by-reference
        int numRef = 10;
        PassByRef(ref numRef);
        Console.WriteLine(numRef); 


    }

}
