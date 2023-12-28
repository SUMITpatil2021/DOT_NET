using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAssignment
{
    internal class Assig2
    {
        static void Main1(string[] args)
        {
            Assembly objAssembly;
            objAssembly = Assembly.GetExecutingAssembly();

            Type[] types=objAssembly.GetTypes();
            Console.WriteLine("----------Name-------------------------");
            foreach (Type obj in types)
            {
                Console.WriteLine(obj.Name.ToString());
            }

            foreach (Type t in types)
            {

                Console.WriteLine("----------Constructors----------------");
                foreach (var i in t.GetConstructors())
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("----------Properties------------------");
                foreach (var  p in t.GetProperties())
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("----------custom Attributes ----------");
                foreach (var i in t.GetCustomAttributes())
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("----------Methods---------------------");
                foreach(var i in t.GetMethods())
                {
                    Console.WriteLine(i);
                }

            }



        }
    }
}
