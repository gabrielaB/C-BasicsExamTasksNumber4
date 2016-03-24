using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsExamTask4
{
    class FiveSpecialLetters
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Dictionary<string, int> lettersWeigth = new Dictionary<string, int>()
            {
                {"a", 5},
                {"b", -12},
                {"c", 47},
                {"d", 7},
                {"e", -32}
            };

            List<string> outputWords = new List<string>();

            foreach (KeyValuePair<string, int> p1 in lettersWeigth)
            {
                foreach (KeyValuePair<string, int> p2 in lettersWeigth)
                {
                    foreach (KeyValuePair<string, int> p3 in lettersWeigth)
                    {
                        foreach (KeyValuePair<string, int> p4 in lettersWeigth)
                        {
                            foreach (KeyValuePair<string, int> p5 in lettersWeigth)
                            {
                                string result = p1.Key + p2.Key + p3.Key + p4.Key + p5.Key;
                                string originalWord = result;
                                result = RemoveDuplicates(result);
                                int weight = 0;

                                for (int i = 0; i < result.Length; i++)
                                {
                                    string currentLetter = result[i].ToString();
                                    weight += (i + 1) * lettersWeigth[currentLetter];
                                }

                                if(weight >= start && weight <= end)
                                {
                                    outputWords.Add(originalWord);
                                }
                            }
                        }
                    }
                }
            }

            outputWords.Sort();
            if (outputWords.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", outputWords));
            }
        }

        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }
    }
}
