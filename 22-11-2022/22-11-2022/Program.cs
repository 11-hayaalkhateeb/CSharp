using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ........................task1.................
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog " };

            //.........................task2.................
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            for (int i = 0; i < fruits.Length; i++)

            {
                if (fruits[i] == "Tomato")
                { Console.WriteLine(i); }

                if (fruits[i] == "Banana")
                { Console.WriteLine(i);
            }
                

            }


            //.........................task3.................
            String[] Food = { "kabsa", "mansaf", "shawrma", "faswlia", "hh" };
            String[] sport = { "football", "baskitball", "swim" };
            String[] Movie = { "zakishan", "vvv", "shawrma", "faswlia" };

            foreach (string i in Food)
            {
                Console.Write(i + " ");
            };
            Console.WriteLine();
            foreach (string x in sport)
            {
                Console.Write(x + " ");
            };
            Console.WriteLine();
            foreach (string z in Movie)
            {
                Console.Write(z + " " );
            };
            Console.WriteLine();

            //.........................task4.................
            // Console.WriteLine("enter three number");
            //string num1 = Console.ReadLine();
            Console.WriteLine("Enter 3 numbers With addition(,)");
            string su = Console.ReadLine();
            string[] sume = su.Split(',');
            int ss = 0;
            foreach (string u in sume) { ss = ss + Convert.ToInt32(u); }
            Console.WriteLine(ss);


            //.........................task5.................
            int sum = 0;
            for (int num = 1; num <= 100; num++)
            {
                if (num % 2 != 0)
                {
                    sum = sum + num;}

                    }
            Console.WriteLine(sum);
            


            //.........................task6.................

            for (int num2=1; num2<=4; num2++)
                {
                    for (int num3 = 1; num3 <= num2; num3++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            //Console.WriteLine(sum);
            //.........................task7.................
            int cont = 1;
            for (int num4 = 0; num4 < 4; num4++)
            {
                for (int num5 = 0; num5 <= num4; num5++)
                {
                    Console.Write(cont);
                    cont++;
                }
                Console.WriteLine();
            }
        }
        }
    }


