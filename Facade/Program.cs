﻿// See https://aka.ms/new-console-template for more information

using Facade;

Console.Title = "Facade Pattern";

var facade = new DiscountFacade();

Console.WriteLine("Discount percentage for customer with id 1: " +
                  $"{facade.CalculateDiscountPercentage(1)}");
Console.WriteLine("Discount percentage for customer with id 10: " +
                  $"{facade.CalculateDiscountPercentage(10)}");

Console.ReadKey();