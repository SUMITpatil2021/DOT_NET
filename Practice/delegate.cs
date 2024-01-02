namespace Practice
{
    internal class @delegate
    {
        public delegate void Mydel(string s);

        public static void Upper(string s)
        {
            Console.WriteLine("------Upper-------");
            Console.WriteLine(s.ToUpper());
        }

        public static void Lower(string s)
        {
            Console.WriteLine("------Lower-------");
            Console.WriteLine(s.ToLower());
        }

        public static void print(string s)
        {
            Console.WriteLine("------String-------");
            Console.WriteLine(s);
        }
        static void Main1(string[] args)
        {
            Mydel d = new Mydel(print);

            /* Multicast Delegates  
             d += Upper;
             d += Lower;
             d("suMit");  */

            //Using Func 




        }
    }
}
