﻿using System;

using CarLibrary;

namespace CSharpCarClient
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** C# Car Library Client App");
            // Make a sports car.
            SportsCar viper = new SportsCar("Viper", 240, 40);
            viper.TurboBoost();

            // Make a minivan.
            MiniVan mv = new MiniVan();
            mv.TurboBoost();

            Console.WriteLine("Done. Press any key to terminate");
            Console.ReadLine();
        }
    }
}
