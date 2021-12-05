using System;
using System.Linq;

namespace Rates
{
    public class Bits
    {
        public static void BinaryToRate()
        {
            var zeros = 0;
            var ones = 0;
            var gamma = "";
            var epsilon = "";
            var instructions = System.IO.File.ReadAllLines(@"C:\Users\MichaelRichardson\code\advent2021\input-3.txt");
            for (var i = 0; i < instructions[0].Length; i++)
            {
                for (var s = 0; s < instructions.Length; s++)
                {
                    if (instructions[s][i].ToString() == "0")
                    {
                        zeros++;
                    }
                    else
                    {
                        ones++;
                    }
                }
                if (zeros > ones)
                {
                    gamma += "0";
                    zeros = 0;
                    ones = 0;
                }
                else
                {
                    gamma += "1";
                    ones = 0;
                    zeros = 0;
                }
            }
            for (var i = 0;i < gamma.Length;i++)
            {
                if(gamma[i].ToString() == "0")
                {
                    epsilon += "1";
                } else
                {
                    epsilon += "0";
                }
            }
            Console.WriteLine(BinaryFromString(gamma) * BinaryFromString(epsilon));
            Console.ReadLine();
        }
        public static void OxygenScrubber()
        {
            var zeros = 0;
            var ones = 0;
            var zeros2 = 0;
            var ones2 = 0;
            var oxygen = System.IO.File.ReadAllLines(@"C:\Users\MichaelRichardson\code\advent2021\input-3.txt");
            var scrubber = System.IO.File.ReadAllLines(@"C:\Users\MichaelRichardson\code\advent2021\input-3.txt");
            for (var i = 0; i < oxygen[0].Length; i++)
            {
                for (var s = 0; s < oxygen.Length; s++)
                {
                    if (oxygen[s][i].ToString() == "0")
                    {
                        zeros++;
                    }
                    else
                    {
                        ones++;
                    }
                }
                for (var s = 0; s < scrubber.Length; s++)
                {
                    if (scrubber[s][i].ToString() == "0")
                    {
                        zeros2++;
                    }
                    else
                    {
                        ones2++;
                    }
                }

                if (zeros == ones)
                {
                    oxygen = oxygen.Where(oxy => oxy[i].ToString() == "1").ToArray();
                }
                if (zeros > ones)
                {
                    oxygen = oxygen.Where(oxy => oxy[i].ToString() != "1").ToArray();
                    zeros = 0;
                    ones = 0;
                }
                else if (ones > zeros)
                {
                    oxygen = oxygen.Where(oxy => oxy[i].ToString() == "1").ToArray();
                    ones = 0;
                    zeros = 0;
                }
                if (zeros2 == ones2)
                {
                    if (scrubber.Length == 1)
                    {
                        Console.WriteLine(scrubber[0]);
                    }
                    else
                    {
                        scrubber = scrubber.Where(scrub => scrub[i].ToString() != "1").ToArray();
                    }
                }
                if (zeros2 > ones2)
                {
                    if (scrubber.Length == 1)
                    {
                        Console.WriteLine(scrubber[0]);
                    }
                    else
                    {
                    scrubber = scrubber.Where(scrub => scrub[i].ToString() == "1").ToArray();
                    zeros2 = 0;
                    ones2 = 0;
                    }
                }
                else if (ones2 > zeros2)
                {
                    if (scrubber.Length == 1)
                    {
                        Console.WriteLine(scrubber[0]);
                    }
                    else
                    {
                    scrubber = scrubber.Where(scrub => scrub[i].ToString() != "1").ToArray();
                    ones2 = 0;
                    zeros2 = 0;
                    }
                }
            }
            Console.WriteLine(oxygen[0]);
            Console.WriteLine(scrubber[0]);
            Console.WriteLine(BinaryFromString(scrubber[0]) * BinaryFromString(oxygen[0]));
            Console.ReadLine();
        }
        public static double BinaryFromString(string toBinary)
        {
            var equals = 0.0;
            for (var i = 0; i < toBinary.Length; i++)
            {
                var Num = int.Parse(toBinary[i].ToString());
                if(Num == 1)
                {
                    equals += Math.Pow(2, (toBinary.Length - (i + 1)));
                }
            }
            return equals;
        }
    }
}