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
        //...........task1............
        static int sum(int[] marks)
        {
            int sum1 = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum1 += marks[i];

            }
            return sum1;
        }

        //...........task2............
        static void power(int[] number)
        {
            int x = 1;
            //double sum2 = 1;
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("the number is :"+ i);
                x = number[i]* number[i] * number[i];
                Console.WriteLine("and power of the number is:"+x);
                
              // Console.WriteLine(sum2 = Math.Pow(number[i], 3));

            }
            
        }
        //...........task2 readline............
        static void po ()
        {
           
            for (int i = 0; i <=5 ; i++)
            {
                int ss = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(ss * ss * ss);

            }

        }

        //...........task3............

        static void years(int[] year)
        {
            for (int i = 0; i < year.Length; i++)
            {
                if (year[i] > 1950)
                {
                    int x = year[i];
                    Console.WriteLine(year[i]);
                }
                // x = number[i]* number[i] * number[i];
                //Console.WriteLine(x);
               

            }
            
        }
        //...........task4............
        static int  age()
        {
            int z = Convert.ToInt32(Console.ReadLine());


            return z*365;
        }
        //...........task5............
        static int Leg(int ki ,int leg )
        {
           
             ki = Convert.ToInt32(Console.ReadLine());
             leg = Convert.ToInt32(Console.ReadLine());
            int sun8 = ki * leg;
            Console.WriteLine(sun8);

            return sun8 ;
        }
        //...........task6............
        static void login(string[] username, string[] pass)
        {
            Console.WriteLine("please inter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("please inter your password:");
            string password = Console.ReadLine();

            for (int i = 0; i < username.Length; i++)
            {
                if (name == username[i] && password == pass[i])
                {
                    Console.WriteLine("pass");
                    return;
                }
                else
                {
                    Console.WriteLine("failed");
                    return;
                }


            }

        }
        //...........task7............
        static int poweer(int n , int c) 
        {
            
          // int num1= Convert.ToInt32( Console.ReadLine());
         // int  num2= Convert.ToInt32(Console.ReadLine());
           int z = (int) Math.Pow(n,c);
            
            Console.WriteLine(z);
            return z;
        }
        //...........task8............
        static void leap()
        {
           for (int year=1960; year<=2024; year+=4)
            {
                Console.Write(year + "  ");
               
            }
            
        }
        //...........task9............
        static void prime()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num-1; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num + " is not a prime number");
                    return ;

                }
                else
                {
                    Console.WriteLine(num + " is a prime number");
                    return;
                }
            }
        }  //...........task10............
        static void sentance()
        {
            Console.WriteLine("please write a sentance:");
            string sent = Console.ReadLine();
            string[] strings = sent.Split(' ');
            Console.WriteLine(strings.Length);
        }
       
        static void Main(string[] args)
        {
            //...........task1............

            int[] arry = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            double avg = sum(arry) / arry.Length;
            Console.Write("sum of 10 numbers are :  ");
            Console.WriteLine(sum(arry));
            Console.Write("avarge  of 10 numbers are :  ");
            Console.WriteLine(avg);

            //...........task2............

            int[] arry2 = { 1, 2, 3, 4, 5 };
            power(arry2);
            //........task2 readline..........
            //po();

            //........task3..........
            int[] year = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            years(year);

            //........task4.....................
            Console.WriteLine(age());
            //........Task 5....................
            Console.WriteLine("legs kithchen is :");
            Leg(4, 2);
            Console.WriteLine("legs cow is :");
            Leg(4, 4);
            Console.WriteLine("legs rapit is :");
            Leg(5, 4);

            //........Task 6....................
            string[] names = { "haya", "marah", "bayan", "lara" };
            string[] passwords = { "123456", "24680", "13579", "147852" };
            login(names, passwords);
            //...........task7............
            poweer(3, 4);
            //...........task8............
            leap();
            Console.WriteLine("\n");
            //...........task.9...........
            prime();
            //...........task10............
            sentance();
           

        }
     }
    }



