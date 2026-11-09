using System;
using CSharpReview.Models;

namespace CSharpReview.Services;

public class GarageMenu
{
    public void Menu()
    {
        // Primeira coisa instanciar o CarService 
        CarService carService = new CarService();
        //Teste 1 chamando o CarForm

        CarForm carForm = new CarForm();
        //arrumar isso amanha
        string choice = "0" ?? string.Empty;
        while(choice == "0")
        {
            //arrumar isso amanha
            string option = "";
            Console.WriteLine("----Welcome to Garage System - Menu----");

            Console.WriteLine("Option 1: Register Car");
            Console.WriteLine("Option 2: View Cars registered");
            Console.WriteLien("Option 3: Exit")

            option = (Console.ReadLine() ?? string.Empty) .Trim();
            if(option == "1")
            {
                Console.WriteLine("Move to Register Form");
                carForm.Start(carService);

            }
            if(option == "2")
            {
                Console.WriteLine("Move to Show Cars List");
                carService.ShowCar();
            }
            //arrumar isso amanha
            if(choice == "3")
            {
                break;
            }

        }
        
    }
}