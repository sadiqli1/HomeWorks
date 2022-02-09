using System;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1

            int num = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int[] newArr = new int[count];
            if (num <= 50)
            {
                for (int i = 4; i < num; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                        newArr[i] = i;

                    }
                }
            }
            else if (num > 50 && num <= 100)
            {
                for (int i = 6; i < num; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                        newArr[i] = i;
                    }
                }
            }
            else
            {
                for (int i = 9; i < num; i++)
                {
                    if (i % 8 == 0)
                    {
                        count++;
                        newArr[i] = i;
                    }
                }
            }
            foreach (int divided in newArr)
            {
                Console.WriteLine(divided);
            }
            #endregion

            #region task2

            //string[] words = {"kitab" , "stol" , "defter" , "telefon" , "kart" };

            //foreach (string word in words)
            //{
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        Console.WriteLine(i);

            //    }             
            //}

            #endregion

            #region task3

            //int num = 214;
            //int sum = 0;


            #endregion

        }
    }
}
