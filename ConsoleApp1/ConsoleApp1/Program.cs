using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fullname, BirthDate, GroupNo, Point xüsusiyyətlərinə və ShowInfo metoduna sahib Student class yaradırsınız.
            //FullName və Point dəyəri təyin olunmamış student obyekti yaradıla bilməz.
            //Proqram açıldıqda bizdən tələbə yaratmaq üçün datalar daxil etməyimizi istyir,
            //daxil edib tələbə obyektini yaradırıq və Shoüİnfo metodu ilə içindəki məlumatlara baxırıq



            Console.WriteLine("ad daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("grup nomresi daxil edin ");
            string groupno = Console.ReadLine();
            Console.WriteLine("ili,ayi ve gunu sira ile daxil edin");
            int year;
            int month;
            int day;
            Console.WriteLine("ili daxil edin ");
            do
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            while (year > 2015 || year < 1980);
            Console.WriteLine("ayi daxil edin ");
            do
            {
                month = Convert.ToInt32(Console.ReadLine());
            }
            while (month < 1 || month > 12);
            Console.WriteLine("gunu daxil edin ");
            do
            {
                day = Convert.ToInt32(Console.ReadLine());
            }
            while (day < 1 || day>30);
            
            
            DateTime date1 = new DateTime(year,month,day);
            
            int point;
            
            do
            {
                Console.WriteLine("xal daxil edin ");
                point = Convert.ToInt32(Console.ReadLine());
            }
            while (point<0 || point>100);

            student student1 = new student(name,point,groupno,date1);

            int operation;

            do
            {
                Console.WriteLine("1.telebeye baxin ");
                Console.WriteLine("2.programi bitirin ");
                operation = Convert.ToInt32(Console.ReadLine()); 
                
                if (operation == 1)
                {
                    student1.showInfo();


                }

            }
            while (operation !=2);
        }
    }
}
