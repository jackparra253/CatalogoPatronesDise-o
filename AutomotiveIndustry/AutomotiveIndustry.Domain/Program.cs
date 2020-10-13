using System;
using AutomotiveIndustry.Domain.Builders;
using AutomotiveIndustry.Domain.Cars;

namespace AutomotiveIndustry.Domain
{
    public class Program
    {
        static void Main(string[] args)
        {
            var director =  new Director();
            var carBuilder = new CarBuilder();
            director.ConstructSportsCar(carBuilder);
            Car car = carBuilder.GetResult();
            Console.WriteLine($"Type {car.TypeCar}");

            var carManualBuilder = new CarManualBuilder();
            director.ConstructSportsCar(carManualBuilder);
            Manual carManual = carManualBuilder.GetResult();
            Console.WriteLine($"Type {carManual.TypeCar}");
        }
    }
}
