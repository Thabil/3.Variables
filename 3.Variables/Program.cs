using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variable
            string name;
            int age;

            //initialize variables
            name = "Thabile";
            age = 30;
            Console.WriteLine("Hi "+name);
            Console.WriteLine("You are "+age+" years of age.");
            Console.WriteLine("Next year you will be " + (age + 1)); 
            

            age = 30 + 10;
            Console.WriteLine("Next 10 years time you will be " + age);

            //declare and initialize in one line
            string lastName = "Latakgomo";
            Console.WriteLine(" Your last name is " + lastName);

            //console freeze
            Console.ReadLine();
        }
    }
}
