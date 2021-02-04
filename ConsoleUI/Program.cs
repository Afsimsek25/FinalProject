using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID 
    //Open Closed Principle  ( Yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiç bir kodunu değiştirmene gerek yok)
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
