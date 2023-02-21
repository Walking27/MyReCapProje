using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        private int categoryId;

        public InMemoryCarDal() 
        {
            _cars = new List<Car>()
            {
                new Car{CarId = 1, BrandId = "Opel Vetra", ColorId = "Beyaz",  ModelYear = 1999, DaityPrice = 15000, Description = "Temiz Araç" },
                new Car{CarId = 1, BrandId = "toyota corolla", ColorId = "Koyu Yeşil",  ModelYear = 2000, DaityPrice = 15000, Description = "Temiz Araç" },
                new Car{CarId = 1, BrandId = "nissan", ColorId = "Mavi",  ModelYear = 2004, DaityPrice = 18000, Description = "Temiz Araç" },
                new Car{CarId = 1, BrandId = "BMW A5", ColorId = "Kırmızı",  ModelYear = 2006, DaityPrice = 30000, Description = "Temiz Araç" },
                new Car{CarId = 1, BrandId = "Volkswagen Passat", ColorId = "Gri",  ModelYear = 2010, DaityPrice = 25000, Description = "Temiz Araç" }
            }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete =  _cars.SingleOrDefault(c=>c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _cars.Where( c =>c.CategoryId == categoryId).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DaityPrice = car.DaityPrice;
            carToUpdate.Description = car.Description;
                
        }
    }
}
