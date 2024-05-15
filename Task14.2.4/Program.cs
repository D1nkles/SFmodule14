using System.Runtime.InteropServices;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
}

class Course 
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Андрей", Age = 23, Languages = new List<string> { "английский", "немецкий" } },
            new Student { Name = "Сергей", Age = 27, Languages = new List<string> { "английский", "французский" } },
            new Student { Name = "Дмитрий", Age = 29, Languages = new List<string> { "английский", "испанский" } },
            new Student { Name = "Василий", Age = 24, Languages = new List<string> { "испанский", "немецкий" } }
        };

        var courses = new List<Course>
        {
            new Course {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
            new Course {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
        };

        var sharpCourse = from student in students
                          where student.Age < 29
                          from course in courses
                          where course.Name == "Язык программирования C#"
                          select new
                          {
                              Name = student.Name,
                              Age = student.Age,
                              Course = course.Name
                          };

        foreach (var student in sharpCourse) 
        {
            Console.WriteLine(student.Name + "\t" + student.Age + "\t" + student.Course);
        }

    }
}