//Code generated mostly by AI

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Choice Adventures!");
        
        
        Console.Write("What is your name? ");
        string playerName = Console.ReadLine();
        
        Console.WriteLine($"\nHello, {playerName}! Let's begin your adventure.");

        
        Console.WriteLine("\nQuestion 1: Where would you like to go?");
        Console.WriteLine("1) A magical forest");
        Console.WriteLine("2) A futuristic city");
        Console.WriteLine("3) An antique city");
        Console.WriteLine("4) A mountain peak");
        Console.Write("Your choice (1-4): ");
        int choice1 = int.Parse(Console.ReadLine());

        
        Console.WriteLine("\nQuestion 2: What would you take with you?");
        Console.WriteLine("1) A map");
        Console.WriteLine("2) A sword");
        Console.WriteLine("3) A mysterious book");
        Console.WriteLine("4) Nothing, I travel light");
        Console.Write("Your choice (1-4): ");
        int choice2 = int.Parse(Console.ReadLine());

        
        Console.WriteLine("\nQuestion 3: What superpower would you like?");
        Console.WriteLine("1) Flying");
        Console.WriteLine("2) Invisibility");
        Console.WriteLine("3) Super strength");
        Console.WriteLine("4) Reading minds");
        Console.Write("Your choice (1-4): ");
        int choice3 = int.Parse(Console.ReadLine());

        
        Console.WriteLine("\n--- Your Adventure ---");
        if (choice1 == 1 && choice3 == 1)
        {
            Console.WriteLine($"{playerName}, you soared above the magical forest with your newfound power of flight, discovering hidden wonders!");
        }
        else if (choice1 == 2 && choice2 == 3)
        {
            Console.WriteLine($"{playerName}, in the futuristic city, the mysterious book unlocked secrets that changed the world!");
        }
        else
        {
            Console.WriteLine($"{playerName}, your journey was unique and full of surprises. Who knows where your choices will lead next?");
        }

        Console.WriteLine("\nThank you for playing!");
    }
}
