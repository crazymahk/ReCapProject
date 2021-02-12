using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
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

        public IDataResult<List<Car>> GetAll()
        {
           return new SuccessDataResult<List<Car>>(_iCarDal.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandid)
        {
            return new  SuccessDataResult<List<Car>>(_iCarDal.GetAll(p => p.BrandID == brandid));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorid)
        {
            return new SuccessDataResult<List<Car>>( _iCarDal.GetAll(p => p.ColorID == colorid));
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length>=2 && car.DailyPrice>0)
            {
                _iCarDal.Add(car);
                Console.WriteLine(car.CarID + " Eklendi");

            }
            return new Result(false, "Message added");   


        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
        }

        public void Update(Car car)
        {
       
        }

        public IDataResult<List<CarDto>> GetCarsDdetails()
        {
            return new SuccessDataResult<List<CarDto>>(_iCarDal.GetCarDetailDtos());
        }
    }
}
