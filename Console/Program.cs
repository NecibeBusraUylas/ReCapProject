using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleuI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "  " + car.Description);
            }

            carManager.Add(new Entities.Concrete.Car
            {
                Id = 7, BrandId = 1, ColorId = 2,  ModelYear = 2011, DailyPrice = 255, Description = "Range Rover Evoque"
            });
            Console.WriteLine("\n");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "  " + car.Description);
            }
            Console.WriteLine("\n");

            Console.WriteLine("1) Range Rover 2) Toyota 3) Ford 4) Mini Cooper");
            Console.WriteLine("Enter the number of brand you want to see?");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("--- Range Rover ---");
                    foreach (var car in carManager.GetByBrandId(1))
                    {
                        Console.WriteLine("Model: " + car.Description + "  " + "Dailly Price: " + car.DailyPrice);
                    }
                    break;
                case 2:
                    Console.WriteLine("--- Toyota ---");
                    foreach (var car in carManager.GetByBrandId(2))
                    {
                        Console.WriteLine("Model: " + car.Description + "  " + "Dailly Price: " + car.DailyPrice);
                    }
                    break;
                case 3:
                    Console.WriteLine("--- Ford ---");
                    foreach (var car in carManager.GetByBrandId(3))
                    {
                       Console.WriteLine("Model: " + car.Description + "  " + "Dailly Price: " + car.DailyPrice);
                    }
                    break;
                case 4:
                    Console.WriteLine("--- mİNİ cooper ---");
                    foreach (var car in carManager.GetByBrandId(4))
                    {
                        Console.WriteLine("Model: " + car.Description + "  " +"Dailly Price: " + car.DailyPrice);
                    }
                    break;
                default:
                    Console.WriteLine("ERROR!"); break;

            }

            Car car1 = new Car() { Id = 8, BrandId = 1, ColorId = 2, ModelYear = 2011, DailyPrice = 255, Description = "Range Rover Evoque" };
            carManager.Add(car1);
            Console.WriteLine("\n");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "  " + car.Description);
            }

            carManager.Delete(car1);

            Console.WriteLine("\n");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "  " + car.Description);
            }
            Console.WriteLine("\n");

            Console.WriteLine("1) Black Cars 2) Blue Cars 3) White Cars");
            Console.WriteLine("Enter the number of color you want to see?");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            switch (choice2)
            {
                case 1:
                    Console.WriteLine("--- Black Cars ---");
                    foreach (var car in carManager.GetByColorId(1))
                    {
                        Console.WriteLine("Model: " + car.Description + "  " + "Dailly Price: " + car.DailyPrice);
                    }
                    break;
                case 2:
                    Console.WriteLine("--- Blue Cars ---");
                    foreach (var car in carManager.GetByColorId(2))
                    {
                        Console.WriteLine("Model: " + car.Description + "  " + "Dailly Price: " + car.DailyPrice);
                    }
                    break;
                case 3:
                    Console.WriteLine("--- White Cars ---");
                    foreach (var car in carManager.GetByColorId(3))
                    {
                        Console.WriteLine("Model: " + car.Description + "  " + "Dailly Price: " + car.DailyPrice);
                    }
                    break;
                default:
                    Console.WriteLine("ERROR!"); break;

            }

        }
    }
}
