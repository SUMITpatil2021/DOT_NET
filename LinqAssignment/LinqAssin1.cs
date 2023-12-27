using System;

public class LinqAss1
{
    static void Main(string[] args)
    {
        int[] arr = { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };

        //count number of element in array
        var cnt = (from num in arr select num).Count();
        Console.WriteLine("Count using query: "+cnt);

        var cntMethod = arr.Count();
        Console.WriteLine("Count using method: "+cntMethod);
        
        //count element greater than 40
        var cnt1 = (from num in arr where num>40 select num).Count();
        Console.WriteLine("Count >40 using query: " + cnt1);

        var cntMethod1 = arr.Where(x => x > 40).Count();
        Console.WriteLine("Count >40 using method: " + cntMethod1);

        //count element between 10 and 60
        var cnt2 = (from num in arr where num > 10 && num < 60 select num).Count();
        Console.WriteLine("Count between 10 and 60 using query: " + cnt2);

        var cntMethod2 = arr.Where(x => x>10 && x < 60).Count();
        Console.WriteLine("Count between 10 and 60 using method: " + cntMethod2);

        //all records in ascending
        var res = from ele in arr orderby(ele) select ele;

        foreach (var ele in res) 
            Console.WriteLine(ele+", ");

        var resMethod = arr.OrderBy(x => x);
            Console.WriteLine(resMethod);

        //all records in decending 
        var ord = arr.OrderByDescending(x=>x)
    }
}
