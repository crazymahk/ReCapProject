using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
  public  interface IColorService
    {
        List<Color> GetAll();
        void Add(Color renk);
        void Delete(Color renk);
        void Update(Color renk);
    }
}
