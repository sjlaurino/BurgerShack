using System;
using System.Collections.Generic;
using burgerShack.Models;

namespace burgerShack
{
  class App
  {
    List<Food> Foods { get; set; }
    List<Drink> Drinks { get; set; }
    List<Side> Sides { get; set; }

    public void Run()
    {
      float orderTotal = 0;
      System.Console.WriteLine("Welcome to the BurgerShack!");
      System.Console.WriteLine("Please select a food by entering it's number or type 'Q' to quit");
      // System.Console.Write(Foods);
      PrintFoods();
      string input1 = System.Console.ReadLine().ToLower();
      if (input1 == "q")
      {
        return;
      }
      else if (Int32.TryParse(input1, out int inputInt))
      {
        orderTotal += Foods[inputInt - 1].Price;
        System.Console.WriteLine("You selected " + Foods[inputInt - 1].Name + " Your order total is now $" + orderTotal);
        System.Console.WriteLine("Select any key to continue to a list of available Sides...");
      };

    }

    public void PrintFoods()
    {
      int i = 0;
      foreach (var food in Foods)
      {
        System.Console.WriteLine(++i + ". " + "{0} {1} {2}", food.Name + '-', food.Description + '-', "$" + food.Price);
      }

    }


    public App()
    {
      Foods = new List<Food>(){
      new Food("Hamburger", "100% grassfed Beef Burger", 7.50F),
      new Food("Cheeseburger", "100% Grassfed Beef Burger w/ Tillamook American Cheese", 8.50F),
      new Food("Hotdog", "100% Unknown Animal Parts", 4.50F)
      };

      Sides = new List<Side>(){
        new Side("Fries", "Made with Idaho Potatoes", 3.50F),
        new Side("Tots", "Made with Idaho Potatoes", 3.50F),
        new Side("Onion Rings", "Battered and Fried Onion Ring", 3.50F)
      };
      Drinks = new List<Drink>(){
        new Drink ("Water", "Tap Water", 7.00F),
        new Drink ("Gatorade", "Sports Drink", 3.00F),
        new Drink ("CocaCola", "SoderPop", 1.50F)
      };
    }
  }
}