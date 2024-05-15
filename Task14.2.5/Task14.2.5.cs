class Contact 
{
    public string Name { get; set; }
    public long Phone { get; set; }
}
class Program 
{
    static void Main(string[] args) 
    {
        var contacts = new List<Contact>()
        {
            new Contact() { Name = "Андрей", Phone = 7999945005 },
            new Contact() { Name = "Сергей", Phone = 799990455 },
            new Contact() { Name = "Иван", Phone = 79999675 },
            new Contact() { Name = "Игорь", Phone = 8884994 },
            new Contact() { Name = "Анна", Phone = 665565656 },
            new Contact() { Name = "Василий", Phone = 3434 }
        };

        int contactsLenght = contacts.Count();
        int pages = contactsLenght / 2;
        int pageCount = 1;
        int skipContacts = 0;
        var startPage = contacts.Take(2);

        foreach (Contact info in startPage) 
        {
            Console.WriteLine(info.Name + "\t" + info.Phone);
        }
        Console.WriteLine($"Страница номер {pageCount}");

        while (true) 
        {
            Console.WriteLine("Для навигации между страницами вводите на клавиатуре стрелочку влево или стрелочку вправо...");
            ConsoleKey userInput = Console.ReadKey().Key;

            if (userInput == ConsoleKey.RightArrow)
            {
                if (skipContacts != contactsLenght - 2) 
                {
                    Console.Clear();
                    skipContacts += 2;
                    pageCount++;
                    foreach (var info in from contact in contacts.Skip(skipContacts).Take(2) select contact) 
                    {
                        Console.WriteLine(info.Name + "\t" + info.Phone);
                    }
                    Console.WriteLine($"Страница номер {pageCount}");
                }
                else 
                {
                    Console.WriteLine("Вы и так на последней странице!");
                }
            }

            else if (userInput == ConsoleKey.LeftArrow)
            {
                if (skipContacts > 0)
                {
                    Console.Clear();
                    skipContacts -= 2;
                    pageCount--;
                    foreach (var info in from contact in contacts.Skip(skipContacts).Take(2) select contact)
                    {
                        Console.WriteLine(info.Name + "\t" + info.Phone);
                    }
                    Console.WriteLine($"Страница номер {pageCount}");
                }

                else 
                {
                    Console.WriteLine("Вы и так на первой странице!");
                }
            }

            else
                Console.WriteLine("");
        }
    }
}