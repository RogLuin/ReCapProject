using DataAccess.Concrete.InMemory;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal 
    {
        List<Car> GetAll();

       void Add(Car car);
       void Uptade(Car car);
       void Delete(Car car);
       //void GetById();

        List<Car> GetAllByCategory(int categoriId);
    }
}
