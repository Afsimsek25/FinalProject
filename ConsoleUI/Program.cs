using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID 
    //Open Closed Principle  ( Yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiç bir kodunu değiştirmene gerek yok)
    // ilerde IoC ile new lemeyi bırakacağız.
    // DTO = Data Transformation Object
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            // CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);

            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / "  +product.CategoryName);
            }
        }
    }
}
