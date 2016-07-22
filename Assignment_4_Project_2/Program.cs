using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author : Chenyuan Xie
 * Date : July 19th, 2016
 * Date Modified: Jul 22th, 2016
 * Description : Assignment 4 Project 2 Airline Reservations System
 * Version : 0.5 - 
 *                  Added Lists
 */
namespace Assignment_4_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstclass = 0;
            int economy = 0;
            List<string> availableseat = new List<string>();
            availableseat.Add("Economy");
            availableseat.Add("Economy");
            availableseat.Add("Economy");
            availableseat.Add("Economy");
            availableseat.Add("Economy");
            List<string> assignedseat = new List<string>();
            assignedseat.Add("First class");
            assignedseat.Add("First class");
            assignedseat.Add("First class");
            assignedseat.Add("First class");
            assignedseat.Add("First class");

            while (availableseat.Count != 0 || assignedseat.Count != 0)
            {
                Console.WriteLine("Please make a selection");
                Console.WriteLine("1 for First Class, 2 for Economy, 3 Exit ");

                int switchclass = Convert.ToInt32(Console.ReadLine());
                
                switch (switchclass)
                {
                    case 1:
                        Console.WriteLine("First Class");
                        while (firstclass < 5)
                        {
                            firstclass++;
                            
                            assignedseat.RemoveAt(1);
                            break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Economy");
                        while (economy < 5)
                        {
                            economy++;
                            
                            availableseat.RemoveAt(1);
                            break;
                        }
                        break;
                    case 3:
                        return;

                }
            }

            
        }
    }
}
