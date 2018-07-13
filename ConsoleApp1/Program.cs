using System;
using ConsoleApp1.entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Product[] products = new Product[5];
            var productname = "";
            for (int i = 0; i < 5; i++)
            {
                if(i < 3) {
                    // products[i]
                    products[i] = new Book();
                    productname = string.Format("Product {0}", i+1);
                    products[i]._name = productname;
                    products[i]._id = i;
                    products[i]._price = 2500;
                    Console.WriteLine("Product {0} -Book: (id={1},name={2},price={3}) - computeTax = {4}", i, products[i].id, products[i].name, products[i].price, products[i].computeTax());
                }
                else {

                    products[i] = new Phone();
                    productname = string.Format("Product {0}", i+1);
                    products[i]._name = productname;
                    products[i]._id = i;
                    products[i]._price = 5000;
                    Console.WriteLine("Product {0} -Phone: (id={1},name={2},price={3}) - computeTax = {4}", i, products[i].id, products[i].name, products[i].price, products[i].computeTax());

                }
            }
            


        }
    }
}
