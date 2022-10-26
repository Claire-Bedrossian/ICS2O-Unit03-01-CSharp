// Created by: Claire Bedrossian
// Created on: Oct 2022
//
// This program calculates the area of a trapezoid

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double baseA;
        double baseB;
        double height;
        double area;        
        Console.WriteLine("This program calculates the area of a trapezoid.");
        Console.WriteLine("");

        Console.Write("Enter the length of side A (cm): ");
        baseA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the length of side B (cm): ");
        baseB = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the height (cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        area = 0.5 * (baseA + baseB) * height;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");

        Console.WriteLine("\nDone.");
    }
}