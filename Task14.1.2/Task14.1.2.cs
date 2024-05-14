class Program
{
    static void Main(string[] args)
    {
        string[] text = { "Раз два три",
                          "четыре пять шесть",
                          "семь восемь девять" };

        var sequence = from sentence in text from word in sentence.Split(" ") select word;
        foreach (var word in sequence)
        {
            Console.Write(word);
        }

    }
}