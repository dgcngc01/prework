// Author: Doug Coffey
// Date:   12/10/2022
// 
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable2
{
    public class Deliverable2
    {
        public static void Main(string[] args)
        {
            // Initialize constants 
            const decimal buffetPrice = 9.99M;
            const int coffeePrice = 2;
            int numCoffeeOrdered = 0;
            int numWaterOrdered = 0;
            decimal totalPrice;
            string drinkOrdered;

            //Ask how many people are in the party
            Console.WriteLine("Hi. Welcome to our Doug's Buffet. It is all you can eat for $9.99! We only charge extra\nfor coffee. " +
                               "How many people are in your group? Please, parties of 6 or lower.");
            int numCustomers = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nA table for '{numCustomers}'! Please follow me and take a seat.\n" +
                    "Let's get everyone started with some drinks. We've got water or coffee.\n");

            //Process the customers orders
            if (numCustomers <= 6)
            {
                // process number of customers
                for (int j = 1; j <= numCustomers; j++)
                {
                    // body of inner for loop
                    Console.WriteLine($"Alright, person number {j}, water or coffee?");
                    drinkOrdered = Console.ReadLine();
                    if (drinkOrdered == "water")
                    {
                        numWaterOrdered = numWaterOrdered + 1;
                        Console.WriteLine("Water, excellent!\n");
                    }
                    else if (drinkOrdered == "coffee")
                    {
                        numCoffeeOrdered = numCoffeeOrdered + 1;
                        Console.WriteLine("Coffee, it is, party on!\n");
                    }
                    else
                        Console.WriteLine($"Unfortunately, that isn't a drink option.\n");
                }
            }
            //Party too large message
            else
            {
                Console.WriteLine("Sorry, we can only seat parties of 6 or less.  Please have a good day (press any key to exit)");

            }

            // Display the drinks ordered
            Console.WriteLine($"Okay, so that's {numCoffeeOrdered} coffee(s) and + {numWaterOrdered} water(s).\n" +
                              "I'll be right back. Feel free to grab your food!\n");

            //calc total price and display the bill
            totalPrice = (buffetPrice * numCustomers) + (numCoffeeOrdered * coffeePrice);
            Console.WriteLine($"Here's your bill! Total price: {totalPrice.ToString("c")}\n");

            //exit the app
            Console.ReadLine();
        }
    }
}