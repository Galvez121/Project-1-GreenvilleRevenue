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
       
        // Comparison with last year's revenue
        bool isBigger = currentYearContestants > lastYearContestants;
        Console.WriteLine($"It is {isBigger.ToString().ToLower()} that this year's competition is bigger than last year's.");
    }
} 