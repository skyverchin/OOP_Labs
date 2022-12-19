using System;
using System.Text.RegularExpressions;

namespace lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string compare = "Amogus";
            Regex regex = new Regex(@"[\d]");
            if (regex.IsMatch(compare))
                Console.WriteLine("Number in row");
            else
                Console.WriteLine("OnlyText");
        }
    }
}
