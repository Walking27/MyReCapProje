using Busines.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Concrate
{
    public class CarManager:ICarService
    {
        ICarDal _CarDal;
        public CarManager(ICarDal carDal) 
        {
            _CarDal = carDal;
        }
        public List<Car> GetAll() 
        {
            //İş Kodları
            return _CarDal.GetAll();
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            return _CarDal.GetAll(p => p.CarId == id);
        }

        public List<Car> GetByUniytPrice(decimal min, decimal max)
        {
            return _CarDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }
    }
    
}

