using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MagicCarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicWeight = int.Parse(Console.ReadLine());
            int counter = 0;
            char[] letters = new char[]
            {
                'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X'
            };
            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9 ; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            for (int x = 0; x < letters.Length; x++)
                            {
                                for (int y = 0; y < letters.Length; y++)
                                {
                                    int sum = 40 + a + b + c + d + (letters[x] - 'A' + 1) * 10 + (letters[y] - 'A' + 1) * 10;
                                    bool firstFormat = a == b && b == c && c == d;
                                    bool secondFormat = a != b && b == c && b == d;
                                    bool thirdFormat = a == b && b == c && c != d;
                                    bool fourthFormat = a == b && c == d && a != d;
                                    bool fifthFormat = a == c && b == d && a != b;
                                    bool sixthFormat = a == d && b == c && a != b;

                                   // string ff = "CA" + a + b + c + d + letters[x] + letters[y];

                                    if (firstFormat || secondFormat || thirdFormat || fourthFormat || fifthFormat || sixthFormat)
                                    {
                                        if (magicWeight == sum)
                                        {
                                            counter++;
                                        }
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
