﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);






        //Car GetById(int id);

        //List<Car> GetAll();

        //void Add(Car car);
        //void Update(Car car);
        //void Delete(Car car);

    }
}
