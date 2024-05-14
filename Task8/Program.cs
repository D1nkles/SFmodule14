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

        var names = from object obj in objects where obj.GetType() == typeof(string) orderby obj select obj;

        foreach (string name in names) 
        {
            Console.WriteLine(name);
        }
    }
}