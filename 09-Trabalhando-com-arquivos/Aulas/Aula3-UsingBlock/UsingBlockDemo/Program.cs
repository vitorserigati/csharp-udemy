namespace UsingBlockDemo;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/tmp/File1.txt";

        try
        {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
        }
        catch (IOException e)
        {
            Console.WriteLine("Deu Bayblade!");
            Console.WriteLine(e.Message);
        }
    }
}
