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






             carManager.Add(new Car() { CarID = 1, BrandID =51,ColorID=2,DailyPrice=40,Description="Yılmaz",ModelYear= new DateTime(2018)});
           

            // Console.WriteLine("----------------------------------------");
            // foreach (var item in carManager.GetCarsByBrandId(5))
            // {
            //    Console.WriteLine(item.CarID);
            // }
            //  carManager.DeleteByYilmaz(new Car() { CarID = 15});
          
            foreach (var item in carManager.GetAll())
             {
                 Console.WriteLine(item.CarID);
             }
        }
    }
}
