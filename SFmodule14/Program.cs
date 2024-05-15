class Student 
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }

}

public class Car
{
    public string Manufacturer { get; set; }
    public string CountryCode { get; set; }

    public Car(string manufacturer, string countryCode)
    {
        Manufacturer = manufacturer;
        CountryCode = countryCode;
    }
}

class Program 
{
    static void Main() 
    {
        var cars = new List<Car>()
{
   new Car("Suzuki", "JP"),
   new Car("Toyota", "JP"),
   new Car("Opel", "DE"),
   new Car("Kamaz", "RUS"),
   new Car("Lada", "RUS"),
   new Car("Lada", "RUS"),
   new Car("Honda", "JP"),
};

        cars.RemoveAll(car => car.CountryCode == "JP");

        foreach (Car car in cars) 
        {
            Console.WriteLine(car.Manufacturer + " " + car.CountryCode);
        }
    }
}