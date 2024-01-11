using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class product
    {
        public product(string name) : this(name, 10)
        {
        }

        public product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string name;
        public int price;


        public void Ortalama(product[] productList)
        {
            int boyuk=0;
            int kicik =1000000000;
            for(int i = 0;i<productList.Length;i++)
            {
                
                if(productList[i].price > boyuk)
                {
                   boyuk = productList[i].price;


                }
                
                if (productList[i].price < kicik)
                {
                    kicik = productList[i].price;


                }


            }
            int ortalama =(kicik+boyuk)/2;
            Console.WriteLine(ortalama);



        }
    }
}
