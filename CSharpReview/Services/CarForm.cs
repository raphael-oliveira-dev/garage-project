using System;
using CSharpReview.Models;

namespace CSharpReview.Services;

public class CarForm
{
    public void Start(CarService carService)
    {
        // To delete - CarService carService = new CarService();
        GarageMenu garageMenu = new GarageMenu();
        
        string option = "y";
        while(option != "n")
        {
            Console.WriteLine("----Welcome To The Garage----");
            Console.WriteLine("_____________________________");

            Console.WriteLine("Input car informations: ");
            
            Console.Write("Car Model: ");
            string carName = (Console.ReadLine() ?? string.Empty).Trim();

            Console.Write("Car Color: ");
            string carColor = (Console.ReadLine() ?? string.Empty).Trim();

            Console.Write("Car Year: ");
            int carYear = int.Parse((Console.ReadLine() ?? "0").Trim());

            CarModel carModel = new CarModel();
            carModel.CarName = carName;
            carModel.Color = carColor;
            carModel.Year = carYear;

            carService.RegisterCar(carModel);
            Console.WriteLine($"Do You Wanna Continue? Press \"y\" to continue or Press \"n\" to exit.");
            option = (Console.ReadLine() ?? string.Empty) .Trim();
            Console.Clear();

            if(option == "n")
            {
              carService.ShowCar();  
            }
        }
        
       
    }
    
    
}