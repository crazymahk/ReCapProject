using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class RentedCarsManager : IRentedCarsService
    {
        IRentedCar _rentedCar;

        public RentedCarsManager(IRentedCar rentedCar)
        {
            _rentedCar = rentedCar;
        }

        public IResult Add(RentedCars rentedCar)
        {
            var result = CheckReturnDate(rentedCar.CarId);
            if (!result.success)
            {
                return new ErrorResult("");
            }
            _rentedCar.Add(rentedCar);
            return new SuccessResult("xx");
        }

        public IResult Delete(RentedCars rentedCar)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentedCars>> GetAll()
        {
            return new SuccessDataResult<List<RentedCars>>(_rentedCar.GetAll());
        }

        public void Update(RentedCars rentedCar)
        {
            throw new NotImplementedException();
        }

      
        public IResult CheckReturnDate(int carId)
        {
            var result = _rentedCar.GetRentalDetails(x => x.CarId == carId && x.ReturnDate == null);
            if (result.Count > 0)
            {
                return new ErrorResult("aa");
            }
            return new SuccessResult("b");

        }

    }
}
