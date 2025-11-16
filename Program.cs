using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Task8()
        {
            Console.WriteLine("enter a number");
            int Num=int.Parse(Console.ReadLine());
            if (Num % 2 == 0)
            {
                if (Num % 4 == 0)
                    Console.WriteLine("the number is even and devides in 4");
                else
                    Console.WriteLine("the number is even but does not devide in 4");
            }
            if (Num % 2 == 1)
                Console.WriteLine("the number is not even");
        }
         static void task9()
        {
            Console.WriteLine("what is your username?");
            string admin = Console.ReadLine();
            if (admin == "admin")
            {
                Console.WriteLine("what is your password?");
                int password = int.Parse(Console.ReadLine());
                if (password == 1234)
                    Console.WriteLine("access is premitted");
                else Console.WriteLine("password is incorrect");
            }
            else Console.WriteLine("username does not exist");
        }
        static void task10()
        {
            Console.WriteLine("what is the tempurture");
            double temp=double.Parse(Console.ReadLine());
            if (temp>0 )
            {
                if (temp > 100)
                    Console.WriteLine("the tempurture is bowling");
                else Console.WriteLine("the tempurture is liquid");
            }
            else
                Console.WriteLine("the tempurture is freezing");
        }
        static void task13()
        {
            Console.WriteLine("what is the hour");
            int hour = int.Parse(Console.ReadLine());
            if (hour>0 && hour<12)
            {
                if (hour<6)
                    Console.WriteLine("night");
                else Console.WriteLine("morning");
            }
            else if (hour<24 && hour>=12)
            {
                if (hour > 18)
                    Console.WriteLine("afternoon");
                else Console.WriteLine("evening");
            }

        }
        static void Main(string[] args)
        {
            //Task8();
            //task9();
            //task10();
            task13();
        }

    }
}
