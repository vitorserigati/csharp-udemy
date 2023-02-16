namespace StreamWriterDemo;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"/tmp/File1.txt";
        string targetPath = @"/tmp/File2.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourcePath);
            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach(string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Deu Bayblade parça!");
            Console.WriteLine(e.Message);
        }
    }
}
