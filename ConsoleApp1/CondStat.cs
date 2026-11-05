using System;
using System.Collections.Generic;
class CondStats{
    static void Main()
    {
        OneConditionIf();
        MultiConditionIf();
        LadderStatement();
        ShortCircuit();
        SwitchStatement();
    }
    //1. one-condition if/else statement
    static void OneConditionIf()
    {
        int v = 26;
        if (v > 22)
        {
            Console.WriteLine("True, v is greater than 22");
        }
        else
        {
            Console.WriteLine("False, v is not greater than 22");
        }
    }
    //2. multi-condition if/else statement
    static void MultiConditionIf()
    {
        int x = 5;
        int y = 2;
        if (x > 0 && y < 10)
        {
            Console.WriteLine("x is greater than 0 and y is less than 10");
        }
        else
        {
            Console.WriteLine("at least one condition is false");
        }
    }
    //3. If-else if-else statements
    static void LadderStatement()
    {
        int t = 4;
        if (t == 20)
        {
            Console.WriteLine("t is equal to 20");
        }
        else if (t == 4)
        {
            Console.WriteLine("t is equal to 4");
        }
        else
        {
            Console.Write("value of t is not writen");
        }
    }
    //4. short-circuit logic
    static bool Right()
    {
        Console.WriteLine("Right side ran");
        return true;
    }
    static void ShortCircuit()
    {
        bool a = false && Right();   
        bool b = true || Right();    
        bool c = true && Right();
    }

    //5. a switch-case statement
    static void SwitchStatement()
    {
        int num = 10;
        switch (num)
        {
            case 5:
            Console.WriteLine("case 5");
            break;
            case 10:
            Console.WriteLine("case 10");
            break;
            case 15:
            Console.WriteLine("case 15");
            break;
            default:
            Console.WriteLine("None matches");
            break;   
        }
    }
}
