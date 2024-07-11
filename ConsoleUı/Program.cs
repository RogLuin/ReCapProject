// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

ICarService carService = new CarManager(new InMemoryCarDal());

foreach (var item in carService.GetAll())
{
    Console.WriteLine(item.BrandId);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.DailyPrice);
    Console.WriteLine("-------------------");
}
   
