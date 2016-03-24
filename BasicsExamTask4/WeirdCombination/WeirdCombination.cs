using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdCombination
{
    class WeirdCombination
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char[] elements = input.ToCharArray();
            int counter = 0;
            bool hasResult = false;

            foreach (char e1 in elements)
            {
                foreach (char e2 in elements)
                {
                    foreach (char e3 in elements)
                    {
                        foreach (char e4 in elements)
                        {
                            foreach (char e5 in elements)
                            {
                                counter++;
                                if (counter == n + 1)
                                {
                                    string result = e1 + "" + e2 + "" + e3 + "" + e4 + "" + e5;
                                    Console.WriteLine(result);
                                    hasResult = true;
                                }
                            }
                        }
                    }
                }
            }
            if (!hasResult)
            {
                Console.WriteLine("No");
            }
        }
    }
}
