using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public short ModelYear { get; set; }
        public decimal UnitPrice { get; set; }
        public short DaityPrice { get; set; }
        public string Description { get; set; }
    }
}
