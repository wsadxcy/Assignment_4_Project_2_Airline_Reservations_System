using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author : Chenyuan Xie
 * Date : July 19th, 2016
 * Date Modified: Jul 22th, 2016
 * Description : Assignment 4 Project 2 Airline Reservations System
 * Version : 0.4 - 
 *                  Fixed the while loop
 */
namespace Assignment_4_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstclass = 0;
            int economy = 0;

            while (firstclass < 5 || economy < 5)
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
                            Console.WriteLine(firstclass);
                            break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Economy");
                        while (economy < 5)
                        {
                            economy++;
                            Console.WriteLine(economy);
                            break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;

                }
            }

            
        }
    }
}
