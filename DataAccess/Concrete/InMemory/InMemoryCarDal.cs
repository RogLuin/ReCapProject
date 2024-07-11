using DataAccess.Abstract;
using Entites.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { BrandId = 1, DailyPrice = 300 , Description = "BMW"},
            new Car { BrandId = 2, DailyPrice = 500 , Description ="Mercedes"},
            new Car { BrandId = 3, DailyPrice = 600 , Description ="AUDİ"},
            new Car { BrandId = 4, DailyPrice = 700 , Description ="HONDA"},
            new Car { BrandId = 5, DailyPrice = 800 , Description ="TOYOTA"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.BrandId == car.BrandId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int categoriId)
        {
            return _cars.Where(c=>c.CategoryId == categoriId).ToList();
        }

        public void Uptade(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c=>c.BrandId==car.BrandId);
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorID = car.ColorID;
        }
    }
}
