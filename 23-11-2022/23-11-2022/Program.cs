using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _23_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //...........task1............
            int sum = 0;
            int avarge = 0;
            int[] arry = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            {
                for (int x = 1; x < arry.Length; x++)
                {
                    sum = sum + (arry[x]);
                    avarge = sum / arry.Length;
                }

                Console.WriteLine(sum);
                Console.WriteLine(avarge);
            }

            //...........task2............
            int[] myNum = { 1, 2, 3, 4, 5 };
            for (int num1 = 0; num1 < myNum.Length; num1++)
            {
                double sum2 = Math.Pow(myNum[num1], 3);
                Console.WriteLine(sum2);


            }
            //...........task3............

            int[] year = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            for (int x = 0; x < year.Length; x++)
            {
                if (year[x] > 1950)
                { Console.WriteLine(year[x]);
                }



            }
            //...........task4............
            int age = Convert.ToInt16(Console.ReadLine());

            double ageyrar = age * 365;
            Console.WriteLine(ageyrar);
            Console.WriteLine("\n");
            //...........task5............
            int a = 0;
            int b = 0;
            int m = 0;
            int[] legs = { 4, 2, 4 };
            int[] animal = { 3, 7, 5 };
            for (int z = 0; z < legs.Length; z++)
            {
                for (int i = 0; i < animal.Length; i++)
                {
                    m = (legs[z] + animal[i]);
                    a = a + 1;
                    b = b + 1;
                }
                Console.WriteLine(m);
            }
            Console.WriteLine("\n");
            //...........task6............
            //...........task7............
            //...........task8............

            for  (int n = 1900; n <= 2024; n += 4)
                 
            {
                Console.Write(n + " ");


            }
            Console.WriteLine("\n");
            //...........task9............
            int nu = Convert.ToInt16(Console.ReadLine());
            for (a =2 ; a<=nu-1; a++)
            {
                if (nu % a == 0)
                {
                    Console.WriteLine("this number is not prime");
                        return;
                }
               
            }
            Console.WriteLine("this number is prime");
            //...........task9............

            //{
            //    int x = Convert.ToInt16(Console.ReadLine());
            //    sum1 = sum1 + x;
            //}
            //return sum1;

        }

        //static int t1()
        //{
        //    int sum = 0;
        //    for (int num = 1; num <= 10; num++)
        //    {
        //        int x = Convert.ToInt16(Console.ReadLine());
        //        sum = sum + x;
        //    }
        //    return sum;


        //}
        //...........task1............
    }
}

