using System;

public class PredicateDelegate
{
    public static bool IsPositive(int no)
    {
        return (no > 0);
    }
    static void main(string[] args)
    {
        Predicate<int> pr = IsPositive;
        Console.WriteLine(pr(10));

        pr += delegate (int no)
        {
            return no < 0;
        };
        Console.WriteLine(pr(20));

        pr += (a) => { return a % 2 == 0; };
        Console.WriteLine("Even num: "+pr(30));
    }
}
