namespace Problem;
using Problem.Entities;

class Program
{
    static void Main(string[] args)
    {
        string current_dir = Directory.GetCurrentDirectory();
        string path = current_dir + $"/{args[0]}";
        HashSet<LogRecord> set = new();
        Console.WriteLine($"Searching for file in: {path}");

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split();
                    string name = line[0];
                    DateTime time = DateTime.Parse(line[1]);
                    set.Add(new(name, time));
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"Total users: {set.Count}");
    }
}
