using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 1885 || value > 2026)
                {
                    throw new ArgumentException("Год выпуска должен быть в пределах от 1885 до 2026.");
                }
                year = value;
            }
        }
        private double mileage;
        public double Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Пробег не может быть отрицательным.");
                }
                mileage = value;
            }
        }
        public Car(string brand, string model, int year, double mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }
        public int GetCarAge()
        {
            return DateTime.Now.Year - year;
        }
        public bool IsVintage()
        {
            double age = GetCarAge();
            if (age > 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string IsVintageToText()
        {
            if (IsVintage())
            {
                return "Да";
            }
            else
            {
                return "Нет";
            }
        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"Автомобиль: {Brand} {Model}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Пробег: {Mileage} км");
            Console.WriteLine($"Возраст: {GetCarAge()} лет");
            Console.WriteLine($"Винтажный: {IsVintageToText()}");
            Console.WriteLine();
        }
    }
}
