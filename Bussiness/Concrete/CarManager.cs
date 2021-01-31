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


    }
}
