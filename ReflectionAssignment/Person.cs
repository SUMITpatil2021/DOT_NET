using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAssignment
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int PhoneNo { get; set; }
        public string email { get; set; }
        public Person() {
            Id = 0;
            Name = "Annonymous";
            PhoneNo = 0;
            email = "abc@gmail.com";
        }
        public  void Display()
        {
            Console.WriteLine("ID:" + Id);
            Console.WriteLine("Name" + Name);
            Console.WriteLine("Phone No : " + PhoneNo);
            Console.WriteLine("EMail :" + email);
        }
      
    }
}
