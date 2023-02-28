// See https://aka.ms/new-console-template for more information
using Busines.Concrate;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;

CarManager carManager = new CarManager(new InMemoryCarDal());

var list = carManager.GetAll();

foreach (var car in carManager.GetAll())
    Console.WriteLine(car.CarName);

