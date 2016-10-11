using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            GetComments();

            Console.ReadKey();
        }

        static void GetComments()
        {
            Regex r = new Regex(
@"/\*.*\*/",
                    RegexOptions.IgnorePatternWhitespace
                );
            string script =
@"/*
function f() {
}
*/
function g() {
}";
            Console.WriteLine(script.IndexOf(@"/*"));
            Match m = r.Match(script);
            Console.WriteLine(m.Value);

            //TODO: how?
            // where
        }
    }
}
