using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Exceptions
{
    internal class InValidCountryException:Exception
    {
       
           public InValidCountryException(string msg) 
           {
                 
               Console.WriteLine(msg);
        }

       
    }
}
