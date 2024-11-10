using System;

public class RevenueCalculator
{
    public static void Calculate()
    {
         Console.Write("Enter last year's number of contestants: ");
        int lastYearContestants = int.Parse(Console.ReadLine());

        Console.Write("Enter this year's number of contestants: ");
        int currentYearContestants = int.Parse(Console.ReadLine());

        // Calculation for the renenue
        int ticketCost = 25;
        int currentYearRevenue = currentYearContestants * ticketCost;

        // Results
        Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants.");
        Console.WriteLine("Revenue expected this year is {0}", currentYearRevenue);
       
        // Comparison for contestant
       if (currentYearContestants > 2 * lastYearContestants)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (currentYearContestants > lastYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
} 