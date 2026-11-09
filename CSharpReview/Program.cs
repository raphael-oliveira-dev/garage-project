using System;
using CSharpReview.Models;
using CSharpReview.Services;

namespace CSharpReview;

public class Program
{
    static void Main(string []args)
    {
        GarageMenu garageMenu = new GarageMenu();
        garageMenu.Menu();
    }
}
