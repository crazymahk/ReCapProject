using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _car;

        public InMemory()
        {
            _car = new List<Car> {
            new Car{CarID=1, BrandID=1, ColorID=1, DailyPrice=150, Description="New car with us", ModelYear=new DateTime(2015)},
            new Car{CarID=2, BrandID=1, ColorID=4, DailyPrice=175, Description="New car", ModelYear=new DateTime(2016)},
            new Car{CarID=3, BrandID=2, ColorID=5, DailyPrice=225, Description="New car", ModelYear=new DateTime(2015)},
            new Car{CarID=4, BrandID=3, ColorID=1, DailyPrice=275, Description="New car", ModelYear=new DateTime(2018)},
            new Car{CarID=5, BrandID=4, ColorID=2, DailyPrice=300, Description="New car", ModelYear=new DateTime(2019)},
            new Car{CarID=6, BrandID=4, ColorID=3, DailyPrice=350, Description="New car", ModelYear=new DateTime(2019)},

            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
            Console.WriteLine(car.CarID+" numaralı araç sisteme eklendi.");
        }

        public void Delete(Car car)
        {
            Car deletedCar = _car.SingleOrDefault(p => p.CarID == car.CarID);
            Console.WriteLine(car.CarID + " numaralı araç sistemden silindi.");
            _car.Remove(deletedCar);
      
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
            return _car.Where(p => p.CarID == CarId).ToList();
        }

        public List<CarDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updatedCar = _car.SingleOrDefault(p => p.CarID == car.CarID);
            updatedCar.BrandID = car.BrandID;
            updatedCar.ColorID = car.ColorID;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            updatedCar.ModelYear = car.ModelYear;

        }
    }
}
