using System;

namespace csc141
{
    class Program
    {
        static void Main(string[] args)
        {
            car x1 = new car();
            x1.Drive(90);
            x1.Honk();
            car x2 = new car("red",100,22);
            x2.Honk();
            x2.Drive(240);
            x2.Honk();
            Console.WriteLine(x2);
        
         
        }
    }
    class car
    {
        //data/characteristics/ fleids and properties
        private string vin;
        private double fuel_level;
        private string color;
        private int mileage;
        
        //methods
        
        public void  Drive(int miles)
        
        {
            mileage += Math.Abs(miles);

        }


        public void Honk()
        {
            Console.WriteLine($"VIN = {vin}, fuel level = {fuel_level}. color = {color}, mileage = {mileage}.");
        }
        public override string ToString()
        {
            return String.Format($"VIN = {vin}, fuel level = {fuel_level}. color = {color}, mileage = {mileage}.");
        }
        //ctor
        public car ()
        {
            vin = "FTR432";
            fuel_level = 12;
            color = "blue";
            mileage = 0;
            
        }

        public car(string someColor, int someMiles, double fuel_level)
        {
            color = someColor;
            mileage = someMiles;
            this.fuel_level = fuel_level;
            vin = "unspecified";
            
        }
    }

}
