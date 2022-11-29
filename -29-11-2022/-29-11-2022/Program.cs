using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static _29_11_2022.Employee;

namespace _29_11_2022
{
    class Employee
    {
        private int id;
        private string Employees_name;
        private int birth;



        public string employee_name
        {
            get { return Employees_name; }
            set { Employees_name = value; }
        }
        public int Birth
        {
            get { return birth; }

            set { birth = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Employee(int id1, string employee_name1, int birth1)
        {
            this.id = id1;
            this.Employees_name = employee_name1;
            this.Birth = birth1;
        }
        public virtual void print(int id, string Employees_name, int birth1)
        {
            Console.WriteLine(12+" "+"haya"+ " " + 13+"/"+2+"/"+1995);
          
            //public int gg(int c)
            //{
            //    Public void haya(2); 
            //    return c;
            //}
        }
        public virtual void Age(int age)
        {
           
             int age1 = 2022 - age;
             Console.WriteLine(age1);
           
        }
    }
    class manager : Employee
    {

        public manager(int id1, string employee_name1, int birth1) : base(id1, employee_name1, birth1) { }
        public override void Age(int age)
        {
            int age1 = 2022 - age;
            Console.WriteLine(age1);
        }

        public override void print(int id, string Employees_name, int birth1)
        {

            Console.WriteLine(16+"  "+"naqa`a"+" " + 21+"/"+7+"/"+1993);

        }

    }





        internal class Program
        {
            static void Main(string[] args)
            {
                Employee obj1 = new Employee(12, "haya", 13_2_1995);
                //  Console.WriteLine(obj1(12, "haya", "13.2.1995"));
                obj1.Age(1995);
                obj1.print(2, "hh", 1995);
                manager obj2 = new manager(16, "maen", 21_7_1993);
                obj2.Age(1993);
                obj2.print(16, "maen", 1993);
                //obj2.Haya(2, "hh", "nhh");
                {
                }
            }
        }
    }
