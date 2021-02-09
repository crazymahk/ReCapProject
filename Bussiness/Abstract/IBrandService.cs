using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBrandService
    {

        List<Brand> GetAll();
        void Add(Brand marka);
        void Delete(Brand marka);
        void Update(Brand marka);

    }
}
