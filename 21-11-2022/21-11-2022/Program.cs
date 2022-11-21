using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
                           //.......................task1......................
            int num1 =  Convert.ToInt16(Console.ReadLine());
            int num2 = Convert.ToInt16(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine(num1);
            }
            else
            { 
                Console.WriteLine(num2);
            }
            Console.WriteLine("\n");
            //.......................task2......................
            int sn = Convert.ToInt16(Console.ReadLine());
            if (sn<0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }

            //.......................task3......................
            Console.WriteLine("\n");
             int[] num3 = {  -50 , 10, 0 };
            Array.Sort(num3);
            Console.WriteLine(num3[0]);
            Console.WriteLine(num3[1]);

            Console.WriteLine(num3[2]);


            /* if ((num3[0]) >(num3[1]) && (num3[1]) > (num3[2])) {
                 Console.WriteLine( num3[0] +" " + num3[1]+" " + num3[2]);
             }
             else if
                  ((num3[1]) > (num3[0]) && (num3[1]) > (num3[2]) )
             {
                 Console.WriteLine(  num3[1] + "" + num3[2] + "" + num3[0]);
             }
             else if
                  ((num3[2]) > (num3[0]) && (num3[2]) > (num3[1]))
             {
                 Console.WriteLine("num3[1]" + num3[3]);
             }
             else if
                  ((num3[2]) > (num3[0]) && (num3[2]) > (num3[1]))
             {
                 Console.WriteLine("num3[1]" + num3[3]);
             }
             else if
                  ((num3[2]) > (num3[0]) && (num3[2]) > (num3[1]))
             {
                 Console.WriteLine("num3[1]" + num3[3]);
             }
             else if
                  ((num3[2]) > (num3[0]) && (num3[2]) > (num3[1]))
             {
                 Console.WriteLine("num3[1]" + num3[3]);
             }*/

            //.......................task4......................
            int[] num4 = { 10, -50, 0, 8 };
            Console.WriteLine(num4.Max());
            Console.WriteLine("\n");

            int[] num5 = { -10, 10, 0, 8 };
            if ((num5[0]) > (num5[1]) && (num5[0]) > (num5[2]) && (num5[0]) > (num5[3]))
            {
                Console.WriteLine("num5[0]" + num5[0]);
            }

            else if  
                 ((num5[1]) > (num5[0]) && (num5[1]) > (num5[2]) && (num5[1]) > (num5[3]))
            { 
                     Console.WriteLine("num5[1]" +num5[1]);
            }
            else if
                ((num5[2]) > (num5[0]) && (num5[2]) > (num5[1]) && (num5[2]) > (num5[3]))
            {
                Console.WriteLine("num5[2]" + num5[2]);
            }

            else if
                ((num5[3]) > (num5[0]) && (num5[3]) > (num5[1]) && (num5[3]) > (num5[2]))
            {
                Console.WriteLine("num5[3]" + num5[3]);
            }

            Console.WriteLine("\n");
            
            //.......................task5......................
            double KM = Convert.ToDouble(Console.ReadLine());

            double miles =   KM / 1.609 ;
            Console.WriteLine(miles);
            Console.WriteLine("\n");
            //.......................task6......................
            double hour = Convert.ToDouble(Console.ReadLine());
            double minut = Convert.ToDouble(Console.ReadLine());
            double hours = hour *60;
            Console.WriteLine(minut + hours);
            Console.WriteLine("\n");
            //.......................task7......................
           
            double minut1 = Convert.ToDouble(Console.ReadLine());
            double hour1 = minut1 / 60;
            Console.WriteLine(hour1 );
            Console.WriteLine("\n");

            //.......................task8......................

            string [] name = { "haya" , "marah" , "bayan", "naqa`a" , "abeer"};

            Console.WriteLine(name[0].Substring(0,3));
            Console.WriteLine(name[1].Substring(0, 3));
            Console.WriteLine(name[2].Substring(0, 3));
            Console.WriteLine(name[3].Substring(0, 3));
            Console.WriteLine(name[4].Substring(0, 3));
        }


    }
    }

