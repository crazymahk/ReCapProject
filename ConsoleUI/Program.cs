using Bussiness.Concrete;
using DataAccess.Concrete;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());

           

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarID);
            }


            Car car1 = new Car { CarID = 19, BrandID = 5, ColorID = 2, DailyPrice = 150, ModelYear = new DateTime(1987) , Description="Yılmaz"};
            carManager.Add(car1);

            Console.WriteLine("----------------------------------------");
            foreach (var item in carManager.GetCarsByBrandId(5))
            {
               Console.WriteLine(item.CarID);
            }
        }
    }
}
