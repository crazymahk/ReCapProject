using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
   public interface IRentedCarsService
    {
        IDataResult<List<RentedCars>> GetAll();
        IResult Add(RentedCars rentedCar);
        IResult Delete(RentedCars rentedCar);
        void Update(RentedCars rentedCar);
    }
}
