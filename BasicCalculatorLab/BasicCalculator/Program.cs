using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal num1 = 0.36m;
            const decimal num3 = 0.6215m;
            const decimal num4 = 0.4275m;
            const decimal num5 = 35.75m;
            const decimal num6 = 35.74m;
            decimal DecimalNum2;


            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the temperature.");

            // int.Parse will take a string data type and convert it to an int data type
            int TempFahr = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Relative humidity.");
            int RelHum = int.Parse(Console.ReadLine());

            decimal DewPoint = (TempFahr - num1 * (100 - RelHum));

            Console.WriteLine("Dew Point is " + DewPoint);

            Console.WriteLine("Enter the wind speed.");
            int WindSpeed = int.Parse(Console.ReadLine());

            double num2 = ExponCal(WindSpeed);

            try
            {
               DecimalNum2 = System.Convert.ToDecimal(num2);
                decimal WindChill = num6 + (num3 * TempFahr) - (num5 * DecimalNum2) + (num4 * TempFahr * DecimalNum2);

                Console.WriteLine("Current wind chill is " + WindChill);
            }
            catch (System.OverflowException)
            {

            }

            
        }
        public static double ExponCal(double input)
        {
            
            double baseNum = input;
            double exponent = .016000;

            double result = Math.Pow(baseNum, exponent);

            return result;
        }
    }
}
