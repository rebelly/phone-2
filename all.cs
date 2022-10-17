using System;

public class Program
{
    static int max_sum_seq(int n)
    {
        
        int prev = int.Parse(Console.ReadLine());
        int cur = int.Parse(Console.ReadLine());
        int res = prev+cur;
        for (int i = 3; i<= n; i++)
        {
            prev = cur;
            cur = int.Parse(Console.ReadLine()); ;
            if (cur + prev > res)
            {
                res = cur + prev;
            }
        }
        return res;
    }
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int answ = max_sum_seq(n);
        Console.WriteLine(answ);
    }
}
