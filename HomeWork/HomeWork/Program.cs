using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            string txt = "kitab";

            for (int i = 0; i <= txt.Length; i++)
            {
                if (txt[i] == 'a')
                {
                    Console.WriteLine("a var");
                }
                else
                {
                    Console.WriteLine("a yoxdur");
                }
            }

            //task2
            int num = 132;
            if (num % 2 ==0)
            {
                Console.WriteLine("cutdur");
            }
            else
            {
                Console.WriteLine("tekdir");
            }
            
        }
        
    }
}
