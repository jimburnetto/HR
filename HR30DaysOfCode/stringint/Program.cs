using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        int Out;
        try
        {
            Out = Int32.Parse(S);
            Console.WriteLine(Out);
        }
        catch (Exception)
        {

            Console.WriteLine("Bad String");
        }

    }
}
