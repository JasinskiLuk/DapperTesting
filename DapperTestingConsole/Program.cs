using DapperTesting.DbServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace DapperTesting.ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DbCarServices services = new DbCarServices(GetConnStr());
            var cars = await services.GetCars();
            foreach (var car in cars)
                Console.WriteLine(car.Id + ": " + car.Name + " -> " + car.Price);

            Console.WriteLine("Write car ID:");
            int carId = Convert.ToInt16(Console.ReadLine());

            var auto = await services.GetOneCar(carId);
            Console.WriteLine(auto.Id + ": " + auto.Name + " -> " + auto.Price);
        }

        public static IConfigurationRoot GetConnStr()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", false)
                .Build();
            return builder;
        }
    }
}
