using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!\n");

        Console.WriteLine("Enter Length: \n");
        decimal roomLength = decimal.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        Console.WriteLine("Enter Width \n");
        decimal roomWidth = decimal.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        Console.WriteLine("Enter Height: ");
        decimal roomHeight = decimal.Parse(Console.ReadLine());

        decimal roomPerimeter = 2 * (roomLength + roomWidth);
        decimal roomArea = roomWidth * roomLength;
        decimal roomVolume = roomWidth * roomLength * roomHeight;
        decimal roomSurfaceArea = 2 * ((roomLength * roomWidth) + (roomWidth * roomHeight) + (roomLength * roomHeight));

        Console.WriteLine("\nArea of room: " + roomArea + " square feet");
        Console.WriteLine("\nPerimeter: " + roomPerimeter + " feet");
        Console.WriteLine("\nVolume: " + roomVolume + " cubic feet");
        Console.WriteLine("\nSurface Area: " + roomSurfaceArea + " square feet");

        if (roomArea <= 250)
        {
            Console.WriteLine("\nThis is a small room.");
        } 
        else if (roomArea <= 650)
        {
            Console.WriteLine("\nThis is a medium-sized room.");
        } 
        else 
        {
            Console.WriteLine("\nThis is a large room.");        
        }
    }



}