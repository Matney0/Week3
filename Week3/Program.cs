using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class AppDomain
    {
      static void Main(string[] args)
        {
            //Decleration(s)
            double usd, yen, euro;

            //Input(s)
            Console.WriteLine("Welcome! Which currency did you want to convert? 1-USD  2-Yen  3-Euro");

            string userInput = Console.ReadLine();

            //Loop processing
            //First user option is for USD
            if (userInput == "1")
            {
                Console.WriteLine("Enter the amount of USD you want to convert Yen: ");
                usd = Convert.ToDouble(Console.ReadLine());
                yen = usd * 109.23;
                Console.WriteLine("The amount of Yen you will get is: " + yen);
                Console.ReadLine();
            }
          //input option for Yen Conversion
            else if (userInput == "2")
            {
                Console.WriteLine("Enter the amount of Yen you want to convert to Euro: ");
                yen = Convert.ToDouble(Console.ReadLine());
                euro = yen / 105.23;
                Console.WriteLine("The amount of USD you will get is: " + euro);
                Console.ReadLine();
            }
          //input option for Euro conversion 
            else if (userInput == "3")
            {
                Console.WriteLine("Enter the amount of Euro you want to convert to USD: ");
                euro = Convert.ToDouble(Console.ReadLine());
                usd = euro * 1.18;
                Console.WriteLine("The amount of USD you will get is: " + usd);
                Console.ReadLine();
            }
            else
            {
                //User error will cause the user to have to quit the program
                Console.WriteLine("Invalid input. Please try again.");
           
            }




        }
    }
}
