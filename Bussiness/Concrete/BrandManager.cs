using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _ibrandDal;

        public BrandManager(IBrandDal ibrandDal)
        {
            _ibrandDal = ibrandDal;
        }

        public IResult Add(Brand marka)
        {
         _ibrandDal.Add(marka);
            return new Result(true,"Doğans");
        }

        public IResult Delete(Brand marka)
        {
            _ibrandDal.Delete(marka);
            return new Result(true, "Doğans");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>( _ibrandDal.GetAll());
        }

        public void Update(Brand marka)
        {
            _ibrandDal.Update(marka);
        }
    }
}
