using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
   public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal carDal)
        {
            _iCarDal = carDal;
        }

        public List<Car> GetAll()
        {
           return _iCarDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _iCarDal.GetAll(p => p.BrandID == brandid);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _iCarDal.GetAll(p => p.ColorID == colorid);
        }

        public void Add(Car car)
        {
            if (car.Description.Length>=2 && car.DailyPrice>0)
            {
                _iCarDal.Add(car);
            
            }
            else { Console.WriteLine("Yanlış girdi"); }      


        }
    }
}
