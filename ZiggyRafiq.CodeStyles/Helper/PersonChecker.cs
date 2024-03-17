using ZiggyRafiq.CodeStyles.Models;

namespace ZiggyRafiq.CodeStyles.Helper;
public static class PersonChecker
{
    public static void CheckIfStudent(Person person)
    {
        Console.WriteLine((person is Student student) ? $"{student.Name} is a student at {student.SchoolName}" : $"{person.Name} is not a student.");

    }
}
