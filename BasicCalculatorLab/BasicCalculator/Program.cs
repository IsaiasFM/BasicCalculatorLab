﻿using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal num1 = 0.36m;
            const double num3 = 0.621500;
            const double num4 = 0.427500;
            const double num5 = 35.7500;
            const double num6 = 35.7400;
            decimal HeatIndex;

            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the temperature.");
            int TempFahr = int.Parse(Console.ReadLine());

            if (TempFahr > 50)
            {
                Console.WriteLine("Enter the Relative humidity.");
                int RelHum = int.Parse(Console.ReadLine());

                decimal DewPoint = (TempFahr - num1 * (100 - RelHum));

                Console.WriteLine("Dew Point is " + DewPoint);
                HeatIndex = .5m * (TempFahr + 61.0m + ((TempFahr - 68.0m) * 1.2m) + (RelHum * 0.094m));

                Console.WriteLine(HeatIndex);
            }

            else
            {
                Console.WriteLine("Enter the wind speed.");
                int WindSpeed = int.Parse(Console.ReadLine());

                double num2 = ExponCal(WindSpeed);

                double WindChill = num6 + (num3 * TempFahr) - (num5 * num2) + (num4 * TempFahr * num2);

                Console.WriteLine("Current wind chill is " + WindChill);
            }


        }
        public static double ExponCal(double input)
        {

            double baseNum = input;
            double exponent = .1600;

            double result = Math.Pow(baseNum, exponent);

            return result;
        }
    }
}
