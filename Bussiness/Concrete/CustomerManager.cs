using Bussiness.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _icustomerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _icustomerDal = customerDal;
        }

        public IResult Add(Customer costumer)
        {
            if (costumer.CompanyName.Length>2)
            {
                _icustomerDal.Add(costumer);
                return new Result(true, "Kullanıcı Eklendi");
            }
            
            return new Result(false, "Kullanıcı Eklenemedi");
        }

        public IResult Delete(Customer costumer)
        {
            _icustomerDal.Delete(costumer);
            return new Result(true, "Müşteri Silindi");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new DataResult<List<Customer>>(_icustomerDal.GetAll(),true,"Müşteriler Geldi");
        }

        public IResult Update(Customer customer)
        {
            _icustomerDal.Update(customer);
            return new Result(true, "Kullanıc Güncellendi");
        }
    }
}
