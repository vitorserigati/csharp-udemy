namespace Exercise.Entities;

class Student
{
    public int Id { get; set; }
    public char Course { get; set; }

    public Student(int id, char course)
    {
        Id = id;
        Course = course;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Student)) return false;

        Student other = obj as Student;

        return Id == other.Id;
    }
}
