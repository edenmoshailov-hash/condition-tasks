using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void task1()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                    Console.WriteLine("the number is even");
                else Console.WriteLine("the number is not evem");
            }
            else
            {
                if (num < 0)
                    Console.WriteLine("the number is neagitive");
                else Console.WriteLine("the number is 0");
            }

        }
        static void task2()
        {
            double price = 0;
            Console.WriteLine("what is the usage");
            int usage = int.Parse(Console.ReadLine());
            Console.WriteLine("is it business?");
            bool isbusiness = bool.Parse(Console.ReadLine());
            if (usage > 0 && usage < 300)
                price = 0.5 * usage;
            else if (usage > 300 && usage < 600)
                price = 0.7 * usage;
            else if (usage > 600)
                price = usage;

            if (isbusiness == true)
                price *= 1.15;
            else price *= 1.05;
            Console.WriteLine("the total price is" + price);
        }
        static void task3()
        {
            double priceincity = 6;
            double pricenotcity = 12;
            double price = 0;

            Console.WriteLine("are you in city?");
            bool city = bool.Parse(Console.ReadLine());
            Console.WriteLine("are you a student?");
            bool student = bool.Parse(Console.ReadLine());
            Console.WriteLine("are you a retiree?");
            bool retiree = bool.Parse(Console.ReadLine());
            Console.WriteLine("are you a regular person?");
            bool regular = bool.Parse(Console.ReadLine());
            if (city == true)
                price = priceincity;
            else price = pricenotcity;
            if (student == true)
                price *= 0.8;
            else if (retiree == true)
                price *= 0.7;
            else if (regular == true)
                price *= 1;
            Console.WriteLine("the price is:" + price);
        }
        static void task4()
        {
            double baseprice = 0;
            double total = 0;
            Console.WriteLine("what is your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your status (school/vip/none/idf retiree)");
            string status = Console.ReadLine();
            if (age > 0 && age < 18)
            {
                baseprice = 120;
                if (status == "school")
                    total = baseprice * 0.8;
                else total = baseprice;
                Console.WriteLine("the total price is" + total);
            }
            else if (age > 18 && age < 60)
            {
                baseprice = 180;
                if (status == "vip")
                    total = baseprice * 1.3;
                else total = baseprice;
                Console.WriteLine("the total price is" + total);
            }
            else if (age > 60)
            {
                baseprice = 150;
                if (status == "idf retiree")
                    total = baseprice * 0.85;
                else total = baseprice;
                Console.WriteLine("the total price is" + total);
            }

        }
        static void task5()
        {
            double baseprice = 0;
            double total = 0;
            Console.WriteLine("what room do you want? regular or suite");
            string room = Console.ReadLine();
            Console.WriteLine("is it on the weekend?");
            bool weekend = bool.Parse(Console.ReadLine());
            Console.WriteLine("are you vip?");
            bool vip = bool.Parse(Console.ReadLine());
            if (room == "regular")
                baseprice = 400;
            else if (room == "suite")
                baseprice = 700;
            total = baseprice;
           else if (weekend == true)
                total = total * 1.1;
            else total = baseprice;
          else if (vip == true)
                total = total * 0.85;
            Console.WriteLine("the price is" + total);
        }
        static void task6()
        {
            double baseprice = 0;
            double total = 0;
            Console.WriteLine("what is your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("in what day do you visit");
            string day = Console.ReadLine();
            Console.WriteLine("do you have a vip?");
            string isvip = Console.ReadLine();
            Console.WriteLine("do you have a membership ?");
            string ismember = Console.ReadLine();
            if (age > 0 && age < 12)
            {
                baseprice = 50;
                if (day == "saterday")
                    total = baseprice + 10;
                else total = baseprice;
                Console.WriteLine("the price is" + total);
            }
            else if (age > 12 && age < 17)
            {
                baseprice = 70;
                if (ismember == "yes")
                    total = baseprice * 0.8;
                else total = baseprice;
                Console.WriteLine("the price is" + total);
            }
            else if (age >= 18)
            {
                baseprice = 100;
                if (isvip == "yes")
                    total = baseprice * 1.3;
                else total = baseprice;
                Console.WriteLine("the price is" + total);

            }
        }
        static void task7()
        {
            double baseprice = 0;
            double total = 0;
            Console.WriteLine("what is your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("is it a sport car?");
            string issport = Console.ReadLine();
            Console.WriteLine("did you have accident last year?");
            string accidentlastyear = Console.ReadLine();

            if (age <= 24)
            {
                baseprice = 600;
                if (issport == "yes")
                    total = baseprice * 1.25;
                else total = baseprice;

            }
            else if (age > 24 && age <= 50)
            {
                baseprice = 450;
                if (accidentlastyear == "yes")
                    total = baseprice * 1.2;
                else total = baseprice;

            }
            else if (age > 50)
            {
                baseprice = 400;
                if (issport == "no")
                    total = baseprice * 0.9;
                else total = baseprice;

            }
            Console.WriteLine("the price is" + total);
        }
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
        }
    }
}
