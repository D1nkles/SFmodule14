using System.Linq;
class Program 
{
    static void Main(string[] args) 
    {
        var objects = new List<object>()
        {
            1,
            "Сергей ",
            "Андрей ",
            300,
        };

        foreach (string name in from object obj in objects.Where(obj => obj is string).OrderBy(obj => obj) select obj) 
            Console.WriteLine(name); 
    }
}