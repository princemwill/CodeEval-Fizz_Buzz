using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        //pull fromm file script provided by codeeval
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\princ\Documents\Notes\CodeEval_fizzBuzz.txt"))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    Console.WriteLine(line);
                }
            Console.ReadKey();
            
        }
    }
}
