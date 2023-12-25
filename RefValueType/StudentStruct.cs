using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueType
{

    public struct Student
    {
        private int RollNo { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private int[] MarksArry { get; set; }

        public Student(int rn, string nm, string email, int[] arr)
        {
            RollNo = rn;
            Name = nm;
            Email = email;
            MarksArry = arr;
        }

        public void Display()
        {
            Console.WriteLine("********************************Student Information ****************************");
            Console.WriteLine("Roll No. : "+RollNo);
            Console.WriteLine("Student Name : "+Name);
            Console.WriteLine("Email : "+Email);
            Console.WriteLine("Marks of PHY : " + MarksArry[0]);
            Console.WriteLine("Marks of CHEM : " + MarksArry[1]);
            Console.WriteLine("Marks of Maths : " + MarksArry[2]);
        }
    }



    internal class StudentStruct
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Enter Roll Number :");
            int RollNo=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name of Student : ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Email ID of Student ");
            string email=Console.ReadLine();
            int[] arr=new int[3];   
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter Marks : ");
                arr[i] =int.Parse(Console.ReadLine());   
            }

            Student s=new Student(RollNo, name, email, arr);

            s.Display(); 

            }
    }
}
