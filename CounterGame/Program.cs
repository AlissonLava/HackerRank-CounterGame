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
using static System.Numerics.BitOperations;

class Result
{
    //https://www.hackerrank.com/challenges/one-month-preparation-kit-counter-game

    public static string counterGame(long n)
    {
        return (TrailingZeroCount((ulong)n) + PopCount((ulong)n) - 1) % 2 == 0 ? "Richard" : "Louise";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            string result = Result.counterGame(n);

            Console.WriteLine(result);
        }
    }
}
