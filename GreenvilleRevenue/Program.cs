using System;
class Program
{
    static void Main(string[] args)
    {

        bool displayManu = true;

        while(displayManu)
        {
            Console.WriteLine("");
            GreenvilleMotto.Display();
            Console.WriteLine("Please Enter the following number below from the following menu: ");
            Console.WriteLine("1. Calculate Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");


            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1){
                RevenueCalculator.Calculate();
            }
            else if(choice == 2){
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!.");
                displayManu = false;
                break;
            }
            else{
                Console.WriteLine("Invalid Choice. Please try again.");
                break;
            }
        }

        
    }
}