using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_II
{
    internal class Person
    {
        private string name;
        private int PhonNo;
        private string email;

        public Person()
        {
            name = "NA";
            PhonNo = 0;
            email = "";

        }
        public Person(string nm, int pno, string mail)
        { 
            name=nm;
            PhonNo = pno;
            email=mail;
        }

        public string ToString()
        { 
            return "[ Name : "+name+" Phono No: "+PhonNo+" Email ID : "+email+"]";
        }
        public int GetPhonNo()
        {
            return PhonNo;
        }
        public string GetEmail() {
            return email;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string nm)
        {
            name = nm;
        }

        public void SetPhoneNo(int pno)
        {
            PhonNo = pno;
        }
        public void SetEmail(string mail)
        {
            email = mail;
        }


    }
}
