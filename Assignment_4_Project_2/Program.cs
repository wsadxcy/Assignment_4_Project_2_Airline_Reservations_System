using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author : Chenyuan Xie
 * Date : July 19th, 2016
 * Date Modified: Jul 22th, 2016
 * Description : Assignment 4 Project 2 Airline Reservations System
 * Version : 1.0 - 
 *                  Added Documentary
 *                  Initial release
 */
namespace Assignment_4_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstclass = 0;
            int economy = 0;
            List<string> availableseat = new List<string>();// List for Available Seat
            List<string> assignedseat = new List<string>();// List For Assigned Seat
            // Add seat to available seat
            availableseat.Add("Economy");
            availableseat.Add("First Class");
            availableseat.Add("Economy");
            availableseat.Add("First Class");
            availableseat.Add("Economy");
            availableseat.Add("First Class");
            availableseat.Add("Economy");
            availableseat.Add("First Class");
            availableseat.Add("Economy");
            availableseat.Add("First Class");

            // Display alternatives inside a while loop
            while (economy < 5 || firstclass < 5)
            {
                Console.WriteLine("Please make a selection");
                Console.WriteLine("1 for First Class, 2 for Economy, 3 Exit ");
                

                int switchclass = Convert.ToInt32(Console.ReadLine());
                
                switch (switchclass)// Switch statement 
                {
                    case 1:
                        Console.WriteLine("First Class");
                        if (availableseat.Contains("First Class"))
                        {
                            firstclass++;
                            
                            assignedseat.Add("First Class");
                            availableseat.Remove("First Class");
                            break;
                        }
                        else if (availableseat.Contains("Economy"))
                        {
                            Console.WriteLine("	Is it acceptable to be placed in the Economy section. \n 1-yes  2-no");

                            int selection = Convert.ToInt32(Console.ReadLine());
                            if(selection == 1)
                            {
                                economy++;

                                availableseat.Add("Economy");
                                availableseat.Remove("Economy");
                            }
                            if(selection == 2)
                            {
                                Console.WriteLine("Next flight leaves in 3 hours.");
                            }
                        }
                        
                            break;
                    case 2:
                        Console.WriteLine("Economy");
                        if (availableseat.Contains("Economy"))
                        {
                            economy++;
                            
                            availableseat.Add("Economy");
                            availableseat.Remove("Economy");
                            break;
                        }
                        else if (availableseat.Contains("First Class"))
                        {
                            Console.WriteLine("	Is it acceptable to be placed in the First Class section. \n 1-yes  2-no");
                            int selection = Convert.ToInt32(Console.ReadLine());
                            if (selection == 1)
                            {
                                economy++;

                                availableseat.Add("First Class");
                                availableseat.Remove("First Class");
                            }
                            if (selection == 2)
                            {
                                Console.WriteLine("Next flight leaves in 3 hours.");
                            }
                        }
                        
                        break;
                    case 3:
                        return;

                }
            }

            
        }
    }
}
