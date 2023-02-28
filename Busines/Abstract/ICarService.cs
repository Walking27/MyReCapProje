using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetByUniytPrice(decimal min, decimal max);


    }
}

