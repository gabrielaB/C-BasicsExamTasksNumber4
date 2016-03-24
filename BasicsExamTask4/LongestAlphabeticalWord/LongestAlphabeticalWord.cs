using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAlphabeticalWord
{
    class LongestAlphabeticalWord
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];
            int letterIndex = 0;
            int maxIndex = word.Length - 1;
            string longestWord = "";

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = word[letterIndex];
                    letterIndex++;
                    if (letterIndex > maxIndex)
                    {
                        letterIndex = 0;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    char currentLetter = matrix[row, col];
                    string currentWord = currentLetter.ToString();
                    longestWord = CheckForLongestWord(currentWord, longestWord);

                    //Check up
                    if (row > 0)
                    {
                        for (int i = row-1; i >=0; i--)
                        {
                            currentWord += matrix[i, col];
                            bool isAlphabetical = CheckAlphabetical(currentWord);
                            if (isAlphabetical)
                            {
                                longestWord = CheckForLongestWord(currentWord, longestWord);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    currentWord = currentLetter.ToString();
                    //Check down
                    if (row < n-1)
                    {
                        for (int i = row + 1; i < n; i++)
                        {
                            currentWord += matrix[i, col];
                            bool isAlphabetical = CheckAlphabetical(currentWord);
                            if (isAlphabetical)
                            {
                                longestWord = CheckForLongestWord(currentWord, longestWord);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    currentWord = currentLetter.ToString();
                    //Check left
                    if (col > 0)
                    {
                        for (int i = col - 1; i >= 0; i--)
                        {
                            currentWord += matrix[row, i];
                            bool isAlphabetical = CheckAlphabetical(currentWord);
                            if (isAlphabetical)
                            {
                                longestWord = CheckForLongestWord(currentWord, longestWord);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    currentWord = currentLetter.ToString();
                    //Check right
                    if (col < n-1)
                    {
                        for (int i = col + 1; i < n; i++)
                        {
                            currentWord += matrix[row, i];
                            bool isAlphabetical = CheckAlphabetical(currentWord);
                            if (isAlphabetical)
                            {
                                longestWord = CheckForLongestWord(currentWord, longestWord);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(longestWord);
        }

        private static string CheckForLongestWord(string currentWord, string longestWord)
        {
            

            if (currentWord.Length >= longestWord.Length)
            {
                if (currentWord.Length == longestWord.Length)
                {
                    int currentWordSum = 0;
                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        currentWordSum += currentWord[i];
                    }

                    int longestWordSum = 0;
                    for (int i = 0; i < longestWord.Length; i++)
                    {
                        longestWordSum += longestWord[i];
                    }

                    if (longestWord == "")
                    {
                        longestWordSum = 200;
                    }

                    if (currentWordSum < longestWordSum)
                    {
                        longestWord = currentWord;
                    }

                }
                else
                {
                    longestWord = currentWord;
                }
                
                
            }
            return longestWord;
        }

        public static bool CheckAlphabetical(string word)
        {
            bool isAlphabetical = true;

            for (int i = 0; i < word.Length-1; i++)
            {
                char currentChar = word[i];
                char nextChar = word[i + 1];
                if (currentChar >= nextChar)
                {
                    isAlphabetical = false;
                    break;
                }
            }
            return isAlphabetical;
        }
    }
}
