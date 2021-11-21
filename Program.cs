using System;
using System.Linq;

if (args.Count() >= 3)

{
    string operation = args[0];

    if (operation.ToLower() == "add")
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(args.Skip(1).Sum(Convert.ToSingle));
            Console.ResetColor();
        }

        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Only enter numbers");
            Console.ResetColor();
        }
    }
    else if (operation.ToLower() == "div")
    {
        if(args.Count() == 3)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                float n1 = Convert.ToSingle(args[1]);
                float n2 = Convert.ToSingle(args[2]);
                Console.WriteLine(n1 / n2);
                Console.ResetColor();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Only enter numbers");

                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please only enter two numbers to divide by");
            Console.ResetColor();
        }
    }
    else if (operation.ToLower() == "avg")
    {
        try

        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(args.Skip(1).Average(Convert.ToSingle));
            Console.ResetColor();
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Only enter numbers");
            Console.ResetColor();
        }
    }
    else
    {
        error();
    }
}

else if (args.Count() == 1)
{
    if (args[0] == "-help")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("This program is used to do simple and complex calculations, inclduing addition, subtraction and fiding averages. See below on how to work the program: ");

        Console.WriteLine();

        Console.WriteLine("'add' - will allow you to add together a list of numbers. Please type in your numbers, and press enter. Please note each number needs to be seperated by a space.");
        Console.WriteLine("'avg' - will allow yout to find the average of a list of numbers. Please type in your numbers, and press enter. Please note each number needs to be seperated by a space. ");
        Console.WriteLine("'div' - will allow you to divide two numbers. Please type in your numbers, and press enter. Please note each number needs to be seperated by a space.");

        Console.ResetColor();
    }

    else
    {
        error();
    }
}
else
{
    error();
}
void error()
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("ERROR: Invalid argument");
Console.WriteLine("Please enter '-help' in order to learn how to work this program! :) ");
Console.ResetColor();
}