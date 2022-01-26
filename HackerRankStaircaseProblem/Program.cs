using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        string space = " ";
        string hash = "#";

        for (int i = 1; i <= n; i++)
        {

            int jcount = 0;

            for (int j = i; j < n; j++)
            {
                jcount++;
                Console.Write(space);
            }
            for (int k = n; k > jcount; k--)
            {
                Console.Write(hash);
            }
            Console.WriteLine("");
        }

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}