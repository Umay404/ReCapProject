using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carManager = new CarManager(new EfCarDal());
            List<Car> cars = carManager.GetAll();
            foreach (var car in carManager.GetByBrandId(2))
            {
                Console.WriteLine(car.BrandId+" "+car.Descriptions);
            }

            foreach (var car in carManager.GetByColorId(2))
            {
                Console.WriteLine(car.ColorId+" "+car.Descriptions);
            }
        }
    }
}
