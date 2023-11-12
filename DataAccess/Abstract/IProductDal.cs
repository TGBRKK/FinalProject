﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//DB'de yapilacak olan operasyonlar(CRUD) bu interface'de olacak.
namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}