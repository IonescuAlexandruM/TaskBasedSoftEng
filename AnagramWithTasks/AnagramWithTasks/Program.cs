using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Anagram_solver
{
    class Program
    {

        static void Main(string[] args)
        {
            int anagramCount = 0;
            int anagramCount1 = 0;
            int anagramCount2 = 0;
            int anagramCount3 = 0;
            int anagramCount4 = 0;
            int anagramCount5 = 0;
            int anagramCount6 = 0;
            int anagramCount7 = 0;
            int anagramCount8 = 0;
            int anagramCount9 = 0;
            int anagramCount10 = 0;

            //read all lines as strings
            string[] wordList = File.ReadAllLines(@"C:\Users\i010391k\Desktop\wordlist.txt");
            string[] wordListSorted = File.ReadAllLines(@"C:\Users\i010391k\Desktop\wordlist.txt");
            List<string> lenght1 = new List<string>();
            List<string> lenght2 = new List<string>();
            List<string> lenght3 = new List<string>();
            List<string> lenght4 = new List<string>();
            List<string> lenght5 = new List<string>();
            List<string> lenght6 = new List<string>();
            List<string> lenght7 = new List<string>();
            List<string> lenght8 = new List<string>();
            List<string> lenght9 = new List<string>();
            List<string> lenghtMoreThan10 = new List<string>();

            List<string> lenghtS1 = new List<string>();
            List<string> lenghtS2 = new List<string>();
            List<string> lenghtS3 = new List<string>();
            List<string> lenghtS4 = new List<string>();
            List<string> lenghtS5 = new List<string>();
            List<string> lenghtS6 = new List<string>();
            List<string> lenghtS7 = new List<string>();
            List<string> lenghtS8 = new List<string>();
            List<string> lenghtS9 = new List<string>();
            List<string> lenghtMoreThanS10 = new List<string>();




            //for each string ->toChar, ->sort, ->backToString
            for (int i = 0; i < wordListSorted.Length; i++)
            {
                char[] ch = (wordListSorted[i].ToLower()).ToCharArray();

                Array.Sort(ch);

                string word = new string(ch);

                wordListSorted[i] = word;
                for (int j = 1; j <= 10; j++)
                {
                    if (wordListSorted[i].Length == j)
                    {
                        if (j == 1)
                        {
                            lenghtS1.Add(wordListSorted[i]);
                        }
                        else if (j == 2)
                        {
                            lenghtS2.Add(wordListSorted[i]);
                        }
                        else if (j == 3)
                        {
                            lenghtS3.Add(wordListSorted[i]);
                        }
                        else if (j == 4)
                        {
                            lenghtS4.Add(wordListSorted[i]);
                        }
                        else if (j == 5)
                        {
                            lenghtS5.Add(wordListSorted[i]);
                        }
                        else if (j == 6)
                        {
                            lenghtS6.Add(wordListSorted[i]);
                        }
                        else if (j == 7)
                        {
                            lenghtS7.Add(wordListSorted[i]);
                        }
                        else if (j == 8)
                        {
                            lenghtS8.Add(wordListSorted[i]);
                        }
                        else if (j == 9)
                        {
                            lenghtS9.Add(wordListSorted[i]);
                        }
                        else
                        {
                            lenghtMoreThanS10.Add(wordListSorted[i]);
                        }
                    }
                }

            }

            for (int i = 0; i < wordList.Length; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (wordList[i].Length == j)
                    {
                        if (j == 1)
                        {
                            lenght1.Add(wordList[i]);
                        }
                        else if (j == 2)
                        {
                            lenght2.Add(wordList[i]);
                        }
                        else if (j == 3)
                        {
                            lenght3.Add(wordList[i]);
                        }
                        else if (j == 4)
                        {
                            lenght4.Add(wordList[i]);
                        }
                        else if (j == 5)
                        {
                            lenght5.Add(wordList[i]);
                        }
                        else if (j == 6)
                        {
                            lenght6.Add(wordList[i]);
                        }
                        else if (j == 7)
                        {
                            lenght7.Add(wordList[i]);
                        }
                        else if (j == 8)
                        {
                            lenght8.Add(wordList[i]);
                        }
                        else if (j == 9)
                        {
                            lenght9.Add(wordList[i]);
                        }
                        else
                        {
                            lenghtMoreThan10.Add(wordList[i]);
                        }
                    }
                }
            }

            


            int[] numbers = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = i;
            }

            //foreach (int num in numbers)
            //   Console.WriteLine(num);
            System.Random rand = new Random();

            while (true)
            {
                string wordOne = wordListSorted[rand.Next(0, wordListSorted.Length)];
                Console.WriteLine("Selected word is " + wordOne);
                int counter = 0;
                Parallel.ForEach(wordListSorted, word =>
                       {

                           if (word == wordOne)
                           {
                               Console.WriteLine("Word = " + word);
                               counter++;

                           }

                           //does word appear in the sorted list again?
                           //if it does add to the counter 
                           //if not move on
                           // Console.WriteLine(word);

                       }

                    );

                Thread.Sleep(1000);
            }
        }
    }

    public static class ThreadWorking
    {


        public static void FindAnagram(List<string> listS, List<string> list, ref int anagramCount)
        {

            for (int i = 0; i < listS.Count; i++)
            {
                for (int j = i + 1; j < listS.Count; j++)
                {
                    if (listS[i] != "" && listS[j] != "")
                        if (listS[i] == listS[j])
                        {
                            list[i] += " ,,,,,,,,,,,," + list[j];
                            anagramCount++;
                        }
                }
                //Console.WriteLine(list[i]);
            }
        }
    }


}
