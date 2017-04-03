using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FzBz
    {
        //based of codeeval read from file code
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\princ\Documents\Notes\CodeEval_fizzBuzz.txt"))
                while (!reader.EndOfStream)
                {
                    string input = reader.ReadLine();
                    if (null == input)
                        continue;

                    string[] fbList = input.Split(' ');
                    //Console.WriteLine(fbList[2]);

                    int X = int.Parse(fbList[0]);
                    int Y = int.Parse(fbList[1]);
                    int N = int.Parse(fbList[2]);

                    // Console.WriteLine(X);

                    for (int i = 1; i <= N; i++)
                    {
                        bool FizzIt = i % X == 0;
                        bool BuzzIt = i % Y == 0;
                        bool FizzBuzzIt = FizzIt && BuzzIt;

                        var fizzBuzzOut = new StringBuilder();

                        if (FizzBuzzIt)
                        {
                            fizzBuzzOut.Append("FB");
                        }
                        else if (FizzIt)
                        {
                            fizzBuzzOut.Append("F");
                        }
                        else if (BuzzIt)
                        {
                            fizzBuzzOut.Append("B");
                        }
                        else if (!FizzIt && !BuzzIt)
                        {
                            fizzBuzzOut.Append(i.ToString());
                        }

                        Console.WriteLine(fizzBuzzOut);
                    }
                }

            
            Console.ReadKey();
            #region alternative file read code solution

            // Works too keeping incase proves to be useful
            //IEnumerable<string> input = File.ReadLines(@"C:\Users\princ\Documents\Notes\CodeEval_fizzBuzz.txt");


            //foreach (var fbInstructionLine in input)
            //{

            //    string[] fbList = fbInstructionLine.Split(' ');           
            //    Console.WriteLine(fbList[2]);

            //      This portionn gives the same output as Conosle.WriteLine(input); does in above method
            //    Console.WriteLine(fbInstructionLine);
            //}
            //Console.ReadKey();
            #endregion 
        }

        //public string FizzBuzzIt()
        //{
            
        //}
    }
}
