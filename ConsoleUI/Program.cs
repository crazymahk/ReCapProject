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
            ColorManager colorManager = new ColorManager(new EFColor());
            BrandManager brandManager = new BrandManager(new EFBrand());

            //BütünArabalarıGetir(carManager);

            //  GETBYBrandid(carManager,3);

            //  carManager.GetCarsByBrandId(1);

            
            foreach (var item in carManager.GetCarsDdetails().Data)
            {
                Console.WriteLine(item.BrandName+" "+ item.CarName+"  " +item.ColorName+ " " + item.DailyPrice);
            }
           // brandManager.Update(new Brand() {BrandID=4,BrandName="Mazda" });
        }

        private static void GETBYBrandid(CarManager carManager , int a)
        {
            foreach (var item in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(item.CarID + " " + item.CarName + " " + item.DailyPrice +item.Description);
            }
        }

        private static void Silinn()
        {
            //Veri olarak eklenenler aşağırekledik

            //ArabaDeneme(carManager);
            //RenkDeneme(colorManager);
            //MarkaDeneme(brandManager);
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

            brandManager.Add(new Brand() {BrandID=1,BrandName="Renault" });
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
    }
}
