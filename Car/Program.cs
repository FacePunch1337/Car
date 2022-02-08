using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class CAR
    {
        private static string model = "BMW";
        private static string country_manufacturer = "Germany";
        private static int year_of_issue = 1999;
        private static double mileage = 100.000;
        private static bool used = false;

        CAR[] cars;
        public CAR()
        {
            
            

           
        }
                  
        
        public string Model { get { return model; } set { model = model; } }
        public string Country_Manufacturer { get { return country_manufacturer; } set { country_manufacturer = country_manufacturer; } }
        public int Year_Of_Issue { get { return year_of_issue; } set { year_of_issue = year_of_issue; } }
        public double Mileage { get { return mileage; } set { mileage = mileage; } }
        public bool Used { get { return used; } set { used = used; } }

        public void AddCar()
        {
            Console.Write("Модель: ");
            model = Console.ReadLine();
            Console.Write("Страна-производитель: ");
            country_manufacturer = Console.ReadLine();
            Console.Write("Год выпуска: ");
            year_of_issue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Пробег: ");
            mileage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Состояние:\n[0]Новая \n[1]б/у \n Ввод: ");

            int _used = Convert.ToInt32(Console.ReadLine());
            if (_used == 1)
            {
                used = true;
                

            }
            else used = false;
        }
        public void ShowCarInfo()
        {

            Console.WriteLine(model);
            Console.WriteLine(country_manufacturer);
            Console.WriteLine(year_of_issue);
            Console.WriteLine(mileage);
            Console.WriteLine(used);

            
        }
        



    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var car = new CAR();

            car.AddCar();
            car.ShowCarInfo();
            
        }
    }
}
