using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Assign5
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Enter Month in number ");
            int month=int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("Jan");
                    break;
                    case 2:
                    Console.WriteLine("Feb");
                    break;
                    case 3:
                    Console.WriteLine("March");
                    break;  
                    case 4:
                    Console.WriteLine("April"); 
                    break; 
                    case 5:
                    Console.WriteLine("May");
                    break;  
                    case 6:
                    Console.WriteLine("June");
                        break;  
                    case 7:
                    Console.WriteLine("July");
                        break;  
                    case 8:
                    Console.WriteLine("August");
                    break;  
                    case 9:
                    Console.WriteLine("September");
                    break;  
                    case 10:
                    Console.WriteLine("October");
                    break;  

                    case 11:
                    Console.WriteLine("November");
                      break;
                     case 12:
                    Console.WriteLine("December");
                    break;  
            }
        }
    }
}
