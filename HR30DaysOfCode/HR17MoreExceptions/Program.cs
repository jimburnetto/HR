using System;

//Write your code here
public class Calculator
{
    public int power(int numerator, int power)
    {
        double ans;
        int iAns;
        ans = Math.Pow(numerator, power);
        try
        {
            iAns = Convert.ToInt32(ans);
            if (numerator < 0 || power < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
        }
        catch (Exception e)
        {
            //Exception err;
            ////err.Message = "n and p should be non-negative";
            //err.
            //throw new Exception("n and p should be non - negative");
            throw e;
        }

        return iAns;
    }
}

class Solution
{
    static void Main(String[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }



    }
}