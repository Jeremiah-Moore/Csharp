﻿// Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0; //(num1 and num2 are the variables) 0 is there value
// int = initialize

//Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("-------------------------\n");

//Ask the user to type the first(num1) number
Console.WriteLine("Type a number, and then press enter");
num1 = Convert.ToInt32(Console.ReadLine()); // console write line is what ever question or statement I ask or tell the user
//Console.ReadLine is the user's response or answer

//Ask the user to type the second(num2) number
Console.WriteLine("Type a number, and then press enter");
num2 = Convert.ToInt32(Console.ReadLine());

//Ask the user to choose an option
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Your option?");

//Use a switch statement to do the math
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} =" + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} =" + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} =" + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} =" + (num1 / num2));
        break;
}
//Wait for the user  to respond before closing.
Console.WriteLine("Press any key to close the Calculator console app...");
Console.ReadLine();
