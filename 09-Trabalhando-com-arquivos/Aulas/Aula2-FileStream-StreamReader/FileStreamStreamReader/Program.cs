namespace Streams;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/tmp/File1.txt";

        FileStream stream = null;
        StreamReader sr = null;

        // alternativally; we can instantiate StreamReader without the fileStream, using the File class:
        // sr = File.OpenText(path);
        try
        {
            stream = new FileStream(path, FileMode.Open);
            sr = new StreamReader(stream);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
        finally
        {
            if (stream != null)
            {
                stream.Close();
            }
            if (sr != null)
            {
                sr.Close();
            }
        }
    }
}
