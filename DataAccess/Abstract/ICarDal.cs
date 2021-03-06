﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetByBrandId(int BrandId);

        List<Car> GetByColorId(int ColorId);

        List<Car> GetAll();

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);
    }
}
