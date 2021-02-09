using Bussiness.Abstract;
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

        public void Add(Brand marka)
        {
            _ibrandDal.Add(marka);
        }

        public void Delete(Brand marka)
        {
            _ibrandDal.Delete(marka);
        }

        public List<Brand> GetAll()
        {
            return _ibrandDal.GetAll();
        }

        public void Update(Brand marka)
        {
            _ibrandDal.Update(marka);
        }
    }
}
