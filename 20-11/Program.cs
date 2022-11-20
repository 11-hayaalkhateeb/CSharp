using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
       
namespace _20_11

{
    internal class Program
    {
        static void Main(string[] args)
                                                              //task1
        {
            string name = "haya";
            Console.WriteLine(name);

                                                              //task2

            double avarge = 88.8;
            Console.WriteLine(avarge);

            string lname = "alkhateeb";
            Console.WriteLine(lname);

            char ch = 'h';
            Console.WriteLine(ch);


            bool m = true;
            Console.WriteLine(m);

            int age = 27;
            Console.WriteLine(age);

            const int z = 90;
            Console.WriteLine(z);

                                                                 //task3

            string[] cars = {"BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            //task4
            Console.WriteLine("Input your firstname:");       
            string firstnme = Console.ReadLine();
            Console.WriteLine(firstnme);
            string lastname = Console.ReadLine();
            Console.WriteLine("Input your lastname" + lastname);
            string birth = Console.ReadLine();
            Console.WriteLine("Input your year of birth: " + birth);
            Console.WriteLine(firstnme + lastname + birth);

                                                              //task5
            int[] ss = { 1,1,2,3,4,5,6,7,8,9 };
            Console.WriteLine(ss[0]);
            Console.WriteLine(ss[1]);
            Console.WriteLine(ss[2]);
            Console.WriteLine(ss[3]);
            Console.WriteLine(ss[4]);
            Console.WriteLine(ss[5]);
            Console.WriteLine(ss[6]);
            Console.WriteLine(ss[7]);
            Console.WriteLine(ss[8]);
            Console.WriteLine(ss[9]);
            

            //task6

            int[] mm = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(mm[0] + mm[1] + mm[3]);

        }
    }
}
