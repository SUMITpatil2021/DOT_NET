using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAssignment
{
    internal class PersonDemo
    {
        static void Main(string[] args)
        {
         /* Person person = new Person();
            person.Display(); */
          
            Type t=typeof(Person);
            Console.WriteLine("Name : "+ t.Name);
            Console.WriteLine("FullName"+t.FullName);
            Console.WriteLine("Assembly : " + t.Assembly);
            Console.WriteLine("---------------Constructors------");
           foreach (var item in t.GetConstructors())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------- Methods ----------");
            foreach(var item in t.GetMethods())
            {  Console.WriteLine(item); }  




        }
       

    }
}
