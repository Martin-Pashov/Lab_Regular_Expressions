using System;
using System.Text.RegularExpressions;

namespace Ex1_Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            string inpput = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inpput, pattern);

            foreach (Match name in matches)
            {
                Console.WriteLine(name.Value + " ");
            }
        }
    }
}
