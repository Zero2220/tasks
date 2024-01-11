using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class student
    {
        public student(string fullName1,int point1,string groupNo1 ="grup bilinmir",DateTime birthDate1=default)
        { 
            fullName = fullName1;
            birthDate = birthDate1;
            point = point1;
            groupNo = groupNo1;      
        }

        public string fullName;
        public DateTime birthDate;
        public int point;
        public string groupNo;


        public void showInfo()
        {
            Console.WriteLine("Telebe adi");
            Console.WriteLine(fullName);
            Console.WriteLine("Telebe bali");
            Console.WriteLine(point);
            Console.WriteLine("grup nomresi");
            Console.WriteLine(groupNo);
            Console.WriteLine("dogum ili");
            Console.WriteLine(birthDate);

        }
    }
}
