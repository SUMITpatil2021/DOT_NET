using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Exceptions
{

   
    internal class UserRegistration
    {

        public static void UserRegister(string UserName, string UserCountry)
        {
            try
            {
                if (!UserCountry.Equals("India"))
                    {
                    throw new InValidCountryException("User Outside India Cannot  be Registerd  ");
                }
                else
                {
                    Console.WriteLine("User Registration Done Succesfully ");
                }
            }
            catch(InValidCountryException e)
            {
                Console.WriteLine(value : e.Message);
            }

        }
        public static void Main(string[] args)
        {
            
                Console.WriteLine("Enter the User Name : ");
                string UserName = Console.ReadLine();
                Console.WriteLine("Enter the User Country : ");
                string UserCountry = Console.ReadLine();
                UserRegister(UserName, UserCountry);
        }
    }
}
