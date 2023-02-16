namespace VetoresF;
using System.Globalization;

public class Student
{
    public string Name;
    public string Email;

    public Student(string name, string email)
    {
        string totittle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
        Name = totittle;
        Email = email;
    }

    public override string ToString()
    {
        return $"{Name}, {Email}";
    }
}
