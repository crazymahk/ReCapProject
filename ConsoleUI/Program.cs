using Bussiness.Concrete;
using DataAccess.Concrete;
using Entities;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            ColorManager colorManager = new ColorManager(new EFColor());
            BrandManager brandManager = new BrandManager(new EFBrand());
            UserManager userManager = new UserManager(new EFUser());
            CustomerManager customerManager = new CustomerManager(new EFCustomer());


            //BütünArabalarıGetir(carManager);

            //  GETBYBrandid(carManager,3);

            //  carManager.GetCarsByBrandId(1);
            // AllCarDetails(carManager);

          

            //BütünKullancıİsimleriniGetirme(userManager);
           //  BütünMüşteriİsimleriniGetirme(customerManager);
            


        }

        private static void BütünKullancıİsimleriniGetirme(UserManager userManager)
        {
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.FirstName+"  "+item.LastName);
            }
        }
        private static void BütünMüşteriİsimleriniGetirme(CustomerManager cusManager)
        {
            foreach (var item in cusManager.GetAll().Data)
            {
                Console.WriteLine(item.CompanyName);
            }
        }

        private static void AllCarDetails(CarManager carManager)
        {
            foreach (var item in carManager.GetCarsDdetails().Data)
            {
                Console.WriteLine(item.BrandName + " " + item.CarName + "  " + item.ColorName + " " + item.DailyPrice);
            }
        }

        private static void GETBYBrandid(CarManager carManager, int a)
        {
            foreach (var item in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(item.CarID + " " + item.CarName + " " + item.DailyPrice + item.Description);
            }
        }

        private static void Silinn()
        {
            //Veri olarak eklenenler aşağırekledik

            //ArabaDeneme(carManager);
            //RenkDeneme(colorManager);
            //MarkaDeneme(brandManager);
          //  USerDeneme(userManager);
           // CustomerDeneme(customerManager);
        }

        private static void BütünArabalarıGetir(CarManager carManager)
        {
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.CarID + "  numaralı " + item.CarName + " araç günclük ücreti " + item.DailyPrice);
            }
        }


        private static void ArabaDeneme(CarManager carManager)
        {

            carManager.Add(new Car() { CarID = 1, BrandID = 1, ColorID = 1, DailyPrice = 140, Description = "Manuel", CarName = "Symbol" });
            carManager.Add(new Car() { CarID = 2, BrandID = 1, ColorID = 1, DailyPrice = 150, Description = "Auto", CarName = "Symbol-1.6" });
            carManager.Add(new Car() { CarID = 3, BrandID = 2, ColorID = 3, DailyPrice = 150, Description = "Auto", CarName = "Fiesta" });
            carManager.Add(new Car() { CarID = 4, BrandID = 2, ColorID = 4, DailyPrice = 150, Description = "Auto", CarName = "320 İ" });
            carManager.Add(new Car() { CarID = 5, BrandID = 3, ColorID = 2, DailyPrice = 150, Description = "Auto", CarName = "BAGİ" });
            carManager.Add(new Car() { CarID = 6, BrandID = 4, ColorID = 2, DailyPrice = 150, Description = "Auto", CarName = "Rx-7" });

        }

        private static void MarkaDeneme(BrandManager brandManager)
        {

            brandManager.Add(new Brand() { BrandID = 1, BrandName = "Renault" });
            brandManager.Add(new Brand() { BrandID = 2, BrandName = "BMW" });
            brandManager.Add(new Brand() { BrandID = 3, BrandName = "Mercedes" });
            brandManager.Add(new Brand() { BrandID = 4, BrandName = "Mazda" });
        }
        private static void RenkDeneme(ColorManager colorManager)
        {

            colorManager.Add(new Color() { ColorID = 1, ColorName = "Beyaz" });
            colorManager.Add(new Color() { ColorID = 2, ColorName = "Siyah" });
            colorManager.Add(new Color() { ColorID = 3, ColorName = "Kırmızı" });
            colorManager.Add(new Color() { ColorID = 4, ColorName = "MAVİ" });
        }


        private static void USerDeneme(UserManager userManager)
        {
            userManager.Add(new User() { Id = 1, FirstName = "Yılmaz", LastName = "Uçar", Email = "aaa@gmail.com", Password = "11111" });
            userManager.Add(new User() { Id = 2, FirstName = "Emrah", LastName = "öz", Email = "emrhz@gmail.com", Password = "2222" });
            userManager.Add(new User() { Id = 3, FirstName = "Mert", LastName = "Kısaa", Email = "xx_417@gmail.com", Password = "3333" });
            userManager.Add(new User() { Id = 4, FirstName = "Hafini", LastName = "Uzun", Email = "crazy451@gmail.com", Password = "4444" });
            userManager.Add(new User() { Id = 5, FirstName = "Gamze", LastName = "Yoks", Email = "asad@gmail.com", Password = "55555" });
        }

        private static void CustomerDeneme(CustomerManager customerManager)
        {
            customerManager.Add(new Customer() { CompanyName = "Apple", UserId = 1 ,CustomerId=1});
            customerManager.Add(new Customer() { CompanyName = "Samsung", UserId = 2,CustomerId=2 });
            customerManager.Add(new Customer() { CompanyName = "Dell", UserId = 3 ,CustomerId=3});
            customerManager.Add(new Customer() { CompanyName = "Karaambar komyuoncluar", UserId = 4 ,CustomerId=4});
        }
    }
}
