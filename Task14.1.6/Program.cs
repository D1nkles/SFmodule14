class Program 
{
    static void Main(string[] args) 
    {
        var numsList = new List<int[]>()
        {
            new[] {2, 3, 7, 1},
            new[] {45, 17, 88, 0},
            new[] {23, 32, 44, -6},
        };

        var ascendNums = numsList.SelectMany(s => s).OrderBy(num => num);

        foreach (var num in ascendNums) 
        {
            Console.WriteLine(num);
        }
    }
}