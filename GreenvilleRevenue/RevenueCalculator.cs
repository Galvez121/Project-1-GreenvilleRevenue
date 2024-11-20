using System;

public class RevenueCalculator
{
    public static void Calculate()
    {
        int lastYearContestants = 0;
        int currentYearContestants = 0;

        while(true){

            Console.Write("Enter last year's number of contestants: ");
            lastYearContestants = int.Parse(Console.ReadLine());
            if (lastYearContestants >= 0 && lastYearContestants <= 30){
                break;
            }
            else{
                Console.WriteLine("Please enter a number between 0 and 30");
            }

            
        }

        while(true){
            Console.Write("Enter this year's number of contestants: ");
            currentYearContestants = int.Parse(Console.ReadLine());
            if(currentYearContestants >= 0 && currentYearContestants <= 30){
                break;
            }
            else{
                Console.WriteLine("Please enter a number between 0 and 30");
            }
        }


        // Calculation for the renenue
        int ticketCost = 25;
        int currentYearRevenue = currentYearContestants * ticketCost;

        // Results
        Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants.");
        Console.WriteLine("Revenue expected this year is {0}", currentYearRevenue);
       
        // Comparison for contestant
       if (currentYearContestants == 2 * lastYearContestants)
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