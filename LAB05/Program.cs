using LAB05;

try
{
    Car car1 = new Car("Toyota", "Camry", 2005, 180000);
    car1.PrintCarInfo();

    Car car2 = new Car("Mercedes-Benz", "W123", 1990, 250000);
    car2.PrintCarInfo();

    Car car3 = new Car("LADA", "XRAY", 1884, 200000);
    car3.PrintCarInfo();

    /*/Car car4 = new Car("Volkswagen", "Golf", 2018, -124000);
    car4.PrintCarInfo();/*/
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
