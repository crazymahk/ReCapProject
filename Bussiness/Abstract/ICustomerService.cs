using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
   public interface ICustomerService
    {

        IDataResult <List<Customer>> GetAll();

        IResult Add(Customer costumer);
        IResult Delete(Customer costumer);
        IResult Update(Customer customer);
    }
}
