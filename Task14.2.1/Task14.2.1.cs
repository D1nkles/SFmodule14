class Program 
{
    static void Main(string[] args) 
    {
        string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };
        var sortedWords = words.Select(s =>
        new
        {
            Name = s,
            Length = s.Length
        })
            .OrderBy(s => s.Length);

        foreach (var word in sortedWords) 
        {
            Console.WriteLine(word);
        }
    }
}