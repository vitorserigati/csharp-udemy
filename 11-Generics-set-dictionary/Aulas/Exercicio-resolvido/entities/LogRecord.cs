namespace Problem.Entities;

class LogRecord
{

    public string Name { get; set; }
    public DateTime Time { get; set; }

    public LogRecord(string name, DateTime time)
    {
        Name = name;
        Time = time;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is LogRecord)) return false;

        var other = obj as LogRecord;

        return Name == other?.Name;
    }

}
