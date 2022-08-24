using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many records do you want?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    Person obj = new Person();
                    Console.WriteLine("enter the name");
                    obj.name = Console.ReadLine();
                    Console.WriteLine("enter the age");
                    obj.age = Convert.ToInt32(Console.ReadLine());
                    //obj.address = Console.ReadLine();
                    //obj.salary = Convert.ToDouble(Console.ReadLine());
                    if (obj.valid())
                    {
                        Console.WriteLine(" name " + obj.name + " age " + obj.age);
                    }
                    else
                    {
                        Console.WriteLine("you entered inavalid data");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("invalid data");
                }
            }
        }
    }
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public double salary { get; set; }
        public bool valid()
        {
            if(name.Length==0)
            {
                return false;
            }
            if(age>100)
            {
                return false;
            }
            return true;
        }
    }
}
