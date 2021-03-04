﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Descriptions.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else { Console.WriteLine("Incorrect Entry"); }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId==brandId);
                }

        public List<Car> GetByColorId(int colorId)
        {
            return _carDal.GetAll(c=>c.ColorId==colorId);
                }
    }
}
