class Program
{

    static void Main(string[] args)
    {
        var russianCities = new List<City>();
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));

        foreach (var longNames in from City 
                 in russianCities.Where(City => City.Name.Length > 10).OrderBy(City => City.Name.Length) select City) 
        {
            Console.WriteLine(longNames.Name);
        }
    }

    public class City
    {
        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public string Name { get; set; }
        public long Population { get; set; }
    }
}