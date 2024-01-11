using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name və Price dəyərləri olan Product classı yaradırsınız.
            //Name dəyəri daxil edilmədən product yaradıla bilməz, Price isə default 10 olur.
            //Proqram işə düşdükdə bizdən neçə ədəd product yaradacağımızı
            //soruşur və daha sonra o sayda product dataları yaradırıq.
            //Bunları bir array içərisində saxlayırsınız və daxil etdiyimiz sayda product datalarını daxil etdikdən sonra
            //o product arrayındəki bütün productların qiymətlərini ortalaması,
            //ən bahalı productın adı və ən ucuz productın adı console-da göstərilir

            Console.WriteLine("nece eded prodect elave etmek istediyinizi daxil edin ");
            int count =Convert.ToInt32(Console.ReadLine());

            product[] product1 = new product[count];

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("ad daxil edin ");
                string name = Console.ReadLine();
                Console.WriteLine("mebleg daxil edin ");
                int price = Convert.ToInt32(Console.ReadLine());
                product newProduct=new product(name, price);
                product1[i] = newProduct;

            }


        }
    }
}
