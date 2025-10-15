using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1: Add two numbers
            //Call the Addnumbers method
            Addnumbers();

            //Task2: Find the largest of three numbers
            //Call the findlargestnumber method
            Findlargestnumber();

            //Task3: Calculate the average of several numbers
            //call the calculateaverageofseveralnumbers method
            Calculateaverageofseveralnumbers();

            //Task4: Mobile phone battery simulator
            //set initial battery level
            int BatteryLevel = 50;

            //while loop to ask user if they wish to charge or use the phonebefore then calling that method and re-loop if user inputs an invalid selection
            while (true)
            {
                Console.Write("The current battery level is: " + BatteryLevel + "%. Do you wish to 'Charge' or 'Use' the battery? ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "charge")
                {
                    Chargebattery(ref BatteryLevel);
                    break;
                }
                else if (choice == "use")
                {
                    Usebattery(ref BatteryLevel);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter either 'charge' or 'use'.");
                }
            }
           
           
        }

        //Method to ask user for 2 whole numbers and print their sum
        static int Addnumbers()
        {
            // Declare 3 open integer variables
            int num1, num2, sum;
            //Ask for the first number
            Console.Write("Please enter a whole number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //Ask for the second number
            Console.Write("Please enter a 2nd whole number that you wish to add to the first: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //Calculate the sum of the 2 numbers and print it to the console
            sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);
            //Return the sum to the calling method
            return sum;
        }

        //Method to ask user for 3 whole numbers and print the largest
        static int Findlargestnumber()
        {
            // Declare 4 open integer variables
            int num1, num2, num3, largest;         
            //Ask for the first number
            Console.Write("Please enter a whole number: ");
            num1 = Convert.ToInt32(Console.ReadLine());            
            //Ask for the second number
            Console.Write("Please enter a 2nd whole number: ");
            num2 = Convert.ToInt32(Console.ReadLine());            
            //Ask for the third number
            Console.Write("Please enter a 3rd whole number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            //Determine which of the 3 numbers is the largest and print it to the console
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
                Console.WriteLine("The largest of the 3 numbers is: " + largest);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
                Console.WriteLine("The largest of the 3 numbers is: " + largest);
            }
            else
            {
                largest = num3;
                Console.WriteLine("The largest of the 3 numbers is: " + largest);
            }
            //Return the largest number to the calling method
            return largest;
        }

        //Method to ask user for how many numbers they wish to enter, then ask for that many whole numbers and print their average
        static double Calculateaverageofseveralnumbers()
        {
            // Declare open integer and double variables
            int count, i;
            double num, sum = 0, average;         
            //Ask how many numbers the user wishes to enter
            Console.Write("How many whole numbers do you wish to enter? ");
            count = Convert.ToInt32(Console.ReadLine());            
            //Use a for loop to ask for the specified number of whole numbers, adding each to a running total
            for (i = 1; i <= count; i++)
            {
                Console.Write("Please enter whole number " + i + ": ");
                num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }            
            //Calculate the average of the entered numbers and print it to the console
            average = sum / count;
            Console.WriteLine("The average of the " + count + " numbers you entered is: " + average);            
            //Return the average to the calling method
            return average;
        }

        //Method that uses the current battery level as reference, asks how much to charge the battery by, increases the battery level accordingly (without exceeding 100%), print the new battery level to the console
       static void Chargebattery(ref int BatteryLevel)
        {
            //Declare open integer variable
            int chargeAmount;
            //Ask how much the user wishes to charge the battery by
            Console.Write("How much do you wish to charge the battery by (1-100)? ");
            chargeAmount = Convert.ToInt32(Console.ReadLine());
            //Increase the battery level by the specified amount, ensuring it does not exceed 100%
            BatteryLevel += chargeAmount;
            if (BatteryLevel > 100)
            {
                BatteryLevel = 100;
            }
            //Print the new battery level to the console
            Console.WriteLine("The new battery level is: " + BatteryLevel + "%");
        }
        //Method that uses the current battery level as reference, asks how much to use the battery by, decreases the battery level accordingly (without going below 0%), print the new battery level to the console
        static void Usebattery(ref int batteryLevel)
        {
            //Declare open integer variable
            int useAmount;
            //Ask how much the user wishes to use the battery by
            Console.Write("How much do you wish to use the battery by (1-100)? ");
            useAmount = Convert.ToInt32(Console.ReadLine());
            //Decrease the battery level by the specified amount, ensuring it does not go below 0%
            batteryLevel -= useAmount;
            if (batteryLevel < 0)
            {
                batteryLevel = 0;
            }
            //Print the new battery level to the console
            Console.WriteLine("The new battery level is: " + batteryLevel + "%");
        }

    }

}
