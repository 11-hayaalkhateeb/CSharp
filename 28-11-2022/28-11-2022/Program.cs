using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28_11_2022
{
    class car
    {
        public int year, Price;
        public string make, model, color, Pallet_No;
        public car(int year1, int price1, string make1, string model1, string color1, string pallet_no1)
        {
            year = year1;
            Price = price1;
            make = make1;
            model = model1;
            color = color1;
            Pallet_No = pallet_no1;
        }
        public string start(string s)
        {
            Console.WriteLine("start");
            return s;
        }
        public string bye(string s)
        {
            Console.WriteLine("bye bye");
            return s;
        }
        public void mycar (string year1, int price1, string make1, string model1, string color1, string pallet_no1) 
        {
                 Console.WriteLine(year1+" "+ price1 + " " + make1 + " " + model1 + " " + color1 + " " + pallet_no1);
}
    }
    class ford : car
    {
        public ford(int year1, int price1, string make1, string model1, string color1, string pallet_no1) : base(year1, price1, make1, model1, color1, pallet_no1)
        {
            //year = year1;
            //Price = price1;
            //make = make1;
            //model = model1;
            //color = color1;
            //Pallet_No = pallet_no1;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
             ford ford_1 = new ford(2020, 22, "hh", "jj", "kk", "jjj");
            car car_1 = new car(2020, 22, "hh", "jj", "kk", "jjj");
            car_1.mycar("2020", 22, "hh", "jj", "kk", "jjj");
            Console.WriteLine(ford_1.year);
         
             car_1.start("haya");
             car_1.bye("bey");



        }
    }
}
