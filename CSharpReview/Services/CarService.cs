using System;
using CSharpReview.Models;

namespace CSharpReview.Services;

public class CarService
{
    List<CarModel> cars = new List<CarModel>();
    GarageMenu garageMenu = new GarageMenu();

    public void RegisterCar(CarModel carModel)
    {
        cars.Add(carModel);
        //Console.WriteLine("----Car In the Garage----");
        //Console.WriteLine($"\tCar: {carModel.CarName}\n\tColor: {carModel.Color}\n\tYear: {carModel.Year}");
    }
    
    public void ShowCar()
    {
        foreach(CarModel car in cars)
        {
            Console.WriteLine($"Model: {car.CarName}\nColor: {car.Color}\nYear: {car.Year}");
        }
    }
}