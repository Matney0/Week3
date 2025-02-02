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
            //Provides user 3 different options
            Console.WriteLine("Welcome! Which currency did you want to convert? 1-USD to Yen  2-Yen to Euro  3-Euro to USD");
            //reading user input
            string userInput = Console.ReadLine();

            //Loop processing
            //First user option is for USD
            if (userInput == "1")
            {
                Console.WriteLine("Enter the amount of USD you want to convert Yen: ");
                //converts and reads value since it wont likely be a whole number
                usd = Convert.ToDouble(Console.ReadLine());
                //value of USD in comparison to Yen
                yen = usd * 109.23;
                //Converted amount
                Console.WriteLine("The amount of Yen you will get is: " + yen);
                Console.ReadLine();
            }
          //input option for Yen Conversion
            else if (userInput == "2")
            {
                Console.WriteLine("Enter the amount of Yen you want to convert to Euro: ");
                //converts and reads value since it wont likely be a whole number
                yen = Convert.ToDouble(Console.ReadLine());
                //Value of Yen in comparison to Euro
                euro = yen / 105.23;
                //Converted amount
                Console.WriteLine("The amount of USD you will get is: " + euro);
                Console.ReadLine();
            }
          //input option for Euro conversion 
            else if (userInput == "3")
            {
                Console.WriteLine("Enter the amount of Euro you want to convert to USD: ");
                //converts and reads value since it wont likely be a whole number
                euro = Convert.ToDouble(Console.ReadLine());
                //Value of Euro in comparison to USD
                usd = euro * 1.18;
                //Converted amount
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
